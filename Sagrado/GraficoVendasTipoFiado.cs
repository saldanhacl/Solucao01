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

            chart1.Series["Series1"].XValueMember = "Total_Por_Tipo";
            chart1.Series["Series1"].YValueMembers = "Total_Tabela";
            chart1.Series["Series1"].ChartType = SeriesChartType.Pie;

            chart1.DataSource = EnviarDados("SELECT (SELECT count(vt.NRSEQVENDA) FROM venda vt where TIPO_VENDA = 'f') as Total_Por_Tipo, (SELECT count(vt.NRSEQVENDA) FROM venda vt) as Total_Tabela FROM venda v GROUP BY v.TIPO_VENDA; ");
          
        }
    }

}

    
