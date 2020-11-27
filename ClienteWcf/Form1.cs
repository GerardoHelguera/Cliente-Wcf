using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWcf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /* ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client();
            var lista = cliente.ObtenerAlumno();
           var lista = cliente.ObtenerAlumno(Semestre);*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Semestre = Convert.ToInt32(textBox1.Text);
            using (ServiceReference1.Service1Client llamada = new ServiceReference1.Service1Client())
            {
                var alumno = llamada.ObtenerAlumno(Semestre);
                var nombre = alumno.Nombre;
                var carrera = alumno.Carrera;
                var no = alumno.Num_Control;
                textBox4.Text = nombre;
                textBox3.Text = carrera;
                textBox2.Text = no;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();
        }

        /* static void Main(string[] args)
         {
             ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client();
             var ola = cliente.ObtenerAlumno();
         }*/
    }
}
