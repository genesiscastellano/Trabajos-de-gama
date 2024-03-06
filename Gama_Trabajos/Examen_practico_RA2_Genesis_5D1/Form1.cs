using Microsoft.Win32;
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
using static Examen_practico_RA2_Genesis_5D1.Resgistro_estudiantes;

namespace Examen_practico_RA2_Genesis_5D1
{
    public partial class Resgistro_estudiantes : Form
    {
        private List<Estudiante> Estudiantes = new List<Estudiante>();
        public Resgistro_estudiantes()
        {
            InitializeComponent();
            desativarCOntroles();
        }

        private void desativarCOntroles()
        {
            btn_guardar.Enabled = false;
            btn_emilinar.Enabled = false;
            bnt_nuevo.Enabled = true;
        }

        private void activarControles()
        {
            btn_guardar.Enabled = true;
            btn_emilinar.Enabled = true;
            bnt_nuevo.Enabled = false;
        }

        private void LimpiarCampo()
        {
            txt_matricula.Text = "";
            txt_nombre.Text = "";
            txt_dirrecion.Text = "";
            txt_telefono.Text = "";
            txt_email.Text = "";
            cmb_curso.SelectedIndex = -1;
            cmb_area_tecnica.SelectedIndex = -1;
            cmb_seccion.SelectedIndex = -1;
            rdb_masculino.Checked = false;
            rdb_femenino.Checked = false;
            txt_matricula.Focus();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            activarControles();
            LimpiarCampo();
        }
        private void Resgistro_estudiantes_Load(object sender, EventArgs e)
        {
            cmb_curso.Items.AddRange(new string[] { "Curso 1", "Curso 2", "Curso 3" });
            cmb_seccion.Items.AddRange(new string[] { "Sección A", "Sección B", "Sección C" });
            cmb_area_tecnica.Items.AddRange(new string[] { "Área 1", "Área 2", "Área 3" });
        }

        private void bnt_nuevo_Click(object sender, EventArgs e)
        {
            activarControles();
            LimpiarCampo();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_maestro.Clear();
            LimpiarCampo();



        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            GuardarEnArchivo();
        }

        private void FormRegistroEstudiantes_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btn_emilinar_Click(object sender, EventArgs e)
        {
            if (dgb_datos_estudiantes.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este estudiante?", "Eliminar Estudiante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int rowIndex = dgb_datos_estudiantes.SelectedRows[0].Index;
                    dgb_datos_estudiantes.Rows.RemoveAt(rowIndex);
                    Estudiantes.RemoveAt(rowIndex);
                }
            }
        }


        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            GuardarEnArchivo();
        }

        private void GuardarEnArchivo()
        {
            using (StreamWriter sw = new StreamWriter("estudiantes.txt"))
            {
                foreach (Estudiante estudiante in Estudiantes)
                {
                    sw.WriteLine($"{estudiante.Matricula},{estudiante.Nombre},{estudiante.Curso},{estudiante.Seccion},{estudiante.AreaTecnica}");
                }
            }

            MessageBox.Show("Los datos se han guardado correctamente en el archivo estudiantes.txt", "Guardado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string matricula = txt_matricula.Text;
            string nombre = txt_nombre.Text;
            string direccion = txt_dirrecion.Text;
            string telefono = txt_telefono.Text;
            string email = txt_email.Text;
            string curso = cmb_curso.SelectedItem.ToString();
            string seccion = cmb_seccion.SelectedItem.ToString();
            string areaTecnica = cmb_area_tecnica.SelectedItem.ToString();
            string maestrotitular = txt_maestro.Text;
            string genero = rdb_masculino.Checked ? "Masculino" : "Femenino";

            Estudiantes.Add(new Estudiante(matricula, nombre, direccion, telefono, email, curso, seccion, areaTecnica, genero));

            dgb_datos_estudiantes.Rows.Add(matricula, nombre, direccion, telefono, email, curso, seccion, areaTecnica, maestrotitular, genero);

            desativarCOntroles();
            LimpiarCampo();


        }
        public class Estudiante
        {
            public string Matricula { get; set; }
            public string Nombre { get; set; }
            public string Direccion { get; set; }
            public string Telefono { get; set; }
            public string Email { get; set; }
            public string Curso { get; set; }
            public string Seccion { get; set; }
            public string AreaTecnica { get; set; }
            public string Genero { get; set; }

            public Estudiante(string matricula, string nombre, string direccion, string telefono, string email, string curso, string seccion, string areaTecnica, string genero)
            {
                Matricula = matricula;
                Nombre = nombre;
                Direccion = direccion;
                Telefono = telefono;
                Email = email;
                Curso = curso;
                Seccion = seccion;
                AreaTecnica = areaTecnica;
                Genero = genero;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();



            }
        }
    }
}

    

