using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUOTA_PRESTAMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            Double Monto, Tasa_Interes, Cuotas, Total;
            int Años;

            Monto = Double.Parse(txt_monto.Text);
            Años = int.Parse(txt_años.Text);

            Tasa_Interes = ((Monto * 16)/100) * Años;

            Total = Monto + Tasa_Interes;
            Cuotas = Total/(Años * 12);


            txt_taza_interes.Text = Tasa_Interes.ToString();
            txt_cuota.Text = Cuotas.ToString();
            txt_total.Text = Total.ToString();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_monto.Clear();
           txt_taza_interes.Clear();
            txt_años.Clear();
            txt_total.Clear();
            txt_cuota.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
