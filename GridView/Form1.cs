using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridView
{
    public partial class Form1 : Form
    {
        Acciones acc = new Acciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgDatos.DataSource = null;
            dgDatos.DataSource = acc.MostrarInfo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (acc.EliminarAuto(Convert.ToInt32(txbMatricula.Text)))
            {
                MessageBox.Show("Eliminado con éxito");
            }
            else
            {
                MessageBox.Show("Fallo al eliminar");
            }
        }
    }
}
