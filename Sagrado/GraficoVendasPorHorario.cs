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
    public partial class GraficoVendasPorHorario : Form
    {
        MySqlConnection conectar;
        public GraficoVendasPorHorario()
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
        private void GraficoVendasPorHorario_Load(object sender, EventArgs e)
        {
            Conectar();
            chart1.Series.Clear();
            chart1.Series.Add("Series1");

            chart1.Series["Series1"].XValueMember = "HOUR(DATE_MODIFY_CAIXA)";
            chart1.Series["Series1"].YValueMembers = "NumeroVenda";
            chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();
            //chart1.Series["Series1"].LegendText = "SELECT CONCAT(HOUR(DATE_TIME_MODIFY), ' to ', CONCAT(HOUR(DATE_TIME_MODIFY), ':59:59')) as time_frame from caixa group by HOUR(DATE_MODIFY_CAIXA)";
            chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
            chart1.DataSource = EnviarDados("SELECT VALOR_ENTRADA_CAIXA, HOUR(DATE_MODIFY_CAIXA), Count(TYPE_ENTRADA_CAIXA) As NumeroVenda From caixa where TYPE_ENTRADA_CAIXA = 'v' or TYPE_ENTRADA_CAIXA = 'f' group by HOUR(DATE_MODIFY_CAIXA)");
            string Query = "SELECT VALOR_ENTRADA_CAIXA, CPF_FUNCIONARIO, Count(TYPE_ENTRADA_CAIXA) As NumeroVenda From caixa where TYPE_ENTRADA_CAIXA = 'v' or TYPE_ENTRADA_CAIXA = 'f' group by CPF_FUNCIONARIO";
            MySqlCommand cmd = new MySqlCommand(Query, bd.retornaConexao());
        }
    }
}
