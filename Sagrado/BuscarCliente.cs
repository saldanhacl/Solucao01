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

namespace TelaBuscaCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        //TODO - ter uma table de clientes pra buscar
        private MySqlDataAdapter mySqlDataAdapter;
        string cpf;
        string seq;
        private void button1_Click(object sender, EventArgs e)
        {
            cpf = textBox1.Text;
            DataBaseConnection bd = new DataBaseConnection();

            bd.openConnection();

            //Pega o cpf do usuário e o associa a um numero sequencial(NRSEQ_USER) do bd
            string Query1 = "SELECT NRSEQ_USER FROM USUARIO WHERE CPF_USER = '" + this.cpf + "'";
            MySqlCommand cmd = new MySqlCommand(Query1, bd.retornaConexao());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                seq = reader["NRSEQ_USER"].ToString();//armazenar o número sequencial em uma variavel
            }
            reader.Close();
            //Montar a query com o numero sequencial que pega os dados do cliente
            //!!!-estou usando o bd com usuário
            string Query2 = " SELECT CPF_USER,NOME_USER, TEL_USER, CEL_USER, EMAIL_USER, NIVEL_USER, DTNASCIMENTO_USER, SEXO_USER, RG_USER, SENHA_USER from USUARIO WHERE NRSEQ_USER = '" + this.seq + "'";
          
            //Realizar a busca dos dados no banco de dados
            if (cpf.Equals(""))//verifica se o campo está vazio
            {
                MessageBox.Show("Campo Vazio!Por favor digite um nome!");
            }
            else//procura no banco de dados pessoas com o nome digitado
            {
                mySqlDataAdapter = new MySqlDataAdapter(Query2, bd.retornaConexao());
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
            bd.closeConnection();
        }
    }
}
