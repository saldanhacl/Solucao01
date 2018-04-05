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
    public partial class GerenUser : Form
    {
        public GerenUser()
        {
            InitializeComponent();
        }

        private void pAINELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MenuAdm().Show();
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

        private void BTN_ADD_USER_Click(object sender, EventArgs e)
        {
            new CadastrarFunc().Show();
        }

        private void BTN_EDIT_USER_Click(object sender, EventArgs e)
        {
            //essa função está com erro do UPDATE
            new AlterarFunc().Show();
        }

        private void BTN_EXCLUIR_USER_Click(object sender, EventArgs e)
        {
            //FAZER
            new ExcluirUser().Show();
        }

        private void BTN_CONSUL_USER_Click(object sender, EventArgs e)
        {
            new ConsultarUser().Show();
        }
    }
}
