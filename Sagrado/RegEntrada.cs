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
                    MessageBox.Show("Registro realizado com sucesso!!");

                    new RegEntrada().Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Digite um preço válido");
                    boxPrice.Text = "";
                }

            }
            catch (MySqlException)
            {
                MessageBox.Show("Error de conexão com o banco de dados.");
            }

            bd.closeConnection();
        }

        private void BTN_CONFIRMAR_Click(object sender, EventArgs e)
        {

            String numero = getLastIndex();
            //MessageBox.Show("Número de retorno vazio"+numero);
            
            //se não houver registros, não ha saldo anterior para somar.
            if(numero == "") 
            {
                saveRegister(0);
            }
            else
            {
                String ultSaldo = getLastValue(numero);
                float ultSaldoF = float.Parse(ultSaldo);
                //MessageBox.Show("Saldo anterior: " + ultSaldo);
                saveRegister(ultSaldoF);
            }
            
        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
