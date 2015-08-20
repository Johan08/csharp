namespace factorial
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularFactorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.calcuadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.moduloToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(797, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.sistemaToolStripMenuItem.Text = "sistema";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.salirToolStripMenuItem.Text = "salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // moduloToolStripMenuItem
            // 
            this.moduloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularFactorialToolStripMenuItem,
            this.verificadorToolStripMenuItem,
            this.calcuadoraToolStripMenuItem});
            this.moduloToolStripMenuItem.Name = "moduloToolStripMenuItem";
            this.moduloToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.moduloToolStripMenuItem.Text = "modulo";
            // 
            // calcularFactorialToolStripMenuItem
            // 
            this.calcularFactorialToolStripMenuItem.Name = "calcularFactorialToolStripMenuItem";
            this.calcularFactorialToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.calcularFactorialToolStripMenuItem.Text = "calcular factorial";
            this.calcularFactorialToolStripMenuItem.Click += new System.EventHandler(this.calcularFactorialToolStripMenuItem_Click);
            // 
            // verificadorToolStripMenuItem
            // 
            this.verificadorToolStripMenuItem.Name = "verificadorToolStripMenuItem";
            this.verificadorToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.verificadorToolStripMenuItem.Text = "verificador";
            this.verificadorToolStripMenuItem.Click += new System.EventHandler(this.verificadorToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecha,
            this.hora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 372);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(797, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // fecha
            // 
            this.fecha.AutoSize = false;
            this.fecha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fecha.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.fecha.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(100, 19);
            // 
            // hora
            // 
            this.hora.AutoSize = false;
            this.hora.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hora.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.hora.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(100, 19);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // calcuadoraToolStripMenuItem
            // 
            this.calcuadoraToolStripMenuItem.Name = "calcuadoraToolStripMenuItem";
            this.calcuadoraToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.calcuadoraToolStripMenuItem.Text = "calcuadora";
            this.calcuadoraToolStripMenuItem.Click += new System.EventHandler(this.calcuadoraToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 396);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularFactorialToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel hora;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ToolStripStatusLabel fecha;
        private System.Windows.Forms.ToolStripMenuItem verificadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcuadoraToolStripMenuItem;
    }
}

