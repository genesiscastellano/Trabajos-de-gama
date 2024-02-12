namespace LAS_4_NOTAS
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
            this.txt_nota_1 = new System.Windows.Forms.TextBox();
            this.txt_nota_2 = new System.Windows.Forms.TextBox();
            this.txt_nota_3 = new System.Windows.Forms.TextBox();
            this.txt_nota_4 = new System.Windows.Forms.TextBox();
            this.txt_promedio = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOTA 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOTA 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOTA 3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "NOTA 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "PROMEDIO";
            // 
            // txt_nota_1
            // 
            this.txt_nota_1.Location = new System.Drawing.Point(183, 112);
            this.txt_nota_1.Name = "txt_nota_1";
            this.txt_nota_1.Size = new System.Drawing.Size(100, 20);
            this.txt_nota_1.TabIndex = 5;
            // 
            // txt_nota_2
            // 
            this.txt_nota_2.Location = new System.Drawing.Point(183, 163);
            this.txt_nota_2.Name = "txt_nota_2";
            this.txt_nota_2.Size = new System.Drawing.Size(100, 20);
            this.txt_nota_2.TabIndex = 6;
            // 
            // txt_nota_3
            // 
            this.txt_nota_3.Location = new System.Drawing.Point(183, 211);
            this.txt_nota_3.Name = "txt_nota_3";
            this.txt_nota_3.Size = new System.Drawing.Size(100, 20);
            this.txt_nota_3.TabIndex = 7;
            // 
            // txt_nota_4
            // 
            this.txt_nota_4.Location = new System.Drawing.Point(183, 261);
            this.txt_nota_4.Name = "txt_nota_4";
            this.txt_nota_4.Size = new System.Drawing.Size(100, 20);
            this.txt_nota_4.TabIndex = 8;
            // 
            // txt_promedio
            // 
            this.txt_promedio.Location = new System.Drawing.Point(183, 306);
            this.txt_promedio.Name = "txt_promedio";
            this.txt_promedio.Size = new System.Drawing.Size(188, 20);
            this.txt_promedio.TabIndex = 9;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(481, 109);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(118, 23);
            this.btn_calcular.TabIndex = 10;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(481, 160);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(118, 23);
            this.btn_limpiar.TabIndex = 11;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(481, 214);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(118, 23);
            this.btn_salir.TabIndex = 12;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(436, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "NOTA DE PROMEDO DEL ESTUDIANTE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 355);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_promedio);
            this.Controls.Add(this.txt_nota_4);
            this.Controls.Add(this.txt_nota_3);
            this.Controls.Add(this.txt_nota_2);
            this.Controls.Add(this.txt_nota_1);
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
        private System.Windows.Forms.TextBox txt_nota_1;
        private System.Windows.Forms.TextBox txt_nota_2;
        private System.Windows.Forms.TextBox txt_nota_3;
        private System.Windows.Forms.TextBox txt_nota_4;
        private System.Windows.Forms.TextBox txt_promedio;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label6;
    }
}

