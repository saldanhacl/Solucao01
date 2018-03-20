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
    public partial class GerenciaFunc : Form
    {
         public GerenciaFunc()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void GerenciaFunc_Load(object sender, EventArgs e)
        {
            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();

            String query = "SELECT * FROM USUARIO WHERE CPF_USER = 123";
            MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                textBox4.Text = reader["CPF_USER"].ToString();
                textBox6.Text = reader["NOME_USER"].ToString();
                textBox3.Text = reader["TEL_USER"].ToString();
                textBox2.Text = reader["CEL_USER"].ToString();
                textBox1.Text = reader["EMAIL_USER"].ToString();
                textBox5.Text = reader["RG_USER"].ToString();
            }

            bd.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBaseConnection bd = new DataBaseConnection();
   //         private String nome = textBox6;

        
            bd.openConnection();
            
        }
    }
}
