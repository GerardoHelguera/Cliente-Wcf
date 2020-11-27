using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wcs2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Identificador = Convert.ToString(textBox1.Text);
            using (ServiceCliente.Service1Client Cliente = new ServiceCliente.Service1Client())
            {
                var cliente = Cliente.ObtenerCliente(Identificador);

                var nombre = cliente.Nombre;
                var Ap = cliente.Apellido_Paterno;
                var Am = cliente.Apellido_Materno;
                textBox4.Text = nombre;
                textBox3.Text = Ap;
                textBox2.Text = Am;
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
