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
    public partial class AlterarFunc : Form
    {

        private String cpfAnterior = "";
         public AlterarFunc()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        
    
        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            DataBaseConnection bd = new DataBaseConnection();
            if(TXT_CPF.TextLength > 0)
            {
                bd.openConnection();

                String query = "SELECT * FROM USUARIO WHERE CPF_USER ='" + TXT_CPF.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TXT_NOME.Text = reader["NOME_USER"].ToString();
                    TXT_TEL.Text = reader["TEL_USER"].ToString();
                    TXT_CEL.Text = reader["CEL_USER"].ToString();
                    TXT_EMAIL.Text = reader["EMAIL_USER"].ToString();
                    TXT_RG.Text = reader["RG_USER"].ToString();
                    TXT_SENHA.Text = reader["SENHA_USER"].ToString();

                    cpfAnterior = TXT_CPF.Text;

                    String nivel = reader["NIVEL_USER"].ToString();
                    String sexo = reader["SEXO_USER"].ToString();

                    if (nivel == "A") RD_ADMIN.Checked = true;
                    else if (nivel == "B") RD_FUNC.Checked = true;

                    if (sexo == "f") RD_FEM.Checked = true;
                    else if (sexo == "m") RD_MASC.Checked = true;
                }


            }

            TXT_CPF.Text = "";
            bd.closeConnection();

        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_CONFIRMAR_Click(object sender, EventArgs e)
        {

            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();

            String nome = TXT_NOME.Text;
            String cpf = TXT_CPF.Text;
            String tel = TXT_TEL.Text;
            String cel = TXT_CEL.Text;
            String email = TXT_EMAIL.Text;
            String senha = TXT_SENHA.Text;
            String rg = TXT_RG.Text;
            String datanascimento = TXT_DATE.Value.ToString("yyyy-MM-dd HH:mm:ss");

            String nivel = null;
            String sexo = null;

            if (RD_ADMIN.Checked == true) nivel = "A";
            else if (RD_FUNC.Checked == true) nivel = "B";

            if (RD_FEM.Checked == true) sexo = "f";
            else if (RD_MASC.Checked == true) sexo = "m";

            String query = "UPDATE USUARIO SET " +
                "NOME_USER = '" + nome +
                "', CPF_USER = '" + cpfAnterior +
                "', TEL_USER = '" + tel +
                "', CEL_USER = '" + cel +
                "', EMAIL_USER = '" + email +
                "', NIVEL_USER = '" + nivel +
                "', SEXO_USER = '" + sexo +
                "', SENHA_USER = '" + senha +
                "', RG_USER = '" + rg +
                "', DTNASCIMENTO_USER = '" + datanascimento +
                "' WHERE CPF_USER = " + cpfAnterior;

            MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
            try
            {
                int numRowAfetada = cmd.ExecuteNonQuery();
                if (numRowAfetada > 0)
                {
                    System.Windows.Forms.MessageBox.Show("O usuário " + nome + ", foi alterado com sucesso.");
                    new GerenUser().Show();
                    this.Hide();
                }
            }
            catch (MySqlException)
            {
                System.Windows.Forms.MessageBox.Show("Error ao alterar funcionario.");
            }
            

            

            bd.closeConnection();

        }

        private void TXT_CPF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
