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

        List<int> linhaAlter = new List<int>();
        
        private void BTN_BUSCAR_Click(object sender, EventArgs e)
        {
            
            String query = "";
            dg.Rows.Clear();

            if (LISTA_TIPOS.SelectedItem == null || LISTA_TIPOS.SelectedItem.Equals(""))
                query = "SELECT * FROM PRODUTO";
            else
                query = "SELECT * FROM PRODUTO WHERE TYPE_PRODUTO = '" + LISTA_TIPOS.SelectedItem.ToString() + "'";

            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();

            MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());

            MySqlDataReader reader = cmd.ExecuteReader();

            int i = 0;


            while (reader.Read())
            {
                dg.Rows.Add();
                dg.Rows[i].Cells["TIPO"].Value = reader["TYPE_PRODUTO"].ToString();
                dg.Rows[i].Cells["NOME"].Value = reader["NOME_PRODUTO"].ToString();
                //dg.Rows[i].Cells["QUANTIDADE"].Value = reader["QTD_PRODUTO"].ToString();
                dg.Rows[i].Cells["PREÇO"].Value = reader["PRECO_PRODUTO"].ToString();
                dg.Rows[i].Cells["N"].Value = reader["NRSEQPRODUTO"].ToString();

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

       
        private void dg_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int linha = e.RowIndex;

            if (!(linhaAlter.Contains(linha))) linhaAlter.Add(linha);
            //MessageBox.Show(linhaAlter.Count.ToString());
        }

        private void BTN_CONF_Click(object sender, EventArgs e)
        {
            if(dg.CurrentRow != null)
            {
                int linha = int.Parse(dg.CurrentRow.Index.ToString());
                MessageBox.Show(linha.ToString());

                int id = int.Parse(dg.Rows[linha].Cells["N"].Value.ToString());

                String tipo = dg.Rows[linha].Cells["TIPO"].Value.ToString();
                String nome = dg.Rows[linha].Cells["NOME"].Value.ToString();
                String preco = dg.Rows[linha].Cells["PREÇO"].Value.ToString();

                new AlterarProd(preco, nome, tipo, id).ShowDialog();

            }
            else
            {
                MessageBox.Show("SELECIONE UMA LINHA PARA ALTERAR");
            }


        }

        private void EXCLUIR_Click(object sender, EventArgs e)
        {
            int linha = int.Parse(dg.CurrentRow.Index.ToString());
            int id = int.Parse(dg.Rows[linha].Cells["N"].Value.ToString());

            DialogResult dr = MessageBox.Show("DESEJA EXCLUIR A LINHA SELECIONADA?",
                            "CONFIRMAÇÃO:", MessageBoxButtons.YesNo);
        
            switch (dr)
            {
                case DialogResult.Yes:

                    if (linha >= 0)
                    {
                        DataBaseConnection bd = new DataBaseConnection();
                        bd.openConnection();

                        String query = "DELETE FROM PRODUTO WHERE NRSEQPRODUTO ='" + id.ToString() + "'";
                        MessageBox.Show(query);

                        MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("PRODUTO EXCLUÍDO COM SUCESSO");
                        bd.closeConnection();
                        atualizarListaTipos();
                        dg.Rows.RemoveAt(linha);
                    }
                    break;

                case DialogResult.No:
                    MessageBox.Show("EXCLUSÃO CANCELADA");
                    break;

            }


            
           
        }
    }
}
