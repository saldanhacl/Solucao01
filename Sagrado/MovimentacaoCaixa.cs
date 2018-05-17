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
            atualizaComboBox();
        }

        public void atualizaComboBox()
        {
            if(RB_FUNC.Checked == true)
            {
                String query;

                DataBaseConnection bd = new DataBaseConnection();
                query = "select * from usuario";
                bd.openConnection();

                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
                MySqlDataReader reader = cmd.ExecuteReader();

                String nome = null;
                String cpf = null;

                comboBox1.Items.Add("");

                while (reader.Read())
                {
                    nome = reader["NOME_USER"].ToString();
                    cpf = reader["CPF_USER"].ToString();
                    User user = new User(nome.ToUpper(), cpf);
                    comboBox1.Items.Add(user);

                }
                bd.closeConnection();
            }
            else
            {
                String query;

                DataBaseConnection bd = new DataBaseConnection();
                query = "SELECT DISTINCT TYPE_ENTRADA_CAIXA FROM caixa";
                bd.openConnection();

                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
                MySqlDataReader reader = cmd.ExecuteReader();

                String tipo = null;
               

                comboBox1.Items.Add("");

                while (reader.Read())
                {
                    tipo = reader["TYPE_ENTRADA_CAIXA"].ToString();
                    if(tipo == "v") comboBox1.Items.Add("VENDA");
                    else if (tipo == "f") comboBox1.Items.Add("FIADO");
                    else if (tipo == "r") comboBox1.Items.Add("RETIRADA");
                    else if (tipo == "e") comboBox1.Items.Add("ENTRADA");
                }
                bd.closeConnection();
            }



        }



        private void BTN_BUSCAR_Click(object sender, EventArgs e)
        {

            if(RB_FUNC.Checked == true)
            {
                String query = "";
                dg.Rows.Clear();
                if (comboBox1.SelectedItem == null || comboBox1.SelectedItem.ToString() == "")
                {
                    query = "SELECT * FROM caixa";
                }
                else
                {
                    User user = (User)comboBox1.SelectedItem;
                    if (user.cpf != null)
                    {
                        query = "SELECT * FROM CAIXA WHERE CPF_FUNCIONARIO = '" + user.cpf + "'";
                    }
                    else
                    {
                        MessageBox.Show("CPF inválido!");
                    }
                }

                DataBaseConnection bd = new DataBaseConnection();
                bd.openConnection();

                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
                MySqlDataReader reader = cmd.ExecuteReader();

                int i = 0;

                while (reader.Read())
                {
                    String tipo = "";
                    String leituraTipo = reader["TYPE_ENTRADA_CAIXA"].ToString();

                    if (leituraTipo == "v") tipo = "VENDA";
                    else if (leituraTipo == "r") tipo = "RETIRADA";
                    else if (leituraTipo == "f") tipo = "FIADO";
                    else if (leituraTipo == "e") tipo = "FUNDO DE CAIXA";

                    dg.Rows.Add();
                    dg.Rows[i].Cells["TIPO"].Value = tipo;
                    dg.Rows[i].Cells["VALOR"].Value = reader["VALOR_ENTRADA_CAIXA"].ToString();
                    dg.Rows[i].Cells["FUNCIONÁRIO"].Value = reader["CPF_FUNCIONARIO"].ToString();

                    i++;
                }

                bd.closeConnection();

            }
            else if(RB_TIPO.Checked == true){

                String query = "";
                dg.Rows.Clear();

                if (comboBox1.SelectedItem == null || comboBox1.SelectedItem.ToString() == "") query = "SELECT * FROM caixa";
                else if (comboBox1.SelectedItem.ToString() == "VENDA") query = "SELECT * FROM CAIXA WHERE TYPE_ENTRADA_CAIXA = 'v'";
                else if (comboBox1.SelectedItem.ToString() == "ENTRADA") query = "SELECT * FROM CAIXA WHERE TYPE_ENTRADA_CAIXA = 'e'";
                else if (comboBox1.SelectedItem.ToString() == "RETIRADA") query = "SELECT * FROM CAIXA WHERE TYPE_ENTRADA_CAIXA = 'r'";
                else if (comboBox1.SelectedItem.ToString() == "FIADO") query = "SELECT * FROM CAIXA WHERE TYPE_ENTRADA_CAIXA = 'f'";


                DataBaseConnection bd = new DataBaseConnection();
                bd.openConnection();

                MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
                MySqlDataReader reader = cmd.ExecuteReader();

                int i = 0;

                while (reader.Read())
                {
                    String tipo = "";
                    String leituraTipo = reader["TYPE_ENTRADA_CAIXA"].ToString();

                    if (leituraTipo == "v") tipo = "VENDA";
                    else if (leituraTipo == "r") tipo = "RETIRADA";
                    else if (leituraTipo == "f") tipo = "FIADO";
                    else if (leituraTipo == "e") tipo = "FUNDO DE CAIXA";

                    dg.Rows.Add();
                    dg.Rows[i].Cells["TIPO"].Value = tipo;
                    dg.Rows[i].Cells["VALOR"].Value = reader["VALOR_ENTRADA_CAIXA"].ToString();
                    dg.Rows[i].Cells["FUNCIONÁRIO"].Value = reader["CPF_FUNCIONARIO"].ToString();

                    i++;
                }


                bd.closeConnection();

            }
            else
            {
                MessageBox.Show("SELECIONE O TIPO DE PESQUISA");
            }





            
        }

        private void BTN_BUSCA_CPF_Click(object sender, EventArgs e)
        {
            
        }

        private void RB_FUNC_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            atualizaComboBox();
        }

        private void RB_TIPO_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            atualizaComboBox();

        }
    }
}
