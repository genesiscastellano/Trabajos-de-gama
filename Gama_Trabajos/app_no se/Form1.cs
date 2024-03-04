using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_no_se
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            dgv_datos.Rows.Add(txt_nombre.Text, txt_correo.Text);

            if (string.IsNullOrWhiteSpace(txt_nombre.Text) || string.IsNullOrWhiteSpace(txt_correo.Text))
            {
                MessageBox.Show("Debe llenar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int fila;
            fila=dgv_datos.CurrentRow.Index;
            DialogResult respuesta;
            respuesta = MessageBox.Show("Desea eliminar este registro?","Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(respuesta == DialogResult.Yes)
            {
               dgv_datos.Rows.RemoveAt(fila);
                MessageBox.Show("Registro eliminar");

            }

            if (dgv_datos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgv_datos.Rows.RemoveAt(dgv_datos.SelectedRows[0].Index);
            }
        }

    }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_nombre.Clear();
            txt_correo.Clear();
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
