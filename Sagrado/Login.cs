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
            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();
            String query = "SELECT * FROM USUARIO WHERE CPF_USER =" + textBox1.Text;
            MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
            MySqlDataReader reader = cmd.ExecuteReader();

            string senhaConsultada = null;
            string nivel = null ;

            if (reader.Read())
            {
                senhaConsultada = reader["SENHA_USER"].ToString();
                nivel = reader["NIVEL_USER"].ToString();
            }

            if(senhaConsultada == textBox2.Text)
            {
                //MessageBox.Show(senhaConsultada);
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
                MessageBox.Show("Preencha os campos.");
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
                        MessageBox.Show("Tipo de usuário incorreto.");
                    }
                }
                else
                {
                    MessageBox.Show("Senha ou usuário incorreto.");
                }
            }



        }
    }
}
