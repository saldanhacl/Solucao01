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
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }


        private string logar()
        {
            String cpf="",nome="",email="",cel="",telefone="",sequencial="";
            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();
            String query = "SELECT * FROM USUARIO WHERE CPF_USER =" + textBox1.Text;
            MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
            MySqlDataReader reader = cmd.ExecuteReader();

            string senhaConsultada = null;
            string nivel = null ;

            if (reader.Read())
            {
                cpf = reader["CPF_USER"].ToString();
                nome = reader["NOME_USER"].ToString();
                email = reader["EMAIL_USER"].ToString();
                cel = reader["CEL_USER"].ToString();
                telefone = reader["TEL_USER"].ToString();
                sequencial = reader["NRSEQ_USER"].ToString();
                
                senhaConsultada = reader["SENHA_USER"].ToString();
                nivel = reader["NIVEL_USER"].ToString();
            }

            if(senhaConsultada == textBox2.Text)
            {
                DataBaseConnection conexaoDeControle = new DataBaseConnection();
                conexaoDeControle.openConnection();

                query = "INSERT INTO controle_log (NOME_USER_LOG, " +
                    "CPF_USER_LOG, " +
                    "CEL_USER_LOG, " +
                    "TEL_USER_LOG, " +
                    "EMAIL_USER_LOG, " +
                    "NRSEQ_USER)" +
                    "VALUES" +
                    "('"+ nome+"','" + cpf + "','" + cel + "','" + telefone + 
                    "','" + email + "','" + sequencial+"')";

                MySqlCommand cmdDeControle = new MySqlCommand(query, conexaoDeControle.retornaConexao());
                cmdDeControle.ExecuteNonQuery();

                conexaoDeControle.closeConnection();

                bd.closeConnection();
                return nivel;        
            }
            else {
                bd.closeConnection();
                return "S";
            }
            
        }

                

        private void BTN_CONFIRMAR_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length < 1 || textBox2.Text.Length < 1)
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
                        new MenuAdm().Show();
                        this.Hide();
                    }
                    else if (getLogar == "B" && radioButton2.Checked == true)
                    {
                        new MenuFunc().Show();
                        this.Hide();
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
    }
}
