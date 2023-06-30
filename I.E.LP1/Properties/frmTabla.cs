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
    public partial class frmTabla : Form
    {
        public frmTabla()
        {
            InitializeComponent();
        }
        public string [,] matrizProducto = new string[5,5];
        int indiceFila, indiceColumna;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmTabla_Load(object sender, EventArgs e)
        {
            indiceFila = 0;
            indiceColumna = 0;
            

            while (indiceFila < matrizProducto.GetLength(0))
            {
                dgvProductos.Rows.Add(matrizProducto[indiceFila, 0],
                matrizProducto[indiceFila, 1],
                matrizProducto[indiceFila, 2],
                matrizProducto[indiceFila, 3]);

                indiceFila++;
            }
        }
    }
}
