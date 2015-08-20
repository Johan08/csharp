namespace MDI
{
    partial class Doctores
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ColumnNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEspeci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(163, 56);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 2;
           // this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(163, 108);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 3;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 206);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 57);
            this.b1.TabIndex = 4;
            this.b1.Text = "Agregar";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(93, 206);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 57);
            this.b2.TabIndex = 5;
            this.b2.Text = "Limpiar";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(174, 206);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 57);
            this.b3.TabIndex = 6;
            this.b3.Text = "Cerrar";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Especialidad";
            // 
            // cbb
            // 
            this.cbb.FormattingEnabled = true;
            this.cbb.Items.AddRange(new object[] {
            "",
            "Kinesiologo",
            "Ginecologo",
            "Oftalmologo ",
            "Sicologo",
            "Cardiologo",
            "Psiquiatra ",
            "Neurologo "});
            this.cbb.Location = new System.Drawing.Point(163, 153);
            this.cbb.Name = "cbb";
            this.cbb.Size = new System.Drawing.Size(100, 21);
            this.cbb.TabIndex = 8;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNom,
            this.ColumnApell,
            this.ColumnEspeci});
            this.dgv.Location = new System.Drawing.Point(355, 44);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(344, 219);
            this.dgv.TabIndex = 9;
            // 
            // ColumnNom
            // 
            this.ColumnNom.HeaderText = "Nombre";
            this.ColumnNom.Name = "ColumnNom";
            // 
            // ColumnApell
            // 
            this.ColumnApell.HeaderText = "Apellido";
            this.ColumnApell.Name = "ColumnApell";
            // 
            // ColumnEspeci
            // 
            this.ColumnEspeci.HeaderText = "Especialidad";
            this.ColumnEspeci.Name = "ColumnEspeci";
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(255, 206);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 57);
            this.b4.TabIndex = 10;
            this.b4.Text = "Mostrar DGV";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // Doctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 294);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cbb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Doctores";
            this.Text = "Doctores";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApell;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEspeci;
        private System.Windows.Forms.Button b4;
    }
}