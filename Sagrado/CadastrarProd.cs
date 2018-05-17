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
    public partial class CadastrarProd : Form
    {
        public CadastrarProd()
        {
            InitializeComponent();
        }

        private void BTN_CONF_Click(object sender, EventArgs e)
        {
           


            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox4.Text.Length > 0)
            {

                DataBaseConnection bd = new DataBaseConnection();

                bd.openConnection();

                String tipo = textBox1.Text.ToString().ToUpper();
                String nome = textBox2.Text.ToString().ToUpper();
                int quantidade = 0;
                float preco = float.Parse(textBox4.Text.ToString());


                String query = "INSERT INTO PRODUTO " +
                "(TYPE_PRODUTO, QTD_PRODUTO, PRECO_PRODUTO, NOME_PRODUTO)" +
                " VALUES ('" + tipo + "','" + quantidade + "','" + preco + "','" + nome + "')";
      
                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
                cmd.ExecuteNonQuery();
                MessageBox.Show("PRODUTO CADASTRADO COM SUCESSO");
                bd.closeConnection();
                limpaCampos();
            }

            else
            {
                MessageBox.Show("PREENCHA OS CAMPOS OBRIGATÓRIOS");
            }


            
        }

        private void BTN_CANC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificarTecla(e, "preco", textBox4);
        }

        private void limpaCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
        }

        //MÉTODO PARA VERIFICAR CADA LETRA DO BOX. 
        //SÓ PASSAR O TIPO DE BOX PRECISA ASSIM A GENTE NÃO PRECISA FICAR REPETINDO CÓDIGO OU FAZENDO DIFERENTE.
        private void VerificarTecla(KeyPressEventArgs e, String tipo, TextBox box)
        {
            char ch = e.KeyChar;
            if (ch == 46 && box.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

       
    }
}
