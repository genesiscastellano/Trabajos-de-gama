using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabla_de_Multiplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            {
                if (int.TryParse(txt_tabla.Text, out int numero))
                {
                    list_Multiplica.Items.Clear();
                    for (int i = 1; i <= 12; i++)
                    {
                        int resultado = numero * i;
                        list_Multiplica.Items.Add($"{numero} x {i} = {resultado}");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un número válido.");
                }

            }

        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            list_Multiplica.Items.Clear();
            txt_tabla.Clear();


        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
