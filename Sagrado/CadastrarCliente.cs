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
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
            this.CenterToScreen();

            TextBox textBox4 = new TextBox();
            textBox4.MaxLength = 11;

            TextBox textBox6 = new TextBox();
            textBox6.MaxLength = 11;

            TextBox textBox2 = new TextBox();
            textBox2.MaxLength = 11;
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
            String cpf = textBox4.Text;
            String tel = textBox6.Text;
            String cel = textBox2.Text;
            float saldo = 1000;


            if ((Validador.campoPreenchido(cpf) &&
                Validador.campoPreenchido(nome) &&
                Validador.campoPreenchido(tel))  ||
                (Validador.campoPreenchido(cpf) &&
                Validador.campoPreenchido(nome) &&
                Validador.campoPreenchido(cel)))
            

                
                {
                    String query = "INSERT INTO CLIENTE " +
                    "(CPF_CLIENTE, NOME_CLIENTE, TELEFONE_CLIENTE, CEL_CLIENTE, SALDO_ATUAL_CLIENTE)" +
                    " VALUES ('" + cpf + "','" + nome + "','" + tel + "','" + cel + "','" + saldo+"')";

                    //MessageBox.Show(query);

                    MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
                    cmd.ExecuteNonQuery();
                    System.Windows.Forms.MessageBox.Show("Cliente CADASTRADO COM SUCESSO");

                    this.Close();
                }
            
            else
            {
                MessageBox.Show("PREENCHA OS CAMPOS OBRIGATÓRIOS");
            }


            bd.closeConnection();

        }


        private void textBox4_KeyPressed(object sender, KeyPressEventArgs e)
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

        private void textBox6_KeyPressed(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPressed(object sender, KeyPressEventArgs e)
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
