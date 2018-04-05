using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Sagrado
{
    public partial class GerenciaFunc : Form
    {

        private String cpfAnterior = "";
         public GerenciaFunc()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void GerenciaFunc_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();
            String nome = textBox6.Text;
            String cpf = textBox4.Text;
            String tel = textBox3.Text;
            String cel = textBox2.Text;
            String email = textBox1.Text;
            String rg = textBox5.Text;

            String query = "UPDATE USUARIO SET " +
                "NOME_USER = '" + nome +
                "', CPF_USER = '" + cpf +
                "', TEL_USER = '" + tel +
                "', CEL_USER = '" + cel +
                "', EMAIL_USER = '" + email + comboBox1.Text +
                "', RG_USER = '" + rg +
                "' WHERE CPF_USER = '" + cpfAnterior + "'";

            MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
            int numRowsAfetada = cmd.ExecuteNonQuery();
            if(numRowsAfetada > 0)
            {
                System.Windows.Forms.MessageBox.Show("O usuário " + nome + ", foi alterado com sucesso.");
                new MenuAdm().Show();
                this.Hide();
            }

            bd.closeConnection();
            
        }
        
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            DataBaseConnection bd = new DataBaseConnection();

            if (cpffunc.TextLength > 0)
            {
                bd.openConnection();
                String query = "SELECT * FROM USUARIO WHERE CPF_USER = '" + cpffunc.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    textBox4.Text = reader["CPF_USER"].ToString();
                    textBox6.Text = reader["NOME_USER"].ToString();

                    textBox3.Text = reader["TEL_USER"].ToString();
                    cpfAnterior = cpffunc.Text;

                    textBox2.Text = reader["CEL_USER"].ToString();

                    String email = reader["EMAIL_USER"].ToString();
                    String[] emailarray = email.Split('@');
                    textBox1.Text = emailarray[0];

                    textBox5.Text = reader["RG_USER"].ToString();
                }
                cpffunc.Text = "";
                bd.closeConnection();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Usuário não encontrado.");
                cpffunc.Text = "";
            }
            
        }
    }
}
