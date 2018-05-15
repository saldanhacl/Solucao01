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

            TextBox textBox3 = new TextBox();
            textBox3.MaxLength = 8;

            TextBox textBox2 = new TextBox();
            textBox2.MaxLength = 11;

            TextBox textBox5 = new TextBox();
            textBox5.MaxLength = 11;

            TextBox textBox6 = new TextBox();
            textBox6.MaxLength = 10;

        }      

        private void textBox3_KeyPressed(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BTN_CANC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_CONF_Click(object sender, EventArgs e)
        {
            DataBaseConnection bd = new DataBaseConnection();

            bd.openConnection();



            String nome = textBox1.Text;
            String dtnascimento = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            String rg = Validador.FormataCpfAndRg(RG_FUNC.Text);
            String cpf = Validador.FormataCpfAndRg(CPF_FUNC.Text);
            String tel = Validador.FormataTelAndCel(TEL_FUNC.Text);
            String cel = Validador.FormataTelAndCel(CEL_FUNC.Text);
            String email = textBox4.Text;
            String senha = textBox7.Text;
            String confirmasenha = textBox8.Text;
            String sexo = null;
            String tipo = null;



            if (radioButton1.Checked == true) sexo = "m";
            else if (radioButton2.Checked == true) sexo = "f";

            if (radioButton3.Checked == true) tipo = "B";
            else if (radioButton4.Checked == true) tipo = "A";



            if (Validador.campoPreenchido(rg) &&
                Validador.campoPreenchido(cpf) &&
                Validador.campoPreenchido(senha) &&
                Validador.campoPreenchido(confirmasenha) &&
                Validador.campoPreenchido(nome))
            {

                if (senha == confirmasenha)
                {
                    String query = "INSERT INTO USUARIO " +
                    "(CPF_USER, NOME_USER, TEL_USER, CEL_USER, EMAIL_USER, NIVEL_USER, DTNASCIMENTO_USER, SEXO_USER, RG_USER, SENHA_USER)" +
                    " VALUES ('" + cpf + "','" + nome + "','" + tel + "','" + cel + "','" +
                    email + "','" + tipo + "','" + dtnascimento + "','" + sexo + "','" + rg + "','" + senha + "')";

                    //MessageBox.Show(query);

                    MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
                    cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("USUÁRIO CADASTRADO COM SUCESSO");

                    this.Close();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("AS SENHAS DEVEM SER IGUAIS");
                    textBox7.Text = "";
                    textBox8.Text = "";
                }
            }
            else
            {
                MessageBox.Show("PREENCHA OS CAMPOS OBRIGATÓRIOS");
            }


            bd.closeConnection();
        }
    }
}
