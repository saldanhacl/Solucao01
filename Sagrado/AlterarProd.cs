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
    public partial class AlterarProd : Form
    {
        int seq;
        String tipoA = "";
        String nomeA = "";
        String precoA = "";


        public AlterarProd(String preco, String nome, String tipo, int id)
        {
            
            seq = id;
            MessageBox.Show("tipo>>> "+tipo);
            tipoA = tipo.ToString();
            nomeA = nome.ToString();
            precoA = preco.ToString();

            InitializeComponent();
            preenche();
        }

        public void preenche()
        {
            text_nome.Text = this.nomeA;
            text_tipo.Text = this.tipoA;
            text_preco.Text = this.precoA;
        }

        private void BTN_CONF_Click(object sender, EventArgs e)
        {
            

            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();

            String tipo = text_tipo.Text.ToString().ToUpper();
            String nome = text_nome.Text.ToString().ToUpper();
            float preco = float.Parse(text_preco.Text.ToString());


            if (text_tipo.Text.Length > 0 && text_nome.Text.Length > 0 && text_preco.Text.Length > 0)
            {
                String query = "UPDATE PRODUTO SET " +
                "NOME_PRODUTO = '" + nome +
                "', TYPE_PRODUTO = '" + tipo +
                "', PRECO_PRODUTO = '" + preco +
                "' WHERE NRSEQPRODUTO = " + seq;

                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
                cmd.ExecuteNonQuery();
                MessageBox.Show("PRODUTO CADASTRADO COM SUCESSO");

            }

            else
            {
                MessageBox.Show("PREENCHA OS CAMPOS OBRIGATÓRIOS");
            }


            bd.closeConnection();
        }

        private void text_preco_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificarTecla(e, "preco", text_preco);
        }

        private void VerificarTecla(KeyPressEventArgs e, String tipo, TextBox box)
        {
                       
            char keypress = e.KeyChar;
            if (tipo == "numero" && !(char.IsDigit(keypress) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                MessageBox.Show("DIGITE APENAS NÚMEROS");
                e.Handled = true;
            }

            else if (tipo == "preco" && !(char.IsDigit(keypress) || e.KeyChar == Convert.ToChar(Keys.Back)) && box.Text.IndexOf('.') != -1)
            {
                MessageBox.Show("DIGITE PREÇO VÁLIDO");
                e.Handled = true;
            }

        }

    }
  
}
