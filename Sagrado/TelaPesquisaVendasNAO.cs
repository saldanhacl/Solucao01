using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sagrado;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TelaPesquisaVendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        string theData;
        string marcado;
        private MySqlDataAdapter mySqlDataAdapter;


        private void botaoPesquisa(object sender, EventArgs e)
        {
            DataBaseConnection bd = new DataBaseConnection();

            bd.openConnection();

           string Query = "SELECT VALOR_ENTRADA_CAIXA AS ENTRADA, DATE_MODIFY_CAIXA AS DATA FROM CAIXA WHERE TYPE_ENTRADA_CAIXA ='" + this.checkMarcado() + "' AND DATE_MODIFY_CAIXA = '" + this.theData + "'";

            //Colocar dados na tabela src= 'http://solibnis.blogspot.com.br/2013/02/connecting-mysql-table-to-datagridview.html'

            if (marcado.Equals(""))//verfica se a radio box foi selecionada
            {
                MessageBox.Show("Por favor selecione um item!");
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


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            theData = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            if (theData.Equals(null))
            {
                MessageBox.Show("Por favor selecione uma data!");
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
