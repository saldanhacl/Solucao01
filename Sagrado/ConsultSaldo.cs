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
    public partial class ConsultSaldo : Form
    {
        public ConsultSaldo()
        {
            InitializeComponent();
        }

        string theData;
        string marcado;
        private MySqlDataAdapter mySqlDataAdapter;

        private void BNT_SEARCH_Click(object sender, EventArgs e)
        {
            DataBaseConnection bd = new DataBaseConnection();

            bd.openConnection();

            string Query = "SELECT VALOR_ENTRADA_CAIXA AS ENTRADA, DATE_MODIFY_CAIXA AS DATA FROM CAIXA WHERE TYPE_ENTRADA_CAIXA ='" + this.checkMarcado() + "' AND DATE_MODIFY_CAIXA = '" + this.theData + "'";

            //Colocar dados na tabela src= 'http://solibnis.blogspot.com.br/2013/02/connecting-mysql-table-to-datagridview.html'

            if (marcado.Equals(""))//verfica se a radio box foi selecionada
            {
                MessageBox.Show("SELECIONE UM TIPO DE BUSCA");
            }
            else//coloca os dados na tabela
            {
                mySqlDataAdapter = new MySqlDataAdapter(Query, bd.retornaConexao());
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }

            bd.closeConnection();
        }

        private void BTN_DATE_ValueChanged(object sender, EventArgs e)
        {
            theData = BTN_DATE.Value.ToString("yyyy-MM-dd");
            if (theData.Equals(null))
            {
                MessageBox.Show("SELECIONE UMA DATA");
            }
        }

        private string checkMarcado()
        {
            //Retorna a letra de cada compra selecionada para a pesquisa no banco de dados
            if (radioButton1.Checked) marcado = "v";
            if (radioButton2.Checked) marcado = "f";
            if (radioButton3.Checked) marcado = "e";
            // Retorna vazio se nada for selecionado
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                marcado = "";
            }

            return marcado;
        }





    }
}
