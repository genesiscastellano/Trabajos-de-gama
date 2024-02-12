using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boton_de_eliminar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            LST_SERIES.Items.Add(txt_series.Text);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LST_SERIES.Items.Clear();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (LST_SERIES.SelectedIndex != -1)
            {
                LST_SERIES.Items.RemoveAt(LST_SERIES.SelectedIndex);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt1_series_Click(object sender, EventArgs e)
        {

        }
    }
}
