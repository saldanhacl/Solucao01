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
    public partial class ConsultarProd : Form

    {
        

        public ConsultarProd()
        {
            InitializeComponent();
            this.atualizarListaTipos();
        }

        private void BTN_BUSCAR_Click(object sender, EventArgs e)
        {
            String query = "";
            dg.Rows.Clear();

            if (LISTA_TIPOS.SelectedItem == null || LISTA_TIPOS.SelectedItem == "" ) query = "SELECT * FROM PRODUTO";
            else query = "SELECT * FROM PRODUTO WHERE TYPE_PRODUTO = '" + LISTA_TIPOS.SelectedItem.ToString() + "'";

            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();

            MessageBox.Show(query);

            MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());

            MySqlDataReader reader = cmd.ExecuteReader();

            int i = 0;


            while (reader.Read())
            {
                dg.Rows.Add();
                dg.Rows[i].Cells["TIPO"].Value = reader["TYPE_PRODUTO"].ToString();
                dg.Rows[i].Cells["NOME"].Value = reader["NOME_PRODUTO"].ToString();
                dg.Rows[i].Cells["QUANTIDADE"].Value = reader["QTD_PRODUTO"].ToString();
                dg.Rows[i].Cells["PREÇO"].Value = reader["PRECO_PRODUTO"].ToString();

                i++; ;
            }

            bd.closeConnection();

        }
      
        private void BTN_CANC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void atualizarListaTipos()
        {
            LISTA_TIPOS.Items.Clear();

            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();

            String query = "SELECT DISTINCT TYPE_PRODUTO FROM produto";

            MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());

            MySqlDataReader reader = cmd.ExecuteReader();

            String nome = null;
            LISTA_TIPOS.Items.Add("");

            while (reader.Read())
            {
                nome = reader["TYPE_PRODUTO"].ToString();
                LISTA_TIPOS.Items.Add(nome);
            }
            bd.closeConnection();
        }


    }
}
