﻿using System;
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
    public partial class ConsultarUser : Form
    {
        public ConsultarUser()
        {
            InitializeComponent();
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

        private void BTN_SEARCH2_Click(object sender, EventArgs e)
        {
            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();

            String query = "SELECT * FROM USUARIO WHERE CPF_USER ='" + Validador.FormataCpfAndRg(TXT_CPF.Text) + "'";
            MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());

            MySqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("Usúario não existe.");
            }
            else
            {
                while (reader.Read())
                {
                    TXT_NOME.Text = reader["NOME_USER"].ToString();
                    TXT_TEL.Text = reader["TEL_USER"].ToString();
                    TXT_CEL.Text = reader["CEL_USER"].ToString();
                    TXT_EMAIL.Text = reader["EMAIL_USER"].ToString();
                    TXT_RG.Text = reader["RG_USER"].ToString();
                    TXT_SENHA.Text = reader["SENHA_USER"].ToString();

                    String nivel = reader["NIVEL_USER"].ToString();
                    String sexo = reader["SEXO_USER"].ToString();

                    if (nivel == "A") RD_ADMIN.Checked = true;
                    else if (nivel == "B") RD_FUNC.Checked = true;

                    if (sexo == "f") RD_FEM.Checked = true;
                    else if (sexo == "m") RD_MASC.Checked = true;
                }
            }
            

            bd.closeConnection();
        }

        private void BTN_CANC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RD_FUNC_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
