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
    public partial class MenuAdm : Form
    {
        public MenuAdm()
        {
            InitializeComponent();
            this.CenterToScreen();
            //btnComanda.Select();
        }

        private void MenuAdm_Load(object sender, EventArgs e)
        {

        }


        private void tROCARUSUÁRIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void eNCERRARSISTEMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_GERENCIAR_CLIENTE_Click(object sender, EventArgs e)
        {

        }

        private void pAINELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void BTN_REGISTRAR_ENTRADA_Click(object sender, EventArgs e)
        {
            new RegEntrada().Show();
        }

        private void BTN_GERENCIAR_USER_Click(object sender, EventArgs e)
        {
            new GerenUser().Show();
            this.Close();
        }

        private void BTN_RETIRAR_DINHEIRO_Click(object sender, EventArgs e)
        {
            new RegRetirada().Show();
        }

        private void BTN_CONSULTA_MOVI_Click(object sender, EventArgs e)
        {
            new ConsultSaldo().Show();
        }
    }
}
