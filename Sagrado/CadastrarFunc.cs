using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sagrado
{
    public partial class CadastrarFunc : Form
    {
       
        public CadastrarFunc()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_CONFIRMAR_Click(object sender, EventArgs e)
        {

            DataBaseConnection bd = new DataBaseConnection();

                bd.openConnection();

                String nome = textBox1.Text;
                String dtnascimento = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                String rg = textBox3.Text;
                String cpf = textBox2.Text;
                String tel = textBox6.Text;
                String cel = textBox5.Text;
                String email = textBox4.Text;
                String senha = textBox7.Text;
                String confirmasenha = textBox8.Text;
                String sexo = null;
                String tipo= null;


                if (radioButton1.Checked == true) sexo = "m";
                else if (radioButton2.Checked == true) sexo = "f";

                if (radioButton3.Checked == true) tipo = "B";
                else if (radioButton4.Checked == true) tipo = "A";



                if (senha == confirmasenha)
                {
                    String query = "INSERT INTO USUARIO " +
                    "(CPF_USER, NOME_USER, TEL_USER, CEL_USER, EMAIL_USER, NIVEL_USER, DTNASCIMENTO_USER, SEXO_USER, RG_USER, SENHA_USER)" +
                    " VALUES ('" + cpf + "','" + nome + "','" + tel + "','" + cel + "','" +
                    email + "','" + tipo + "','" + dtnascimento + "','" + sexo + "','" + rg + "','" + senha + "')";
                
                    MessageBox.Show(query);

                    MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
                    cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Funcionario cadastrado com sucesso!!");

                    this.Close();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("A senha e confirma senha, não estão iguais. Digite novamente");
                    textBox7.Text = "";
                    textBox8.Text = "";
                }


            bd.closeConnection();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
