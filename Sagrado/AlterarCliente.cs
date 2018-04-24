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
    public partial class AlterarCliente : Form
    {
        private String cpfAnterior = "";

        public AlterarCliente()
        {
            InitializeComponent();
            this.CenterToScreen();

            TextBox TXT_TEL_CLIENTE = new TextBox();
            TXT_TEL_CLIENTE.MaxLength = 10;

            TextBox TXT_CEL_CLIENTE = new TextBox();
            TXT_CEL_CLIENTE.MaxLength = 11;

            TextBox TXT_CPF_CLIENTE = new TextBox();
            TXT_CPF_CLIENTE.MaxLength = 11;

        }

        private void BTN_SEARCH_CLIENTE_Click(object sender, EventArgs e)
        {
            DataBaseConnection bd = new DataBaseConnection();
            if (TXT_CPF_CLIENTE.TextLength > 0)
            {
                bd.openConnection();

                String query = "SELECT * FROM CLIENTE WHERE CPF_CLIENTE ='" + TXT_CPF_CLIENTE.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    while (reader.Read())
                    {
                        TXT_NOME_CLIENTE.Text = reader["NOME_CLIENTE"].ToString();
                        TXT_TEL_CLIENTE.Text = reader["TELEFONE_CLIENTE"].ToString();
                        TXT_CEL_CLIENTE.Text = reader["CEL_CLIENTE"].ToString();


                        cpfAnterior = TXT_CPF_CLIENTE.Text;

                    }

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("CLIENTE NÃO ENCONTRADO");
                }


           
            }

            TXT_CPF_CLIENTE.Text = "";
            bd.closeConnection();

        }

        private void BTN_CANCELAR_CLIENTE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_CONFIRMAR_CLIENTE_Click(object sender, EventArgs e)
        {
            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();

            String nome = TXT_NOME_CLIENTE.Text;
            String cpf = TXT_CPF_CLIENTE.Text;
            String tel = TXT_TEL_CLIENTE.Text;
            String cel = TXT_CEL_CLIENTE.Text;


            String query = "UPDATE CLIENTE SET " +
                "NOME_CLIENTE = '" + nome +
                "', CPF_CLIENTE = '" + cpfAnterior +
                "', TELEFONE_CLIENTE = '" + tel +
                "', CEL_CLIENTE = '" + cel +
                "' WHERE CPF_CLIENTE = " + cpfAnterior;


            if (Validador.campoPreenchido(nome))
            {

                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
                try
                {
                    int numRowAfetada = cmd.ExecuteNonQuery();
                    if (numRowAfetada > 0)
                    {
                        System.Windows.Forms.MessageBox.Show("DADOS ALTERADOS COM SUCESSO");
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

      

        private void TXT_TEL_CLIENTE_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TXT_CEL_CLIENTE_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AlterarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
