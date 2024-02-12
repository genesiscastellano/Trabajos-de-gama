using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOSPITAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double Presupuesto, Emergencia, Cirugia, Suministros, Laboratorio, Administracion, Imagenes;

            Presupuesto = Double.Parse(txt_presupuestos.Text);

            Emergencia = (Presupuesto * 30) / 100;
            Cirugia = (Presupuesto * 15) / 100;
            Suministros = (Presupuesto * 25) / 100;
            Administracion = (Presupuesto * 18) / 100;
            Laboratorio = (Presupuesto * 5) / 100;
            Imagenes = (Presupuesto * 7) / 100;

            txt_emergencia.Text = Emergencia.ToString();
            txt_cirugia.Text = Cirugia.ToString();
            txt_suministros.Text = Suministros.ToString();
            txt_administracion.Text = Administracion.ToString();
            txt_laboratorio.Text = Laboratorio.ToString();
            txt_imagenes.Text = Imagenes.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_presupuestos.Clear();
            txt_emergencia.Clear();
            txt_cirugia.Clear();
            txt_suministros.Clear();
            txt_administracion.Clear();
            txt_laboratorio.Clear();
            txt_imagenes.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
