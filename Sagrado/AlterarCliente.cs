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

//   TODO - ALTERAR TODA A PARTE DE BD QUANDO A TABELA DE CLIENTE FOR CRIADA

namespace Sagrado
{
    public partial class AlterarCliente : Form
    {
        private String cpfAnterior = "";

        public AlterarCliente()
        {
            InitializeComponent();
            this.CenterToScreen();

            TextBox TXT_RG_CLIENTE = new TextBox();
            TXT_RG_CLIENTE.MaxLength = 8;

            TextBox TXT_TEL_CLIENTE = new TextBox();
            TXT_TEL_CLIENTE.MaxLength = 10;

            TextBox TXT_CEL_CLIENTE = new TextBox();
            TXT_CEL_CLIENTE.MaxLength = 11;

            TextBox TXT_CPF_CLIENTE = new TextBox();
            TXT_CPF_CLIENTE.MaxLength = 11;

        }

        private void BTN_SEARCH_CLIENTE_Click(object sender, EventArgs e)
        {
            DataBaseConnection bd = new DataBaseConnection();
            if (TXT_CPF_CLIENTE.TextLength > 0)
            {
                bd.openConnection();

                String query = "SELECT * FROM USUARIO WHERE CPF_USER ='" + TXT_CPF_CLIENTE.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TXT_NOME_CLIENTE.Text = reader["NOME_USER"].ToString();
                    TXT_TEL_CLIENTE.Text = reader["TEL_USER"].ToString();
                    TXT_CEL_CLIENTE.Text = reader["CEL_USER"].ToString();
                    TXT_EMAIL_CLIENTE.Text = reader["EMAIL_USER"].ToString();
                    TXT_RG_CLIENTE.Text = reader["RG_USER"].ToString();
                    TXT_SENHA_CLIENTE.Text = reader["SENHA_USER"].ToString();

                    cpfAnterior = TXT_CPF_CLIENTE.Text;

                    String nivel = reader["NIVEL_USER"].ToString();
                    String sexo = reader["SEXO_USER"].ToString();

                    if (sexo == "f") RD_FEM_CLIENTE.Checked = true;
                    else if (sexo == "m") RD_MASC_CLIENTE.Checked = true;
                }


            }

            TXT_CPF_CLIENTE.Text = "";
            bd.closeConnection();

        }

        private void BTN_CANCELAR_CLIENTE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_CONFIRMAR_CLIENTE_Click(object sender, EventArgs e)
        {
            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();

            String nome = TXT_NOME_CLIENTE.Text;
            String cpf = TXT_CPF_CLIENTE.Text;
            String tel = TXT_TEL_CLIENTE.Text;
            String cel = TXT_CEL_CLIENTE.Text;
            String email = TXT_EMAIL_CLIENTE.Text;
            String senha = TXT_SENHA_CLIENTE.Text;
            String rg = TXT_RG_CLIENTE.Text;
            String datanascimento = TXT_DATE_CLIENTE.Value.ToString("yyyy-MM-dd HH:mm:ss");

            String nivel = null;
            String sexo = null;

            if (RD_FEM_CLIENTE.Checked == true) sexo = "f";
            else if (RD_MASC_CLIENTE.Checked == true) sexo = "m";

            String query = "UPDATE USUARIO SET " +
                "NOME_USER = '" + nome +
                "', CPF_USER = '" + cpfAnterior +
                "', TEL_USER = '" + tel +
                "', CEL_USER = '" + cel +
                "', EMAIL_USER = '" + email +
                "', NIVEL_USER = '" + nivel +
                "', SEXO_USER = '" + sexo +
                "', SENHA_USER = '" + senha +
                "', RG_USER = '" + rg +
                "', DTNASCIMENTO_USER = '" + datanascimento +
                "' WHERE CPF_USER = " + cpfAnterior;


            if (Validador.campoPreenchido(rg) &&
                Validador.campoPreenchido(senha) &&
                Validador.campoPreenchido(nome))
            {

                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
                try
                {
                    int numRowAfetada = cmd.ExecuteNonQuery();
                    if (numRowAfetada > 0)
                    {
                        System.Windows.Forms.MessageBox.Show("DADOS ALTERADOS COM SUCESSO");
                        new GerenUser().Show();
                        this.Hide();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    System.Windows.Forms.MessageBox.Show("ERRO NA ALTERAÇÃO");
                }

            }
            else
            {
                MessageBox.Show("PREENCHA OS CAMPOS OBRIGATÓRIOS");
            }

            bd.closeConnection();
        }

        private void TXT_RG_CLIENTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (char.IsDigit(keypress) || e.KeyChar == Convert.ToChar(Keys.Back))
            {


            }
            else
            {
                MessageBox.Show("DIGITE APENAS NÚMEROS");
                e.Handled = true;
            }
        }

        private void TXT_TEL_CLIENTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (char.IsDigit(keypress) || e.KeyChar == Convert.ToChar(Keys.Back))
            {


            }
            else
            {
                MessageBox.Show("DIGITE APENAS NÚMEROS");
                e.Handled = true;
            }
        }

        private void TXT_CEL_CLIENTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (char.IsDigit(keypress) || e.KeyChar == Convert.ToChar(Keys.Back))
            {


            }
            else
            {
                MessageBox.Show("DIGITE APENAS NÚMEROS");
                e.Handled = true;
            }
        }

        private void TXT_CPF_CLIENTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (char.IsDigit(keypress) || e.KeyChar == Convert.ToChar(Keys.Back))
            {


            }
            else
            {
                MessageBox.Show("DIGITE APENAS NÚMEROS");
                e.Handled = true;
            }
        }
    }
}
