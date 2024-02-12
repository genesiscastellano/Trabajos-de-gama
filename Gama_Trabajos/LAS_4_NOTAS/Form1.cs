using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAS_4_NOTAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            // Obtener las notas ingresadas por el usuario
            double nota1 = double.Parse(txt_nota_1.Text);
            double nota2 = double.Parse(txt_nota_2.Text);
            double nota3 = double.Parse(txt_nota_3.Text);
            double nota4 = double.Parse(txt_nota_4.Text);

            // Calcular el promedio
            double promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            // Mostrar el promedio
            txt_promedio.Text = "El promedio del estudiante es: " + promedio.ToString();

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_nota_1.Clear();
            txt_nota_2.Clear();
            txt_nota_3.Clear();
            txt_nota_3.Clear();
            txt_nota_4.Clear();
            txt_promedio.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
