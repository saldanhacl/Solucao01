using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Sagrado
{
    partial class AdicionarProdutosComanda : Form
    {

        Double total = 0;
        Form regEntrada;

        public AdicionarProdutosComanda(Form regEntradaForm)
        {
            InitializeComponent();
            regEntrada = regEntradaForm;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

            DataBaseConnection bd = new DataBaseConnection();
            bd.openConnection();

            String query = "SELECT * FROM produto";
            MySqlCommand cmd = new MySqlCommand(query, bd.retornaConexao());

            MySqlDataReader reader = cmd.ExecuteReader();

            String nome = null;
            Double preco = 0;
            long idProduto;

            while (reader.Read())
            {
                preco = Double.Parse(reader["PRECO_PRODUTO"].ToString());
                nome = reader["NOME_PRODUTO"].ToString();
                idProduto = long.Parse(reader["NRSEQPRODUTO"].ToString());

                Produto produto = new Produto(idProduto, nome, preco);

                PRODUTOS.Items.Add(produto);
            }
            bd.closeConnection();
        }

        public List<Produto> getListaProdutosComanda()
        {
            List<Produto> produtosComanda = new List<Produto>();
            int qtdProdutos = LISTA.Items.Count;

            for(int i=0; i < qtdProdutos; i++)
            {
                if (!produtosComanda.Contains((Produto)LISTA.Items[i]))
                {
                    produtosComanda.Add((Produto)LISTA.Items[i]);
                } 
            }

            return produtosComanda;

        }


     
        private void btn_fechar_comanda_Click(object sender, EventArgs e)
        {
            ((RegEntrada)regEntrada).setBoxPriceText(total.ToString());
            ((RegEntrada)regEntrada).setListaProdutos( this.getListaProdutosComanda() );
            this.Close();
        }

        private void btn_zerar_comanda_Click(object sender, EventArgs e)
        {
            LISTA.Items.Clear();
            txt_total.Text = "0";
        }

        private void Lista_Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lista_Produtos_DoubleClick(object sender, EventArgs e)
        {
            if (PRODUTOS.SelectedItem != null)
            {
                LISTA.Items.Add(PRODUTOS.SelectedItem);
                total += ((Produto)PRODUTOS.SelectedItem).preco;
                ((Produto)PRODUTOS.SelectedItem).quantidade++;
                txt_total.Text = total.ToString();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

