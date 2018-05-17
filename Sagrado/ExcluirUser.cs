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
    public partial class ExcluirUser : Form
    {
        public ExcluirUser()
        {
            InitializeComponent();

            TextBox TXT_CPF = new TextBox();
            TXT_CPF.MaxLength = 11;
        }

        private void TXT_CPF_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BTN_CONF_Click(object sender, EventArgs e)
        {
            DataBaseConnection bd = new DataBaseConnection();

            bd.openConnection();

            if (TXT_CPF.TextLength > 0)
            {
                String nome = "", adm = "A", nivel = "";

                String query = "SELECT * FROM USUARIO WHERE CPF_USER ='" + Validador.FormataCpfAndRg(TXT_CPF.Text) + "'";
                String queryDelete = "DELETE FROM USUARIO WHERE CPF_USER ='" + Validador.FormataCpfAndRg(TXT_CPF.Text) + "'";
                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nome = reader["NOME_USER"].ToString();
                    nivel = reader["NIVEL_USER"].ToString();
                }
                bd.closeConnection();

                if (nome.Length < 0 || adm.Equals(nivel))
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

        private void BTN_CANC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExcluirUser_Load(object sender, EventArgs e)
        {

        }
    }
}
