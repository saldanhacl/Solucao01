﻿using System;
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

            TextBox TXT_RG = new TextBox();
            TXT_RG.MaxLength = 8;

            TextBox TXT_TEL = new TextBox();
            TXT_TEL.MaxLength = 10;

            TextBox TXT_CEL = new TextBox();
            TXT_CEL.MaxLength = 11;

            TextBox TXT_CPF = new TextBox();
            TXT_CPF.MaxLength = 11;
        }
     
        private void TXT_RG_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TXT_TEL_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TXT_CEL_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BTN_SEARCH_PROD_Click(object sender, EventArgs e)
        {
            DataBaseConnection bd = new DataBaseConnection();
            if (TXT_CPF.TextLength > 0)
            {
                bd.openConnection();

                String query = "SELECT * FROM USUARIO WHERE CPF_USER ='" + Validador.FormataCpfAndRg(TXT_CPF.Text) + "'";
                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());

                MySqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    MessageBox.Show("Usúario não encontrado.");
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

                        cpfAnterior = TXT_CPF.Text;

                        String nivel = reader["NIVEL_USER"].ToString();
                        String sexo = reader["SEXO_USER"].ToString();

                        if (nivel == "A") RD_ADMIN.Checked = true;
                        else if (nivel == "B") RD_FUNC.Checked = true;

                        if (sexo == "f") RD_FEM.Checked = true;
                        else if (sexo == "m") RD_MASC.Checked = true;
                    }
                }
                


            }

            TXT_CPF.Text = "";
            bd.closeConnection();
        }

        private void BTN_CANC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_CONF_Click(object sender, EventArgs e)
        {
            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();

            String nome = TXT_NOME.Text;
            String cpf = TXT_CPF.Text;
            String tel = Validador.FormataTelAndCel(TXT_TEL.Text);
            String cel = Validador.FormataTelAndCel(TXT_CEL.Text);
            String email = TXT_EMAIL.Text;
            String senha = TXT_SENHA.Text;
            String rg = Validador.FormataCpfAndRg(TXT_RG.Text);
            String datanascimento = TXT_DATE.Value.ToString("yyyy-MM-dd HH:mm:ss");

            String nivel = null;
            String sexo = null;

            if (RD_ADMIN.Checked == true) nivel = "A";
            else if (RD_FUNC.Checked == true) nivel = "B";

            if (RD_FEM.Checked == true) sexo = "f";
            else if (RD_MASC.Checked == true) sexo = "m";

            cpfAnterior = Validador.FormataCpfAndRg(cpfAnterior);

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


            if (Validador.campoPreenchido(rg) &&
                Validador.campoPreenchido(senha) &&
                Validador.campoPreenchido(nome))
            {

                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
                try
                {
                    int numRowAfetada = cmd.ExecuteNonQuery();
                    if (numRowAfetada > 0)
                    {
                        System.Windows.Forms.MessageBox.Show("DADOS ALTERADOS COM SUCESSO");
                        new GerenUser().Show();
                        this.Hide();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    System.Windows.Forms.MessageBox.Show("ERRO NA ALTERAÇÃO");
                }

            }
            else
            {
                MessageBox.Show("PREENCHA OS CAMPOS OBRIGATÓRIOS");
            }

            bd.closeConnection();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

