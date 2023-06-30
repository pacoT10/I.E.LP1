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
    public partial class frmListado : Form
    {
        public frmListado()
        {
            InitializeComponent();
        }
        public string[,] matrizVentas = new string[5, 5];
        
        int indiceFilaV, indiceColumnaV;
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListado_Load(object sender, EventArgs e)
        {
            indiceFilaV = 0;
            indiceColumnaV = 0;

            while (indiceFilaV < matrizVentas.GetLength(0))
            {
                dgvVentas.Rows.Add(matrizVentas[indiceFilaV, 0],
                     matrizVentas[indiceFilaV, 1],
                     matrizVentas[indiceFilaV, 2],
                     matrizVentas[indiceFilaV, 3],
                     matrizVentas[indiceFilaV, 4]);

                indiceFilaV++;
            }
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
