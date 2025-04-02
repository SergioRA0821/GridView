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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (acc.AgregarAuto(Convert.ToInt32(txbMatricula2.Text), txbColor.Text, Convert.ToInt32(txbAño.Text), txbMarca.Text, txbPais.Text))
            {
                MessageBox.Show("Agregado con éxito");
            }
            else

            {
                MessageBox.Show("Fallo al agregar");
            }
        }
    }
}
