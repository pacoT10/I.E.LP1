using I.E.LP1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I.E.LP1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmdCarga_Click(object sender, EventArgs e)
        {
            frmCargaProducto frmCarga = new frmCargaProducto();
            frmCarga.Show();
        }

        private void cmdVentas_Click(object sender, EventArgs e)
        {
            frmCargaVentas frmVentas = new frmCargaVentas();
            frmVentas.Show();
        }

        private void cmdListado_Click(object sender, EventArgs e)
        {
            frmListado frmListado = new frmListado();
            frmListado.Show();
        }
    }
}
