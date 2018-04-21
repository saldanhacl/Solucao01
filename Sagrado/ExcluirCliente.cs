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
    public partial class ExcluirCliente : Form
    {
        public ExcluirCliente()
        {
            InitializeComponent();
            this.CenterToScreen();

            TextBox TXT_CPF_CLIENTE = new TextBox();
            TXT_CPF_CLIENTE.MaxLength = 11;

        }

        private void BTN_CONFIRMAR_CLIENTE_Click(object sender, EventArgs e)
        {
            DataBaseConnection bd = new DataBaseConnection();

            bd.openConnection();

            if (TXT_CPF_CLIENTE.TextLength > 0)
            {
                String nome = "";

                String query = "SELECT * FROM USUARIO WHERE CPF_USER ='" + TXT_CPF_CLIENTE.Text + "'";
                String queryDelete = "DELETE FROM USUARIO WHERE CPF_USER ='" + TXT_CPF_CLIENTE.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nome = reader["NOME_USER"].ToString();
                }
                bd.closeConnection();

                if (nome.Length < 0)
                {
                    System.Windows.Forms.MessageBox.Show("USUÁRIO NÃO EXCLUÍDO");
                }
                else
                {
                    DialogResult dr = System.Windows.Forms.MessageBox.Show("DESEJA EXCLUIR?",
                      "CONFIRMA:", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            DataBaseConnection bdDelete = new DataBaseConnection();
                            bdDelete.openConnection();
                            MySqlCommand cmdDelete = new MySqlCommand(queryDelete, bdDelete.retornaConexao());
                            cmdDelete.ExecuteNonQuery();
                            System.Windows.Forms.MessageBox.Show("USUÁRIO EXCLUÍDO COM SUCESSO");
                            new GerenUser().Show();
                            this.Hide();
                            break;
                        case DialogResult.No:
                            System.Windows.Forms.MessageBox.Show("EXCLUSÃO CANCELADA");
                            break;
                    }
                }

            }
            bd.closeConnection();
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

        private void BTN_CANCELAR_CLIENTE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
