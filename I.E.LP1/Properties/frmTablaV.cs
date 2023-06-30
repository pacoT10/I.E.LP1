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
    public partial class frmTablaV : Form
    {
        public frmTablaV()
        {
            InitializeComponent();
        }

        public string[,] matrizVentas = new string[5,5];
        int indiceFila, indiceColumna;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvVentas.CurrentCell = null;
            foreach (DataGridViewRow r in dgvVentas.Rows)
            {
                r.Visible = false;
            }
            foreach (DataGridViewRow  r in dgvVentas.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    if ((c.Value.ToString().ToUpper()).IndexOf(txtFiltro.Text.ToUpper()) == 0)
                    {
                        r.Visible = true;
                    }
                }
            }
        }

        private void frmTablaV_Load(object sender, EventArgs e)
        {
            indiceFila = 0;
            indiceColumna = 0;

            while (indiceFila < matrizVentas.GetLength(0))
            {
               dgvVentas.Rows.Add(matrizVentas[indiceFila,0],
                    matrizVentas[indiceFila,1],
                    matrizVentas[indiceFila,2],
                    matrizVentas[indiceFila,3],
                    matrizVentas[indiceFila, 4]);
                
                indiceFila++;
            }

        }

    }
}
