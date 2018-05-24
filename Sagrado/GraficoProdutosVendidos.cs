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
    public partial class GraficoProdutosVendidos : Form
    {
        MySqlConnection conectar;
        public GraficoProdutosVendidos()
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
        private void GraficoProdutosVendidos_Load(object sender, EventArgs e)
        {
            Conectar();
            chart1.Series.Clear();
            chart1.Series.Add("Series1");


            chart1.Series["Series1"].XValueMember ="NomeProduto";
            chart1.Series["Series1"].YValueMembers = "NumeroVenda";
            chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
            chart1.Series["Series1"].Label= "#VALY";
            chart1.Series["Series1"].LegendText = "#VALX";
            //chart1.Series["Series1"].Is
            //DataBaseConnection bd = new DataBaseConnection();
            // bd.openConnection

            chart1.DataSource = EnviarDados("SELECT QUANTIDADE, QP.NRSEQPRODUTO, Count(QUANTIDADE) As NumeroVenda, P.NOME_PRODUTO as NomeProduto From quantidade_produto QP INNER JOIN produto P ON P.NRSEQPRODUTO= QP.NRSEQPRODUTO group by P.NOME_PRODUTO");
           // string Query = "SELECT VALOR_ENTRADA_CAIXA, CPF_FUNCIONARIO, Count(TYPE_ENTRADA_CAIXA) As NumeroVenda From caixa where TYPE_ENTRADA_CAIXA = 'v' or TYPE_ENTRADA_CAIXA = 'f' group by CPF_FUNCIONARIO";
          //  MySqlCommand cmd = new MySqlCommand(Query, bd.retornaConexao());

        }

        private void BTN_CANC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
