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
    public partial class AdicionarProdutosComanda : Form
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

            while (reader.Read())
            {
                preco = Double.Parse(reader["PRECO_PRODUTO"].ToString());
                nome = reader["NOME_PRODUTO"].ToString();

                Produto produto = new Produto(nome, preco);

                Lista_Produtos.Items.Add(produto);
            }
            bd.closeConnection();
        }

        private void btn_adicionar_produtos_Click(object sender, EventArgs e)
        {
            total = 0;
            Lista_Comanda.Items.Clear();

            foreach (Produto produto in Lista_Produtos.CheckedItems)
            {
                if (!Lista_Comanda.Items.Contains(produto))
                {
                    total += produto.preco;
                    Lista_Comanda.Items.Add(produto);
                }

            }

            txt_total.Text = "R$ " + total.ToString();
        }

        private void btn_fechar_comanda_Click(object sender, EventArgs e)
        {
            ((RegEntrada)regEntrada).setBoxPriceText(total.ToString()); 
            this.Close();
        }

        private void btn_zerar_comanda_Click(object sender, EventArgs e)
        {
            Lista_Comanda.Items.Clear();
            zerarComanda();
        }


        public void zerarComanda()
        {
            foreach(int i in Lista_Produtos.CheckedIndices)
            {
                Lista_Produtos.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
    }
}

