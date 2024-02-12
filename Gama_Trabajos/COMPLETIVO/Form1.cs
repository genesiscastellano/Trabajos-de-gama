using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETIVO
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
            int Nota_1, Nota_2, Nota_3, Nota_4, Promedio;



            Double? Prueba_Completiva = null, Nota_Completiva,
               Promedio_Completivo;

            Prueba_Completiva = Double.Parse(txt_prueba_completiva.Text);
            String Situacion, Situacion_Completiva;

            Nota_1=int.Parse(txt_nota_1.Text);
            Nota_2=int.Parse(txt_nota_2.Text);
            Nota_3=int.Parse(txt_nota_3.Text);
            Nota_4=int.Parse(txt_nota_4.Text);


            Promedio =(Nota_1 + Nota_2 + Nota_3 + Nota_4)/4;

            txt_nota_completiva.Enabled= false;
            txt_prueba_completiva.Enabled= false;
            txt_promedio_completivo.Enabled=false;
            txt_situacion_completiva.Enabled = false;

            Nota_Completiva = Promedio/2;
            txt_prueba_completiva.Text=Prueba_Completiva.ToString();

            Promedio_Completivo= Nota_Completiva+Prueba_Completiva/2;

            txt_promedio.Text= Promedio.ToString();

            txt_nota_completiva.Text= Nota_Completiva.ToString();
            txt_prueba_completiva.Text = Prueba_Completiva.ToString();
            txt_promedio_completivo.Text = Promedio_Completivo.ToString();



            if (Promedio<70 && Promedio_Completivo >=70)
            {
                txt_nota_completiva.ForeColor=Color.Red;
                txt_prueba_completiva.ForeColor=Color.Red;
                txt_promedio_completivo.ForeColor=Color.Green;



                txt_nota_completiva.Enabled= true;
                txt_prueba_completiva.Enabled= true;
                txt_promedio_completivo.Enabled= true;
                txt_situacion_completiva.Enabled = true;


                Situacion_Completiva="Aprobado";
            }
            else
                {
                    Situacion="Reprobado";


                    txt_nota_completiva.ForeColor=Color.Red;
                    txt_prueba_completiva.ForeColor=Color.Red;
                    txt_promedio_completivo.ForeColor=Color.Red;


                    txt_nota_completiva.Enabled= true;
                    txt_prueba_completiva.Enabled= true;
                    txt_promedio_completivo.Enabled= true;
                    txt_situacion_completiva.Enabled = true;

                    Situacion_Completiva="Reprobado";



                }
                txt_situacion_completiva.Text= Situacion_Completiva;
            }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_nota_1.Clear();
            txt_nota_2.Clear();
            txt_nota_3.Clear();
            txt_nota_4.Clear();
            txt_promedio.Clear();
            txt_situacion.Clear();
            txt_nota_completiva.Clear();
            txt_prueba_completiva.Clear();
            txt_promedio_completivo.Clear();
            txt_situacion_completiva.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    }
    

