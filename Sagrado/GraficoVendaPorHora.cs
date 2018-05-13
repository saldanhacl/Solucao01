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
    public partial class GraficoVendaPorHora : Form
    {
        MySqlConnection conectar;
        public GraficoVendaPorHora()
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

        public DataTable EnviarDados(string consulta) {
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

        private void GraficoVenda_Por_Hora_Load(object sender, EventArgs e)
        {
            Conectar();
            chart1.Series["Series1"].LegendText = "Grafico De Willer";
            chart1.Series["Series1"].XValueMember = "NOME_USER";
            chart1.Series["Series1"].YValueMembers = "RG_USER";
            chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
            chart1.DataSource = EnviarDados("select NOME_USER, RG_USER from usuario");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
