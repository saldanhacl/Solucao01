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
    public partial class GerenClienteAdm : Form
    {
        public GerenClienteAdm()
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

        private void BTN_ADD_CLIENTE_Click(object sender, EventArgs e)
        {
            new CadastrarCliente().Show();
        }

        private void BTN_EDIT_CLIENTE_Click(object sender, EventArgs e)
        {
            new AlterarCliente().Show();
        }

        private void BTN_EXCLUIR_CLIENTE_Click(object sender, EventArgs e)
        {
            new ExcluirCliente().Show();
        }
        
        private void BTN_CONSUL_CLIENTE_Click(object sender, EventArgs e)
        {
            new ConsultarCliente().Show();
        }

       
    }
}
