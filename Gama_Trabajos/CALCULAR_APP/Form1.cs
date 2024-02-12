using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CALCULAR_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_calcular_Click(object sender, EventArgs e)
        {
            int valor1, valor2;
            //Entrada de datos
            valor1 = int.Parse(txt_valir_1.Text);
            valor2 = int.Parse(txt_valor_2.Text);
            //Proceso
            int resultado = valor1 + valor2;
            int Resta = valor1 - valor2;
            int Multiplicacion = valor1 * valor2;
            int Division = valor1 / valor2;

            //Salida de datos
            txt_resultado.Text = resultado.ToString();
            txt_resta.Text = Resta.ToString();
            txt_multiplicar.Text = Multiplicacion.ToString();
            txt_division.Text = Division.ToString();

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_valir_1.Clear();
            txt_valor_2.Clear();
            txt_resultado.Clear();
            txt_resta.Clear();
           txt_multiplicar.Clear();
            txt_division.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


    }


