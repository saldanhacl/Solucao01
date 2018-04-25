using System;
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
        }
        string cpf;
        private void botaoConsultar(object sender, EventArgs e)
        {
            cpf = textBox1.Text;
            if (cpf.Equals(""))
            {
                MessageBox.Show("Campo de CPF vazio!");
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
                    textBox6.Text = reader["SALDO_ATUAL_CLIENTE"].ToString();
                    textBox7.Text = reader["CEL_CLIENTE"].ToString();
                }
                bd.closeConnection();
            }
        }
    }
}
