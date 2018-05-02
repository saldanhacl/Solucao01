﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sagrado;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sagrado
{
    public partial class ConsultarCliente : Form
    {
        public ConsultarCliente()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }

        string cpf;
        //Mesma ideia do consultar user
        private void botaoConsultar(object sender, EventArgs e)
        {
            cpf = textBox1.Text;
            if (cpf.Equals(""))
            {
                MessageBox.Show("DIGITE O CPF");
            }
            else
            {
                DataBaseConnection bd = new DataBaseConnection();
                bd.openConnection();
                string Query = "SELECT * FROM CLIENTE WHERE CPF_CLIENTE = '" + this.cpf + "'";
                MySqlCommand cmd = new MySqlCommand(Query, bd.retornaConexao());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBox2.Text = reader["NOME_CLIENTE"].ToString();
                    textBox3.Text = reader["CPF_CLIENTE"].ToString();
                    textBox4.Text = reader["TELEFONE_CLIENTE"].ToString();
                    TXT_DIVIDA_CLIENTE.Text = reader["SALDO_ATUAL_CLIENTE"].ToString();
                    textBox7.Text = reader["CEL_CLIENTE"].ToString();
                }
                bd.closeConnection();
                if (float.Parse(TXT_DIVIDA_CLIENTE.Text) < 0.0) { 
                //label2.Hide();
                label9.Show();
            }
            }
        }
       
        private void text_Willer_KeyPressed(object sender, KeyPressEventArgs e)
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

        private void TXT_DIVIDA_CLIENTE_TextChanged(object sender, EventArgs e)
        {
            if ((TXT_DIVIDA_CLIENTE.Text).ToString() == "0") TXT_DIVIDA_CLIENTE.ForeColor = Color.MediumSeaGreen;
            else TXT_DIVIDA_CLIENTE.ForeColor = Color.OrangeRed;
        }

        private void BTN_CANC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_CONF_Click(object sender, EventArgs e)
        {
            if (text_Willer.Text.Equals(""))
                MessageBox.Show("DIGITE UM VALOR PARA RETIRADA");
            else
            {
                float valor = float.Parse(text_Willer.Text);
                float divida = float.Parse(TXT_DIVIDA_CLIENTE.Text);


                if (valor > divida || valor < 0) MessageBox.Show("DIGITE UM VALOR VÁLIDO");

                else
                {
                    DataBaseConnection bd = new DataBaseConnection();
                    bd.openConnection();
                    divida = divida - valor;
                    string query = "UPDATE CLIENTE SET SALDO_ATUAL_CLIENTE = '" + divida + "'WHERE CPF_CLIENTE = '" + this.cpf + "'";
                    MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
                    cmd.ExecuteNonQuery();
                    bd.closeConnection();
                    MessageBox.Show("SALDO FOI ATUALIZADO COM SUCESSO");
                    this.Close();
                }
            }
        }
    }


}

