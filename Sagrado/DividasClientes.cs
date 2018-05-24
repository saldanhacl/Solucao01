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
    public partial class DividasClientes : Form
    {
        public DividasClientes()
        {
            InitializeComponent();
        }

        private void DividasClientes_Load(object sender, EventArgs e)
        {
            atualizarSaldoCaixa();
            atualizarSaldoDividas();

            DataBaseConnection bd = new DataBaseConnection();
            
            try
            {

                bd.openConnection();
                String query = "SELECT * FROM CLIENTE";

                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
                MySqlDataReader reader = cmd.ExecuteReader();

                int i = 0;

                while (reader.Read())
                {

                    gridDividaClientes.Rows.Add();
                    gridDividaClientes.Rows[i].Cells["CLIENTE"].Value = reader["NOME_CLIENTE"].ToString().ToUpper();
                    gridDividaClientes.Rows[i].Cells["VALOR"].Value = reader["SALDO_ATUAL_CLIENTE"].ToString();

                    i++;
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("ERRO DE CONEXÃO COM O BANCO");
            }

            bd.closeConnection();

        }

        private void atualizarSaldoCaixa()
        {

            DataBaseConnection bd = new DataBaseConnection();

            try
            {

                bd.openConnection();
                String query = "SELECT VALOR_ATUAL_CAIXA AS TOTAL_CAIXA FROM CAIXA WHERE NRSEQABERTURA = (SELECT MAX(NRSEQABERTURA) FROM CAIXA);";

                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TXT_TOTAL_CAIXA.Text = reader["TOTAL_CAIXA"].ToString();
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("ERRO DE CONEXÃO COM O BANCO");
            }

            bd.closeConnection();

        }

        private void atualizarSaldoDividas()
        {

            DataBaseConnection bd = new DataBaseConnection();

            try
            {

                bd.openConnection();
                String query = "SELECT SUM(SALDO_ATUAL_CLIENTE) AS TOTAL_DIVIDA FROM cliente";

                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TXT_TOTAL_DIVIDA.Text = reader["TOTAL_DIVIDA"].ToString();
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("ERRO DE CONEXÃO COM O BANCO");
            }

            bd.closeConnection();

        }

        private void TXT_TOTAL_CAIXA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_TOTAL_DIVIDA_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

