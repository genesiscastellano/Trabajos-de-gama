namespace app_file_03
{
    partial class TEXTO
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
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.dlg_guardar = new System.Windows.Forms.SaveFileDialog();
            this.dlg_abrir = new System.Windows.Forms.OpenFileDialog();
            this.txt_abrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(52, 40);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(253, 23);
            this.btn_Guardar.TabIndex = 0;
            this.btn_Guardar.Text = "GUARDAR";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(52, 119);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(253, 191);
            this.txtContenido.TabIndex = 1;
            // 
            // dlg_abrir
            // 
            this.dlg_abrir.FileName = "openFileDialog1";
            // 
            // txt_abrir
            // 
            this.txt_abrir.Location = new System.Drawing.Point(52, 80);
            this.txt_abrir.Name = "txt_abrir";
            this.txt_abrir.Size = new System.Drawing.Size(253, 23);
            this.txt_abrir.TabIndex = 2;
            this.txt_abrir.Text = "ABRIR";
            this.txt_abrir.UseVisualStyleBackColor = true;
            this.txt_abrir.Click += new System.EventHandler(this.txt_abrir_Click);
            // 
            // TEXTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 322);
            this.Controls.Add(this.txt_abrir);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.btn_Guardar);
            this.Name = "TEXTO";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.SaveFileDialog dlg_guardar;
        private System.Windows.Forms.OpenFileDialog dlg_abrir;
        private System.Windows.Forms.Button txt_abrir;
    }
}

