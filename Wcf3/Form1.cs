using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wcf3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Codigo = Convert.ToInt32(textBox1.Text);
            using (ServiceProducto.Service1Client Pro = new ServiceProducto.Service1Client())
            {
                var producto = Pro.ObtenerProducto(Codigo);

                var nombre = producto.Nombre;
                var cl = producto.Clasificación;
                var inv = producto.inventario;
                textBox4.Text = nombre;
                textBox3.Text = cl;
                textBox2.Text = inv;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();
        }
    }
}
