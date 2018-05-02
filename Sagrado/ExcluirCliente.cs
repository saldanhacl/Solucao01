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
public partial class ExcluirCliente : Form
{
    private bool encontrouCliente = false;

        public ExcluirCliente()
        {
            InitializeComponent();
            this.CenterToScreen();

            TextBox TXT_CPF_CLIENTE = new TextBox();
            TXT_CPF_CLIENTE.MaxLength = 11;

        }

        private void TXT_CPF_CLIENTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keypress = e.KeyChar;
            if (!(char.IsDigit(keypress) || e.KeyChar == Convert.ToChar(Keys.Back)))
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

            if (TXT_CPF_CLIENTE.TextLength > 0)
            {
                String nome = "";

                String query = "SELECT * FROM CLIENTE WHERE CPF_CLIENTE ='" + TXT_CPF_CLIENTE.Text + "'";
                String queryDelete = "DELETE FROM CLIENTE WHERE CPF_CLIENTE ='" + TXT_CPF_CLIENTE.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());

                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    encontrouCliente = true;
                    nome = reader["NOME_CLIENTE"].ToString();
                }

                if (!encontrouCliente)
                {
                    MessageBox.Show("CLIENTE NÃO ENCONTRADO");
                    encontrouCliente = false;
                }
                else
                {

                    if (nome.Length < 0)
                    {
                        MessageBox.Show("CLIENTE NÃO EXCLUÍDO");
                    }
                    else
                    {
                        DialogResult dr = System.Windows.Forms.MessageBox.Show("DESEJA EXCLUIR CLIENTE " + nome.ToUpper() + " ?",
                            "CONFIRMA:", MessageBoxButtons.YesNo);
                        switch (dr)
                        {
                            case DialogResult.Yes:
                                DataBaseConnection bdDelete = new DataBaseConnection();
                                bdDelete.openConnection();
                                MySqlCommand cmdDelete = new MySqlCommand(queryDelete, bdDelete.retornaConexao());
                                cmdDelete.ExecuteNonQuery();
                                System.Windows.Forms.MessageBox.Show("CLIENTE EXCLUÍDO COM SUCESSO");
                                this.Hide();
                                break;
                            case DialogResult.No:
                                System.Windows.Forms.MessageBox.Show("EXCLUSÃO CANCELADA");
                                break;
                        }
                    }
                }


            }
            bd.closeConnection();
        }
    }
}
