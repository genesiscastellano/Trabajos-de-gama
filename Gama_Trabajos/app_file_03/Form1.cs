using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_file_03
{
    public partial class TEXTO : Form
    {
        private object dlgGuardar;

        public TEXTO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dlg_guardar.ShowDialog() == DialogResult.OK) ;
            {
                string rutaArchivo = dlg_guardar.FileName;
                string createxto = txtContenido.Text;
                StreamWriter archivo = File.CreateText(rutaArchivo);

                archivo.Write(createxto);
                archivo.Flush();
                archivo.Close();
            }
        }

        private void txt_abrir_Click(object sender, EventArgs e)
        {
            if (dlg_abrir.ShowDialog() == DialogResult.OK)

            {
                string rutaarchivo = dlg_abrir.FileName;
                StreamReader sr = new StreamReader(rutaarchivo);
                txtContenido.Text = sr.ReadToEnd();
            }
        }
    }
}



