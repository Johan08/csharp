namespace FormulariosVarios
{
    partial class FormInicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_uvnumeros = new System.Windows.Forms.Button();
            this.b_uvletras = new System.Windows.Forms.Button();
            this.b_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_uvnumeros
            // 
            this.b_uvnumeros.Location = new System.Drawing.Point(75, 112);
            this.b_uvnumeros.Name = "b_uvnumeros";
            this.b_uvnumeros.Size = new System.Drawing.Size(190, 23);
            this.b_uvnumeros.TabIndex = 0;
            this.b_uvnumeros.Text = "Formulario Validador Números";
            this.b_uvnumeros.UseVisualStyleBackColor = true;
            this.b_uvnumeros.Click += new System.EventHandler(this.b_uvnumeros_Click);
            // 
            // b_uvletras
            // 
            this.b_uvletras.Location = new System.Drawing.Point(75, 163);
            this.b_uvletras.Name = "b_uvletras";
            this.b_uvletras.Size = new System.Drawing.Size(190, 23);
            this.b_uvletras.TabIndex = 1;
            this.b_uvletras.Text = "Formulario Validador Letras";
            this.b_uvletras.UseVisualStyleBackColor = true;
            this.b_uvletras.Click += new System.EventHandler(this.b_uvletras_Click);
            // 
            // b_salir
            // 
            this.b_salir.Location = new System.Drawing.Point(130, 211);
            this.b_salir.Name = "b_salir";
            this.b_salir.Size = new System.Drawing.Size(75, 23);
            this.b_salir.TabIndex = 2;
            this.b_salir.Text = "Salir";
            this.b_salir.UseVisualStyleBackColor = true;
            this.b_salir.Click += new System.EventHandler(this.b_salir_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 290);
            this.Controls.Add(this.b_salir);
            this.Controls.Add(this.b_uvletras);
            this.Controls.Add(this.b_uvnumeros);
            this.Name = "FormInicio";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_uvnumeros;
        private System.Windows.Forms.Button b_uvletras;
        private System.Windows.Forms.Button b_salir;
    }
}

