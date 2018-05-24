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
    public partial class GraficoVendasPorUsuario : Form
    {
        MySqlConnection conectar;
        public GraficoVendasPorUsuario()
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

        private void GraficoVenda_Por_Hora_Load(object sender, EventArgs e)
        {
            Conectar();
            chart1.Series.Clear();
            chart1.Series.Add("Series1");

            chart1.Series["Series1"].XValueMember = "CPF_FUNCIONARIO";
            chart1.Series["Series1"].YValueMembers = "NumeroVenda";
            chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
            chart1.Series["Series1"].XValueMember = "NomeProduto";
            chart1.Series["Series1"].Label = "#VALY";
            chart1.Series["Series1"].LegendText = "#VALX";
            //chart1.Series["Series1"].Is
            //DataBaseConnection bd = new DataBaseConnection();
            // bd.openConnection

            chart1.DataSource = EnviarDados("SELECT QUANTIDADE, QP.NRSEQPRODUTO, Count(QUANTIDADE) As NumeroVenda, P.NOME_PRODUTO as NomeProduto From quantidade_produto QP INNER JOIN produto P ON P.NRSEQPRODUTO= QP.NRSEQPRODUTO group by P.NOME_PRODUTO");

            chart1.DataSource = EnviarDados("SELECT VALOR_ENTRADA_CAIXA, CPF_FUNCIONARIO, Count(TYPE_ENTRADA_CAIXA) As NumeroVenda, U.NOME_USER as NomeFunc From caixa CU INNER JOIN usuario U ON U.CPF_USER= CU.CPF_FUNCIONARIO where TYPE_ENTRADA_CAIXA = 'v' or TYPE_ENTRADA_CAIXA = 'f' group by U.NOME_USER");
          


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
    }


}
