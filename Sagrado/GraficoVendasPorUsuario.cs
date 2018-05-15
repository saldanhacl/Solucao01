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
            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();

            chart1.DataSource = EnviarDados("SELECT VALOR_ENTRADA_CAIXA, CPF_FUNCIONARIO, Count(TYPE_ENTRADA_CAIXA) As NumeroVenda From caixa where TYPE_ENTRADA_CAIXA = 'v' or TYPE_ENTRADA_CAIXA = 'f' group by CPF_FUNCIONARIO");
            string Query = "SELECT VALOR_ENTRADA_CAIXA, CPF_FUNCIONARIO, Count(TYPE_ENTRADA_CAIXA) As NumeroVenda From caixa where TYPE_ENTRADA_CAIXA = 'v' or TYPE_ENTRADA_CAIXA = 'f' group by CPF_FUNCIONARIO";
           /* MySqlCommand cmd = new MySqlCommand(Query, bd.retornaConexao());
            MySqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("Erro no banco de dados.");
            }
            else
            {
                while (reader.Read())
                {
                    chart1.Series["Series1"].Label = reader["NumeroVenda"].ToString();
                }
            }
                bd.closeConnection();
                DataBaseConnection bd2 = new DataBaseConnection();
            bd2.openConnection();
            string Query2 = "SELECT NOME_USER from usuario where 'CPF_USER = '" + chart1.Series["Series1"].Label + "'";
            MySqlCommand cmd2 = new MySqlCommand(Query2, bd2.retornaConexao());
            MySqlDataReader reader2 = cmd2.ExecuteReader();

            if (!reader2.HasRows)
            {
                MessageBox.Show("Erro no banco de dados.");
            }
            else
            {
                while (reader2.Read())
                {
                    chart1.Series["Series1"].LegendText = reader2["NOME_USER"].ToString();
                }
            }
            bd2.closeConnection();*/

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }
    }


}
