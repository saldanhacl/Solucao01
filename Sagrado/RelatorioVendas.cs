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
    public partial class RelatorioVendas : Form
    {
        public RelatorioVendas()
        {
            InitializeComponent();
        }

        private void BTN_VENDA_USER_Click(object sender, EventArgs e)
        {
            new GraficoVendaPorHora().Show();
            this.Close();
        }
    }
}
