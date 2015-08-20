namespace MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarApellidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDoctoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarEspecialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarToolStripMenuItem,
            this.doctoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(442, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // limpiarToolStripMenuItem
            // 
            this.limpiarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarNombreToolStripMenuItem,
            this.limpiarApellidoToolStripMenuItem,
            this.limpiarEspecialidadToolStripMenuItem,
            this.limpiarTodoToolStripMenuItem});
            this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.limpiarToolStripMenuItem.Text = "Limpiar";
            // 
            // limpiarNombreToolStripMenuItem
            // 
            this.limpiarNombreToolStripMenuItem.Name = "limpiarNombreToolStripMenuItem";
            this.limpiarNombreToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.limpiarNombreToolStripMenuItem.Text = "Limpiar Nombre";
            this.limpiarNombreToolStripMenuItem.Click += new System.EventHandler(this.limpiarNombreToolStripMenuItem_Click);
            // 
            // limpiarApellidoToolStripMenuItem
            // 
            this.limpiarApellidoToolStripMenuItem.Name = "limpiarApellidoToolStripMenuItem";
            this.limpiarApellidoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.limpiarApellidoToolStripMenuItem.Text = "Limpiar Apellido";
            this.limpiarApellidoToolStripMenuItem.Click += new System.EventHandler(this.limpiarApellidoToolStripMenuItem_Click);
            // 
            // limpiarTodoToolStripMenuItem
            // 
            this.limpiarTodoToolStripMenuItem.Name = "limpiarTodoToolStripMenuItem";
            this.limpiarTodoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.limpiarTodoToolStripMenuItem.Text = "Limpiar Todo";
            this.limpiarTodoToolStripMenuItem.Click += new System.EventHandler(this.limpiarTodoToolStripMenuItem_Click);
            // 
            // doctoresToolStripMenuItem
            // 
            this.doctoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctoresToolStripMenuItem1,
            this.listaDoctoresToolStripMenuItem});
            this.doctoresToolStripMenuItem.Name = "doctoresToolStripMenuItem";
            this.doctoresToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.doctoresToolStripMenuItem.Text = "Formulario";
            // 
            // doctoresToolStripMenuItem1
            // 
            this.doctoresToolStripMenuItem1.Name = "doctoresToolStripMenuItem1";
            this.doctoresToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.doctoresToolStripMenuItem1.Text = "Doctores";
            this.doctoresToolStripMenuItem1.Click += new System.EventHandler(this.doctoresToolStripMenuItem1_Click);
            // 
            // listaDoctoresToolStripMenuItem
            // 
            this.listaDoctoresToolStripMenuItem.Name = "listaDoctoresToolStripMenuItem";
            this.listaDoctoresToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.listaDoctoresToolStripMenuItem.Text = "Receptor Doctores";
            this.listaDoctoresToolStripMenuItem.Click += new System.EventHandler(this.listaDoctoresToolStripMenuItem_Click);
            // 
            // limpiarEspecialidadToolStripMenuItem
            // 
            this.limpiarEspecialidadToolStripMenuItem.Name = "limpiarEspecialidadToolStripMenuItem";
            this.limpiarEspecialidadToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.limpiarEspecialidadToolStripMenuItem.Text = "Limpiar Especialidad";
            this.limpiarEspecialidadToolStripMenuItem.Click += new System.EventHandler(this.limpiarEspecialidadToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 324);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarApellidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaDoctoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarEspecialidadToolStripMenuItem;
    }
}

