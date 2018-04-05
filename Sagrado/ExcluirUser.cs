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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_CONFIRMAR_Click(object sender, EventArgs e)
        {
            DataBaseConnection bd = new DataBaseConnection();

            bd.openConnection();

            if(TXT_CPF.TextLength > 0)
            {
                String nome = "", adm = "A", nivel;

                String query = "SELECT * FROM USUARIO WHERE CPF_USER ='" + TXT_CPF.Text + "'";
                String queryDelete = "DELETE FROM USUARIO WHERE CPF_USER ='" + TXT_CPF.Text + "'";
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
                    System.Windows.Forms.MessageBox.Show("Este funcionario não pode ser excluido.");
                }
                else
                {
                    DialogResult dr = System.Windows.Forms.MessageBox.Show("Deseja excluir este funcionario?",
                      "Comfirma:", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            DataBaseConnection bdDelete = new DataBaseConnection();
                            bdDelete.openConnection();
                            MySqlCommand cmdDelete = new MySqlCommand(queryDelete, bdDelete.retornaConexao());
                            cmdDelete.ExecuteNonQuery();
                            System.Windows.Forms.MessageBox.Show("O funcionario " + nome + ", foi excluido com sucesso.");
                            new GerenUser().Show();
                            this.Hide();
                            break;
                        case DialogResult.No:
                            System.Windows.Forms.MessageBox.Show("Exclusão cancelada.");
                            break;
                    }
                }
                
            }
            bd.closeConnection();

        }
    }
}
