using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sagrado
{
    public partial class RegEntrada : Form
    {
        public RegEntrada()
        {
            InitializeComponent();
            this.atualizarSaldoTela();
            this.atualizarListaCliente();
        }

        private void boxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(ch == 46 && boxPrice.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
            
        }

        private string getLastValue(String index)
        {

            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();

            String query = "SELECT VALOR_ATUAL_CAIXA FROM caixa WHERE NRSEQABERTURA = '"+index+"'";
            MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());

            MySqlDataReader reader = cmd.ExecuteReader();

            String valorAtual = null;

            while (reader.Read())
            {
                valorAtual = reader["VALOR_ATUAL_CAIXA"].ToString();
            }

            bd.closeConnection();

            return valorAtual;
        }

        private string getLastIndex()
        {
            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();

            String query = "SELECT MAX(NRSEQABERTURA) FROM caixa";
            MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
      
            MySqlDataReader reader = cmd.ExecuteReader();

            String numero = null;

            while (reader.Read())
            {
                numero = reader["MAX(NRSEQABERTURA)"].ToString();
            }

            bd.closeConnection();

            return numero;
        }

        private void saveRegister(float saldoAnt)
        {

            DataBaseConnection bd = new DataBaseConnection();

            try
            {
                bd.openConnection();

                String preco = boxPrice.Text;
                String operacao = null;

                if (radioButton1.Checked) operacao = "v";
                else if (radioButton2.Checked) operacao = "f";
                else if (radioButton3.Checked) operacao = "e";

                //MessageBox.Show("Preço na tela: " + preco);

                float precoFloat = float.Parse(preco);
                float saldoAtual;

                if (boxPrice.Text.Length != 0)
                {

                    saldoAtual = precoFloat + saldoAnt;

                    //MessageBox.Show("Saldo atual: " + saldoAtual.ToString());


                    String query = "INSERT INTO CAIXA " +
                    "(TYPE_ENTRADA_CAIXA, DATE_MODIFY_CAIXA, VALOR_ENTRADA_CAIXA, VALOR_ATUAL_CAIXA)" +
                    " VALUES ('" + operacao + "', now()," + precoFloat + "," + saldoAtual + ")";

                    //MessageBox.Show(query);

                    MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("REGISTRO CADASTRADO COM SUCESSO");

                    new RegEntrada().Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("DIGITE UM VALOR VÁLIDO");
                    boxPrice.Text = "";
                }

            }
            catch (MySqlException)
            {
                MessageBox.Show("ERRO NO BANCO DE DADOS");
            }

            bd.closeConnection();
        }

        private void BTN_CONFIRMAR_Click(object sender, EventArgs e)
        {
            if (boxPrice.Text.Length == 0) MessageBox.Show("DIGITE UM VALOR");
            else{
                String valorTextBox = boxPrice.Text.ToString();
                String numero = getLastIndex();
                //MessageBox.Show("Número de retorno vazio"+numero);

                //se não houver registros, não ha saldo anterior para somar.
                if (numero == "")
                {
                    saveRegister(0);
                }
                else
                {
                    String ultSaldo = getLastValue(numero);
                    float ultSaldoF = float.Parse(ultSaldo);
                    saveRegister(ultSaldoF);
                }

                if(radioButton2.Checked == true)
                {
                    String nomeCliente = LISTA_CLIENTES.SelectedItem.ToString();
                    saveCliente(nomeCliente, valorTextBox);
                }

            }

            
            
        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void atualizarSaldoTela()
        {
            String numero = getLastIndex();
            
            if (numero == "")
            {
                TXT_SALDOATUAL.Text = "0";
            }
            else
            {
                String ultSaldo = getLastValue(numero);
                TXT_SALDOATUAL.Text = ultSaldo;
            }
        }
         
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LISTA_CLIENTES.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            LISTA_CLIENTES.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            LISTA_CLIENTES.Enabled = true;
        }

 
        private void atualizarListaCliente()
        {
            LISTA_CLIENTES.Items.Clear();

            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();

            String query = "SELECT * FROM cliente";
            MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());

            MySqlDataReader reader = cmd.ExecuteReader();

            String nome = null;

            while (reader.Read())
            {
                nome = reader["CPF_CLIENTE"].ToString();
                LISTA_CLIENTES.Items.Add(nome);
            }
            bd.closeConnection();
        }


        private void saveCliente(String cpf, String saldo)
        {
            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();

            String query = "UPDATE CLIENTE SET " +
                "SALDO_ATUAL_CLIENTE = SALDO_ATUAL_CLIENTE + '" + float.Parse(saldo) +
                "' WHERE CPF_CLIENTE = " + cpf;


            if (cpf != null)
            {

                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
                try
                {
                    int numRowAfetada = cmd.ExecuteNonQuery();
                    if (numRowAfetada > 0)
                    {
                        this.Hide();
                    }
                }
                catch (MySqlException)
                {
                    MessageBox.Show("SALDO DO CLIENTE NÃO ALTERADO");
                }

            }
            else
            {
                MessageBox.Show("PREENCHA OS CAMPOS OBRIGATÓRIOS");
            }

            bd.closeConnection();


        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            new CadastrarCliente().Show();
        }

        private void LISTA_CLIENTES_Click(object sender, EventArgs e)
        {
            atualizarListaCliente();
        }
    }
}
