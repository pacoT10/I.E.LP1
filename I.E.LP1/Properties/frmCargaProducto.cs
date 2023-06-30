using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace I.E.LP1.Properties
{
    public partial class frmCargaProducto : Form
    {
        public frmCargaProducto()
        {
            InitializeComponent();
        }
        frmTabla tabla = new frmTabla();

        int indiceProducto;

        private void frmCargaProducto_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabla.ShowDialog();
            this.Hide();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Value >= DateTime.Today)
            {
                MessageBox.Show("Carga exitosa...");

                tabla.matrizProducto[indiceProducto, 0] = dtpFecha.Value.ToString();
                tabla.matrizProducto[indiceProducto, 1] = txtID.Text;
                tabla.matrizProducto[indiceProducto, 2] = txtNombre.Text;

                indiceProducto++;

                if (indiceProducto == tabla.matrizProducto.GetLength(0))
                {
                    cmdCargar.Enabled = false;
                }


            }
            else
            {
                MessageBox.Show("Seleccione una fecha actual o posterior a la de hoy", "Carga de Tarea",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dtpFecha.Value = DateTime.Today;
                dtpFecha.Focus();
            }


        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}

