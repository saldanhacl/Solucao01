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
    public partial class MovimentacaoCaixa : Form
    {
        public MovimentacaoCaixa()
        {
            InitializeComponent();
        }

        string theData;
        string marcado;
        string cpf;
        string seq;
        private MySqlDataAdapter mySqlDataAdapter;
        private MySqlDataAdapter mySqlDataAdapter2;
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

        //Buscar por CPF
        private void botaoBuscar(object sender, EventArgs e)
        {          
                cpf = textBox1.Text;

                DataBaseConnection bd = new DataBaseConnection();
                bd.openConnection();

                string Query1 = "SELECT NRSEQ_USER FROM USUARIO WHERE CPF_USER = '" + this.cpf + "'";
                MySqlCommand cmd = new MySqlCommand(Query1, bd.retornaConexao());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    seq = reader["NRSEQ_USER"].ToString();
                }
                reader.Close();
                string Query2 = "SELECT CPF_USER,NOME_USER, TEL_USER, CEL_USER, EMAIL_USER, NIVEL_USER, DTNASCIMENTO_USER, SEXO_USER, RG_USER, SENHA_USER from USUARIO WHERE NRSEQ_USER = '" + this.seq + "'";

                if (cpf.Equals(""))//verfica se a o campo do nome não está
                {
                    MessageBox.Show("Campo vazio!Por favor digite um CPF!");
                }
                else//coloca os dados na tabela
                {
                    mySqlDataAdapter2 = new MySqlDataAdapter(Query2, bd.retornaConexao());
                    DataSet DS = new DataSet();
                    mySqlDataAdapter2.Fill(DS);
                    dataGridView1.DataSource = DS.Tables[0];
                }
                bd.closeConnection();
            
        }
    }
}
