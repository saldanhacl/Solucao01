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
    public partial class GraficoVenda_Por_Hora : Form
    {
        MySqlConnection conectar;
        public GraficoVenda_Por_Hora()
        {
            InitializeComponent();


        }
        
        public void Conectar()
        {
            try
            {
                conectar = new MySqlConnection();
                conectar.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void GraficoVenda_Por_Hora_Load(object sender, EventArgs e)
        {
            
        }
    }
}
