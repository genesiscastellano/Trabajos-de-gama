namespace boton_de_eliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt1_series = new System.Windows.Forms.Label();
            this.LST_SERIES = new System.Windows.Forms.ListBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_series = new System.Windows.Forms.TextBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.txt2_indice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt1_series
            // 
            this.txt1_series.AutoSize = true;
            this.txt1_series.BackColor = System.Drawing.Color.Transparent;
            this.txt1_series.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1_series.ForeColor = System.Drawing.Color.White;
            this.txt1_series.Location = new System.Drawing.Point(12, 28);
            this.txt1_series.Name = "txt1_series";
            this.txt1_series.Size = new System.Drawing.Size(76, 20);
            this.txt1_series.TabIndex = 0;
            this.txt1_series.Text = "SERIES";
            this.txt1_series.Click += new System.EventHandler(this.txt1_series_Click);
            // 
            // LST_SERIES
            // 
            this.LST_SERIES.FormattingEnabled = true;
            this.LST_SERIES.Location = new System.Drawing.Point(105, 28);
            this.LST_SERIES.Name = "LST_SERIES";
            this.LST_SERIES.Size = new System.Drawing.Size(154, 251);
            this.LST_SERIES.TabIndex = 1;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(307, 72);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(307, 115);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(307, 210);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_series
            // 
            this.txt_series.Location = new System.Drawing.Point(298, 28);
            this.txt_series.Name = "txt_series";
            this.txt_series.Size = new System.Drawing.Size(100, 20);
            this.txt_series.TabIndex = 5;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(307, 162);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 6;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // txt2_indice
            // 
            this.txt2_indice.AutoSize = true;
            this.txt2_indice.BackColor = System.Drawing.Color.Transparent;
            this.txt2_indice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2_indice.ForeColor = System.Drawing.Color.White;
            this.txt2_indice.Location = new System.Drawing.Point(12, 72);
            this.txt2_indice.Name = "txt2_indice";
            this.txt2_indice.Size = new System.Drawing.Size(70, 20);
            this.txt2_indice.TabIndex = 7;
            this.txt2_indice.Text = "INDICE";
            this.txt2_indice.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(408, 316);
            this.Controls.Add(this.txt2_indice);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.txt_series);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.LST_SERIES);
            this.Controls.Add(this.txt1_series);
            this.Name = "Form1";
            this.Text = "SERIES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt1_series;
        private System.Windows.Forms.ListBox LST_SERIES;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_series;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label txt2_indice;
    }
}

