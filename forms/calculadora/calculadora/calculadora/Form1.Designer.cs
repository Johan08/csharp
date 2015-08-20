namespace calc
{
    partial class Form1
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
            this.b_multiplicar = new System.Windows.Forms.Button();
            this.b_restar = new System.Windows.Forms.Button();
            this.b_sumar = new System.Windows.Forms.Button();
            this.b_dividir = new System.Windows.Forms.Button();
            this.b_salir = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_multiplicar
            // 
            this.b_multiplicar.Location = new System.Drawing.Point(126, 219);
            this.b_multiplicar.Name = "b_multiplicar";
            this.b_multiplicar.Size = new System.Drawing.Size(37, 26);
            this.b_multiplicar.TabIndex = 0;
            this.b_multiplicar.Text = "x";
            this.b_multiplicar.UseVisualStyleBackColor = true;
            this.b_multiplicar.Click += new System.EventHandler(this.b_multiplicar_Click);
            // 
            // b_restar
            // 
            this.b_restar.Location = new System.Drawing.Point(191, 174);
            this.b_restar.Name = "b_restar";
            this.b_restar.Size = new System.Drawing.Size(32, 23);
            this.b_restar.TabIndex = 1;
            this.b_restar.Text = "-";
            this.b_restar.UseVisualStyleBackColor = true;
            this.b_restar.Click += new System.EventHandler(this.b_restar_Click);
            // 
            // b_sumar
            // 
            this.b_sumar.Location = new System.Drawing.Point(126, 174);
            this.b_sumar.Name = "b_sumar";
            this.b_sumar.Size = new System.Drawing.Size(37, 23);
            this.b_sumar.TabIndex = 2;
            this.b_sumar.Text = "+";
            this.b_sumar.UseVisualStyleBackColor = true;
            this.b_sumar.Click += new System.EventHandler(this.b_sumar_Click);
            // 
            // b_dividir
            // 
            this.b_dividir.Location = new System.Drawing.Point(191, 219);
            this.b_dividir.Name = "b_dividir";
            this.b_dividir.Size = new System.Drawing.Size(32, 26);
            this.b_dividir.TabIndex = 3;
            this.b_dividir.Text = "/";
            this.b_dividir.UseVisualStyleBackColor = true;
            this.b_dividir.Click += new System.EventHandler(this.b_dividir_Click);
            // 
            // b_salir
            // 
            this.b_salir.Location = new System.Drawing.Point(271, 35);
            this.b_salir.Name = "b_salir";
            this.b_salir.Size = new System.Drawing.Size(75, 71);
            this.b_salir.TabIndex = 4;
            this.b_salir.Text = "Salir";
            this.b_salir.UseVisualStyleBackColor = true;
            this.b_salir.Click += new System.EventHandler(this.b_salir_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(90, 49);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 5;
            this.txt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(90, 88);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "INGRESE SU PRIMER NUMERO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "INGRESE SU SEGUNDO NUMERO: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 320);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.b_salir);
            this.Controls.Add(this.b_dividir);
            this.Controls.Add(this.b_sumar);
            this.Controls.Add(this.b_restar);
            this.Controls.Add(this.b_multiplicar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_multiplicar;
        private System.Windows.Forms.Button b_restar;
        private System.Windows.Forms.Button b_sumar;
        private System.Windows.Forms.Button b_dividir;
        private System.Windows.Forms.Button b_salir;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        public System.EventHandler Form1_Load { get; set; }
    }
}

