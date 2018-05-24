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
using System.Windows.Forms.DataVisualization.Charting;

namespace Sagrado
{
    public partial class GraficoVendasTipoFiado : Form
    {
        MySqlConnection conectar;
        public GraficoVendasTipoFiado()
        {
            InitializeComponent();
        }
        public void Conectar()
        {
            try
            {
                conectar = new MySqlConnection("server=localhost; database=bdsagrado; Uid=root; pwd=sa2gr0ad1o8; SslMode=none;");
                conectar.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        public DataTable EnviarDados(string consulta)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter mda = new MySqlDataAdapter(consulta, conectar);
            mda.Fill(table);
            return table;


        }


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void BTN_CANC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GraficoVendasTipoFiado_Load_1(object sender, EventArgs e)
        {
            Conectar();
            chart1.Series.Clear();
            chart1.Series.Add("Series1");

            long[] total = { getTotalVendasFiado(), getTotalVendas() };

            string[] strTotal = { "Total Fiado" , "Total Vendas" };


            chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
            chart1.Series["Series1"].Points.DataBindXY(strTotal, total);
            chart1.Series["Series1"].LegendText = "#VALX";
            chart1.Series["Series1"].Label = "#VALY";



        }

        private void chart1_Click_2(object sender, EventArgs e)
        {

        }

        private long getTotalVendasFiado()
        {
            long totalFiado = 0;
            DataBaseConnection bd = new DataBaseConnection();
            try
            {
                bd.openConnection();

                String query = "SELECT COUNT(NRSEQVENDA) AS TOTAL_FIADO FROM VENDA WHERE TYPE_VENDA = 'f'";

                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());

                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    totalFiado = long.Parse(reader["TOTAL_FIADO"].ToString());
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("ERRO NO BANCO DE DADOS");
            }


            bd.closeConnection();
            return totalFiado;

        }

        private long getTotalVendas()
        {
            long totalVendas = 0;
            DataBaseConnection bd = new DataBaseConnection();
            try
            {
                bd.openConnection();

                String query = "SELECT COUNT(NRSEQVENDA) AS TOTAL_VENDAS FROM VENDA;";

                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());

                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    totalVendas = long.Parse(reader["TOTAL_VENDAS"].ToString());
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("ERRO NO BANCO DE DADOS");
            }


            bd.closeConnection();
            return totalVendas;

        }
    }

}

    
