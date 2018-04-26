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

        private void BTN_DATE_ValueChanged(object sender, EventArgs e)
        {
            theData = BTN_DATE.Value.ToString("yyyy-MM-dd");
            if (theData.Equals(null))
            {
                MessageBox.Show("SELECIONE UMA DATA");
            }
        }

        private void BNT_SEARCH_Click(object sender, EventArgs e)
        {
            this.checkMarcado();
            if (marcado.Equals(""))//verfica se a radio box foi selecionada
            {
                MessageBox.Show("SELECIONE UM TIPO DE BUSCA");
            }
            else
            {
                DataBaseConnection bd = new DataBaseConnection();
                bd.openConnection();
                string Query = "SELECT VALOR_ENTRADA_CAIXA AS ENTRADA, DATE_MODIFY_CAIXA AS DATA FROM CAIXA WHERE TYPE_ENTRADA_CAIXA ='" + this.checkMarcado() + "' AND DATE_MODIFY_CAIXA = '" + this.theData + "'";
                MySqlCommand cmd = new MySqlCommand(Query, bd.retornaConexao());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBox2.Text = reader["VALOR_ENTRADA_CAIXA"].ToString();
                }
                bd.closeConnection();
            }
        }

        //FALTA UM CAMPO CPF NA TABELA DE CAIXA!
        //Buscar por CPF
        private void botaoBuscar(object sender, EventArgs e)
        {
            cpf = textBox1.Text;
            if (cpf.Equals(""))//verfica se a o campo do nome não está
            {
                MessageBox.Show("Campo vazio!Por favor digite um CPF!");
            }
            else { 
                DataBaseConnection bd = new DataBaseConnection();
                bd.openConnection();
                //Query não pega nada pois não há campo de CPF no caixa
                string Query1 = "SELECT VALOR_ENTRADA_CAIXA FROM CAIXA WHERE CPF_FUNCIONARIO = '" + this.cpf + "'";
                MySqlCommand cmd = new MySqlCommand(Query1, bd.retornaConexao());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBox2.Text = reader["VALOR_ENTRADA_CAIXA"].ToString();
                }
                reader.Close();
                
                  

                bd.closeConnection();
            }
        }

    }
}
