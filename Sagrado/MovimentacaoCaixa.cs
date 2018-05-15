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
       
        private void BTN_BUSCAR_Click(object sender, EventArgs e)
        {

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

                i++; ;
            }


            bd.closeConnection();
        }

        private void BTN_CANC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
