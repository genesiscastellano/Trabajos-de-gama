using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATOS_ESTUDIANTES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            string Matricula = "", Nombre = "", Apellido = "", Edad = "", Carrera = "";





            Matricula = txt_marticula.Text;
            Nombre = txt_nombre.Text;
            Apellido = txt_apelldio.Text;
            Edad = txt_edad.Text;
            Carrera = txt_carrera.Text;


            txt_resultado.Text = Matricula.ToString() + Nombre.ToString() + Apellido.ToString() +
               Edad.ToString() + Carrera.ToString();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_marticula.Clear();
            txt_nombre.Clear();
            txt_apelldio.Clear();
            txt_edad.Clear();
            txt_carrera.Clear();
            txt_resultado.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

