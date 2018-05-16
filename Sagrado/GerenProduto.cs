using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sagrado
{
    public partial class GerenProduto : Form
    {
        public GerenProduto()
        {
            InitializeComponent();
        }

        private void pAINELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tROCARUSUÁRIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void eNCERRARSISTEMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_ADD_PRODUTO_Click(object sender, EventArgs e)
        {
            new CadastrarProd().Show();
        }

        

        private void BTN_EXCLUIR_PRODUTO_Click(object sender, EventArgs e)
        {
            new ExcluirProd().ShowDialog();
        }

        private void BTN_CONSUL_PRODUTO_Click(object sender, EventArgs e)
        {
            new ConsultarProd().ShowDialog();
        }

       
    }
}
