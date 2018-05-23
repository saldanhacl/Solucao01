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
     partial class RegEntrada : Form
    {

        Form adicionarProdutosComanda;
        List<Produto> produtosComanda;
        String cpfUser = "";
        String operacao = "";
        Double total;

        public RegEntrada()
        {
            InitializeComponent();
            this.atualizarSaldoTela();
            this.atualizarListaCliente();
                    
        }

        public RegEntrada(Form form)
        {
            InitializeComponent();
            this.atualizarSaldoTela();
            this.atualizarListaCliente();
            adicionarProdutosComanda = form;
        }

        public void setListaProdutos(List<Produto> produtos)
        {
            produtosComanda = produtos;
        }

        private String getLastLogin()
        {

            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();

            String query = "SELECT CPF_USER_LOG FROM controle_log ORDER BY NRSEQLOGIN_LOG DESC LIMIT 1";

            MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
            
            MySqlDataReader reader = cmd.ExecuteReader();

           
            while (reader.Read())
            {
                cpfUser = reader["CPF_USER_LOG"].ToString();  
            }
            bd.closeConnection();

            return cpfUser;
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

                if (radioButton1.Checked) operacao = "v";
                else if (radioButton2.Checked) operacao = "f";
                else if (radioButton3.Checked) operacao = "e";

                //MessageBox.Show("Preço na tela: " + preco);

                float precoFloat = float.Parse(preco);
                float saldoAtual;
                String cpf = getLastLogin();

                if (boxPrice.Text.Length != 0)
                {

                    if (operacao != "f")
                    {
                        saldoAtual = precoFloat + saldoAnt;
                    } else
                    {
                        saldoAtual = saldoAnt;
                    }

                    //MessageBox.Show("Saldo atual: " + saldoAtual.ToString());


                    String query = "INSERT INTO CAIXA " +
                    "(TYPE_ENTRADA_CAIXA, DATE_MODIFY_CAIXA, VALOR_ENTRADA_CAIXA, VALOR_ATUAL_CAIXA, CPF_FUNCIONARIO)" +
                    " VALUES ('" + operacao + "', now()," + precoFloat + "," + saldoAtual + "," + cpf + ")";

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
            salvarVendaBanco();
        }



       

        private void salvarVendaBanco()
        {
            long idVenda = -1;
            Double valorVenda = 0;
            String query;
            MySqlCommand cmd;

            DataBaseConnection bd = new DataBaseConnection();
            DataBaseConnection bd2 = new DataBaseConnection();
            try
            {
                bd.openConnection();

                 query = "INSERT INTO VENDA " +
                "(VALOR_VENDA, TYPE_VENDA)" +
                " VALUES (" + 0 + ",'" + operacao + "')";


                cmd = new MySqlCommand(query, bd.retornaConexao());
                cmd.ExecuteNonQuery();

                query = "SELECT MAX(NRSEQVENDA) FROM VENDA;";
                cmd = new MySqlCommand(query, bd.retornaConexao());
                cmd.ExecuteNonQuery();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    idVenda = long.Parse(reader["MAX(NRSEQVENDA)"].ToString());
                }

                bd.closeConnection();

                bd2.openConnection();

                if (produtosComanda != null)
                {
                    foreach (Produto p in produtosComanda)
                    {
                            valorVenda += p.preco * p.quantidade;
                            query = "INSERT INTO QUANTIDADE_PRODUTO " +
                            "(QUANTIDADE, NRSEQPRODUTO, NRSEQVENDA)" +
                            " VALUES (" + p.quantidade + "," + p.idProduto + "," + idVenda + ")";


                            cmd = new MySqlCommand(query, bd2.retornaConexao());
                            cmd.ExecuteNonQuery();
                    }
                } else
                {
                            query = "INSERT INTO VENDA " +
                            "(VALOR_VENDA, TYPE_VENDA)" +
                            " VALUES (" + total + ",'" + operacao + "')";

                            cmd = new MySqlCommand(query, bd2.retornaConexao());
                            cmd.ExecuteNonQuery();
                }
                query = "UPDATE venda SET VALOR_VENDA = " + valorVenda + " where NRSEQVENDA = " + idVenda + " ;";

                cmd = new MySqlCommand(query, bd2.retornaConexao());
                cmd.ExecuteNonQuery();
            }

            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            bd2.closeConnection();
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
            String cpf = null;
                
            while (reader.Read())
            {
                nome = reader["NOME_CLIENTE"].ToString();
                cpf = reader["CPF_CLIENTE"].ToString();
                Cliente cliente = new Cliente(nome, cpf);
                LISTA_CLIENTES.Items.Add(cliente);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TXT_SALDOATUAL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LISTA_CLIENTES_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AdicionarProdutosComanda(this).Show();
        }

        public void setBoxPriceText(String preco)
        {
            boxPrice.Text = preco;
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            total = Double.Parse(boxPrice.Text);

            if (boxPrice.Text.Length == 0) MessageBox.Show("DIGITE UM VALOR");
            else
            {
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

                if (radioButton2.Checked == true)
                {
                    Cliente cliente = (Cliente)LISTA_CLIENTES.SelectedItem;
                    saveCliente(cliente.cpf, valorTextBox);
                }

            }

        }
    }
}
