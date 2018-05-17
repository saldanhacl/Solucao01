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
    public partial class Login : Form
    {

        private String cpf = null;
        private String nome = null;
        private String email = null;
        private String cel = null;
        private String telefone = null;
        private String sequencial = null;
        private String senhaConsultada = null;
        private String nivel = null;


       

        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }


        private void saveLog()
        {
            DataBaseConnection conexaoDeControle = new DataBaseConnection();
            conexaoDeControle.openConnection();

            String query = "INSERT INTO controle_log (NOME_USER_LOG, " +
                "CPF_USER_LOG, " +
                "CEL_USER_LOG, " +
                "TEL_USER_LOG, " +
                "EMAIL_USER_LOG, " +
                "NRSEQ_USER)" +
                "VALUES" +
                "('" + this.nome + "','" + this.cpf + "','" + this.cel + "','" + this.telefone +
                "','" + this.email + "','" + this.sequencial + "')";

            MySqlCommand cmdDeControle = new MySqlCommand(query, conexaoDeControle.retornaConexao());
            cmdDeControle.ExecuteNonQuery();

            conexaoDeControle.closeConnection();
            conexaoDeControle.closeConnection();
        }

        private string logar()
        {

            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();
            String query = "SELECT * FROM USUARIO WHERE CPF_USER =" + Validador.FormataCpfAndRg(TXT_CPF_CLIENTE.Text);
            MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
            MySqlDataReader reader = cmd.ExecuteReader();

           
            if (reader.Read())
            {
                this.cpf = reader["CPF_USER"].ToString();
                this.nome = reader["NOME_USER"].ToString();
                this.email = reader["EMAIL_USER"].ToString();
                this.cel = reader["CEL_USER"].ToString();
                this.telefone = reader["TEL_USER"].ToString();
                this.sequencial = reader["NRSEQ_USER"].ToString();

                this.senhaConsultada = reader["SENHA_USER"].ToString();
                this.nivel = reader["NIVEL_USER"].ToString();
            }

            bd.closeConnection();

            if (this.senhaConsultada == textBox2.Text) return nivel;
            else return "S";
            
            
        }

    
        private void BTN_CONF_Click(object sender, EventArgs e)
        {
            if (TXT_CPF_CLIENTE.Text.Length < 1 || textBox2.Text.Length < 1)
            {
                MessageBox.Show("PREENCHA OS CAMPOS");
            }
            else
            {
                string getLogar = logar();

                if (getLogar != "S")
                {
                    if (getLogar == "A" && radioButton1.Checked == true)
                    {
                        new MenuAdm().ShowDialog();
                        saveLog();
                        this.Close();
                    }
                    else if (getLogar == "B" && radioButton2.Checked == true)
                    {
                        new MenuFunc().ShowDialog();
                        saveLog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("TIPO DE USUÁRIO INCORRETO");
                    }
                }
                else
                {
                    MessageBox.Show("SENHA OU CPF INCORRETO");
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
