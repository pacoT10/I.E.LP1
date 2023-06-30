using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I.E.LP1.Properties
{
    public partial class frmCargaVentas : Form
    {
        public frmCargaVentas()
        {
            InitializeComponent();
        }

        frmTablaV ventas = new frmTablaV();

        int indiceFVenta;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCargaVentas_Load(object sender, EventArgs e)
        {

        }

        private void lblidV_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtpFechaVenta.Value >= DateTime.Today)
            {
                ventas.matrizVentas[indiceFVenta, 0] = dtpFechaVenta.Value.ToString();
                ventas.matrizVentas[indiceFVenta, 1] = txtIDV.Text;
                ventas.matrizVentas[indiceFVenta, 2] = txtProducto.Text;
                ventas.matrizVentas[indiceFVenta, 3] = txtCantidad.Text;

                indiceFVenta++;

                if (indiceFVenta == ventas.matrizVentas.GetLength(0))
                {
                    cmdCargarV.Enabled = false;
                }

            }
            else
            {
                MessageBox.Show("Seleccione una fecha actual o posterior a la de hoy", "Carga de Tarea",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dtpFechaVenta.Value = DateTime.Today;
                dtpFechaVenta.Focus();
            }
        }

        private void cmdConsultaV_Click(object sender, EventArgs e)
        {
            ventas.ShowDialog();
            this.Hide();
        }

        private void txtIDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
