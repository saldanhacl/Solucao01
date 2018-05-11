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

            if (LISTA_TIPOS.SelectedItem == null || LISTA_TIPOS.SelectedItem == "" ) query = "SELECT * FROM PRODUTO";
            else query = "SELECT * FROM PRODUTO WHERE TYPE_PRODUTO = '" + LISTA_TIPOS.SelectedItem.ToString() + "'";

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
                dg.Rows[i].Cells["QUANTIDADE"].Value = reader["QTD_PRODUTO"].ToString();
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
            MessageBox.Show(linhaAlter.Count.ToString());
        }

        private void BTN_CONF_Click(object sender, EventArgs e)
        {


            if (linhaAlter.Count <= 0) MessageBox.Show("NÃO EXISTEM ALTERAÇÕES PARA SEREM SALVAS");
            else
            {
                DialogResult dr = MessageBox.Show("DESEJA SALVAR OS DADOS ALTERADOS?",
                            "CONFIRMAÇÃO:", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:

                        DataBaseConnection bd = new DataBaseConnection();
                        bd.openConnection();


                        while (linhaAlter.Count > 0)
                        {
                            int linhaTabela = linhaAlter.ElementAt(0);

                            String tipoRecebido = dg.Rows[linhaTabela].Cells["TIPO"].Value.ToString().ToUpper();
                            String nomeRecebido = dg.Rows[linhaTabela].Cells["NOME"].Value.ToString().ToUpper();

                            float precoRecebido = float.Parse(dg.Rows[linhaTabela].Cells["PREÇO"].Value.ToString());

                            int qtdRecebido = int.Parse(dg.Rows[linhaTabela].Cells["QUANTIDADE"].Value.ToString());
                            int id = int.Parse(dg.Rows[linhaTabela].Cells["N"].Value.ToString());

                            String query = "UPDATE PRODUTO SET " +
                            "TYPE_PRODUTO = '" + tipoRecebido +
                            "', NOME_PRODUTO = '" + nomeRecebido +
                            "', PRECO_PRODUTO = " + precoRecebido +
                            ", QTD_PRODUTO = " + qtdRecebido +
                            " WHERE NRSEQPRODUTO = " + id;

                            MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());

                            cmd.ExecuteNonQuery();

                            linhaAlter.RemoveAt(0);

                        }
                        bd.closeConnection();

                        MessageBox.Show("PRODUTO ALTERADO COM SUCESSO");
                        this.atualizarListaTipos();
                        
                        


                        break;
                    case DialogResult.No:
                        MessageBox.Show("EXCLUSÃO CANCELADA");
                        break;
                }
            }
            


            
        }



    }
}
