namespace RENTA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_pago_por_hora = new System.Windows.Forms.TextBox();
            this.txt_horas_trabajadas = new System.Windows.Forms.TextBox();
            this.txt_sueldo_bruto = new System.Windows.Forms.TextBox();
            this.txt_afp = new System.Windows.Forms.TextBox();
            this.txt_sfs = new System.Windows.Forms.TextBox();
            this.txt_total_descuento = new System.Windows.Forms.TextBox();
            this.txt_sueldo_neto = new System.Windows.Forms.TextBox();
            this.txt_sueldo_anual = new System.Windows.Forms.TextBox();
            this.txt_irs = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAGO POR HORA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "HORAS TRABAJADAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "SUELDO BRUTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "AFP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "SFS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "TOTAL DE DESCUENTO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "SUELDO NETO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "SUELDO ANUAL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "IRS";
            // 
            // txt_pago_por_hora
            // 
            this.txt_pago_por_hora.Location = new System.Drawing.Point(227, 46);
            this.txt_pago_por_hora.Name = "txt_pago_por_hora";
            this.txt_pago_por_hora.Size = new System.Drawing.Size(100, 20);
            this.txt_pago_por_hora.TabIndex = 9;
            // 
            // txt_horas_trabajadas
            // 
            this.txt_horas_trabajadas.Location = new System.Drawing.Point(227, 91);
            this.txt_horas_trabajadas.Name = "txt_horas_trabajadas";
            this.txt_horas_trabajadas.Size = new System.Drawing.Size(100, 20);
            this.txt_horas_trabajadas.TabIndex = 10;
            // 
            // txt_sueldo_bruto
            // 
            this.txt_sueldo_bruto.Location = new System.Drawing.Point(227, 131);
            this.txt_sueldo_bruto.Name = "txt_sueldo_bruto";
            this.txt_sueldo_bruto.Size = new System.Drawing.Size(100, 20);
            this.txt_sueldo_bruto.TabIndex = 11;
            // 
            // txt_afp
            // 
            this.txt_afp.Location = new System.Drawing.Point(227, 168);
            this.txt_afp.Name = "txt_afp";
            this.txt_afp.Size = new System.Drawing.Size(100, 20);
            this.txt_afp.TabIndex = 12;
            // 
            // txt_sfs
            // 
            this.txt_sfs.Location = new System.Drawing.Point(227, 205);
            this.txt_sfs.Name = "txt_sfs";
            this.txt_sfs.Size = new System.Drawing.Size(100, 20);
            this.txt_sfs.TabIndex = 13;
            // 
            // txt_total_descuento
            // 
            this.txt_total_descuento.Location = new System.Drawing.Point(227, 248);
            this.txt_total_descuento.Name = "txt_total_descuento";
            this.txt_total_descuento.Size = new System.Drawing.Size(100, 20);
            this.txt_total_descuento.TabIndex = 14;
            // 
            // txt_sueldo_neto
            // 
            this.txt_sueldo_neto.Location = new System.Drawing.Point(227, 298);
            this.txt_sueldo_neto.Name = "txt_sueldo_neto";
            this.txt_sueldo_neto.Size = new System.Drawing.Size(100, 20);
            this.txt_sueldo_neto.TabIndex = 15;
            // 
            // txt_sueldo_anual
            // 
            this.txt_sueldo_anual.Location = new System.Drawing.Point(227, 339);
            this.txt_sueldo_anual.Name = "txt_sueldo_anual";
            this.txt_sueldo_anual.Size = new System.Drawing.Size(100, 20);
            this.txt_sueldo_anual.TabIndex = 16;
            // 
            // txt_irs
            // 
            this.txt_irs.Location = new System.Drawing.Point(227, 380);
            this.txt_irs.Name = "txt_irs";
            this.txt_irs.Size = new System.Drawing.Size(100, 20);
            this.txt_irs.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(539, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(539, 93);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(125, 23);
            this.btn_limpiar.TabIndex = 19;
            this.btn_limpiar.Text = "limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(539, 146);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(125, 23);
            this.btn_salir.TabIndex = 20;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_irs);
            this.Controls.Add(this.txt_sueldo_anual);
            this.Controls.Add(this.txt_sueldo_neto);
            this.Controls.Add(this.txt_total_descuento);
            this.Controls.Add(this.txt_sfs);
            this.Controls.Add(this.txt_afp);
            this.Controls.Add(this.txt_sueldo_bruto);
            this.Controls.Add(this.txt_horas_trabajadas);
            this.Controls.Add(this.txt_pago_por_hora);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_pago_por_hora;
        private System.Windows.Forms.TextBox txt_horas_trabajadas;
        private System.Windows.Forms.TextBox txt_sueldo_bruto;
        private System.Windows.Forms.TextBox txt_afp;
        private System.Windows.Forms.TextBox txt_sfs;
        private System.Windows.Forms.TextBox txt_total_descuento;
        private System.Windows.Forms.TextBox txt_sueldo_neto;
        private System.Windows.Forms.TextBox txt_sueldo_anual;
        private System.Windows.Forms.TextBox txt_irs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
    }
}

