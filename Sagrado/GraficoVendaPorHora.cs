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
            chart1.Series["Series1"].LegendText = "Willer";
            chart1.Series["Series1"].XValueMember = "CPF_FUNCIONARIO";
            chart1.Series["Series1"].YValueMembers = "VALOR_ENTRADA_CAIXA";
            //chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
            chart1.DataSource = EnviarDados("select CPF_FUNCIONARIO, VALOR_ENTRADA_CAIXA from caixa where TYPE_ENTRADA_CAIXA = 'v' or TYPE_ENTRADA_CAIXA = 'f'");
           // chart1.DataSource = EnviarDados("select CPF_USER from usuario");
            //chart1.Series["Series1"].Points.Add(1);
            //chart1.Series["Series1"].Points.Add(50);
            // chart1.Series["Series1"].Points.Add(30);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
