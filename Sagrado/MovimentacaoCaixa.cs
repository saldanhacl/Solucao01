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
                

        private void BTN_BUSCAR_Click(object sender, EventArgs e)
        {
            String query = "";

            //if (comboBox1.SelectedIndex.ToString().Length == 0) query = "SELECT * FROM CAIXA";
            //else if (comboBox1.SelectedIndex.ToString() == "VENDA") = "SELECT * FROM CAIXA where TYPE_ENTRADA_CAIXA = 'v'";

            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();

            query = "SELECT * FROM CAIXA";

            MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());

            MySqlDataReader reader = cmd.ExecuteReader();

            int i = 0;

            while (reader.Read())
            {

                dg.Rows.Add();
                dg.Rows[i].Cells["TIPO"].Value = reader["TYPE_ENTRADA_CAIXA"].ToString();
                dg.Rows[i].Cells["VALOR"].Value = reader["VALOR_ENTRADA_CAIXA"].ToString();
                dg.Rows[i].Cells["FUNCIONÁRIO"].Value = reader["CPF_FUNCIONARIO"].ToString();

                i++; ;
            }


            bd.closeConnection();


        }

        private void MovimentacaoCaixa_Load(object sender, EventArgs e)
        {

        }
    }
}
