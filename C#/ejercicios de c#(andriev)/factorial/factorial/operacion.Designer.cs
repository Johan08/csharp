namespace factorial
{
    partial class operacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxv1 = new System.Windows.Forms.TextBox();
            this.textBoxv2 = new System.Windows.Forms.TextBox();
            this.textBoxres = new System.Windows.Forms.TextBox();
            this.labelv1 = new System.Windows.Forms.Label();
            this.labelv2 = new System.Windows.Forms.Label();
            this.labelres = new System.Windows.Forms.Label();
            this.labelope = new System.Windows.Forms.Label();
            this.cmboperador = new System.Windows.Forms.ComboBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmboperador);
            this.groupBox1.Controls.Add(this.labelope);
            this.groupBox1.Controls.Add(this.labelres);
            this.groupBox1.Controls.Add(this.labelv2);
            this.groupBox1.Controls.Add(this.labelv1);
            this.groupBox1.Controls.Add(this.textBoxres);
            this.groupBox1.Controls.Add(this.textBoxv2);
            this.groupBox1.Controls.Add(this.textBoxv1);
            // 
            // lbl1
            // 
            this.lbl1.Size = new System.Drawing.Size(214, 17);
            this.lbl1.Text = "formulario operacion matematica";
            // 
            // btnsalir
            // 
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // textBoxv1
            // 
            this.textBoxv1.Location = new System.Drawing.Point(93, 33);
            this.textBoxv1.Name = "textBoxv1";
            this.textBoxv1.Size = new System.Drawing.Size(100, 22);
            this.textBoxv1.TabIndex = 0;
            // 
            // textBoxv2
            // 
            this.textBoxv2.Location = new System.Drawing.Point(93, 76);
            this.textBoxv2.Name = "textBoxv2";
            this.textBoxv2.Size = new System.Drawing.Size(100, 22);
            this.textBoxv2.TabIndex = 1;
            // 
            // textBoxres
            // 
            this.textBoxres.Location = new System.Drawing.Point(93, 115);
            this.textBoxres.Name = "textBoxres";
            this.textBoxres.Size = new System.Drawing.Size(100, 22);
            this.textBoxres.TabIndex = 2;
            // 
            // labelv1
            // 
            this.labelv1.AutoSize = true;
            this.labelv1.Location = new System.Drawing.Point(17, 36);
            this.labelv1.Name = "labelv1";
            this.labelv1.Size = new System.Drawing.Size(51, 17);
            this.labelv1.TabIndex = 3;
            this.labelv1.Text = "valor 1";
            // 
            // labelv2
            // 
            this.labelv2.AutoSize = true;
            this.labelv2.Location = new System.Drawing.Point(17, 79);
            this.labelv2.Name = "labelv2";
            this.labelv2.Size = new System.Drawing.Size(51, 17);
            this.labelv2.TabIndex = 4;
            this.labelv2.Text = "valor 2";
            // 
            // labelres
            // 
            this.labelres.AutoSize = true;
            this.labelres.Location = new System.Drawing.Point(17, 118);
            this.labelres.Name = "labelres";
            this.labelres.Size = new System.Drawing.Size(67, 17);
            this.labelres.TabIndex = 5;
            this.labelres.Text = "resultado";
            // 
            // labelope
            // 
            this.labelope.AutoSize = true;
            this.labelope.Location = new System.Drawing.Point(263, 33);
            this.labelope.Name = "labelope";
            this.labelope.Size = new System.Drawing.Size(66, 17);
            this.labelope.TabIndex = 6;
            this.labelope.Text = "operador";
            // 
            // cmboperador
            // 
            this.cmboperador.FormattingEnabled = true;
            this.cmboperador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%"});
            this.cmboperador.Location = new System.Drawing.Point(336, 36);
            this.cmboperador.Name = "cmboperador";
            this.cmboperador.Size = new System.Drawing.Size(121, 24);
            this.cmboperador.TabIndex = 7;
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(434, 287);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(75, 23);
            this.btncalc.TabIndex = 4;
            this.btncalc.Text = "calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // operacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 328);
            this.Controls.Add(this.btncalc);
            this.Name = "operacion";
            this.Text = "operacion";
            this.Load += new System.EventHandler(this.operacion_Load);
            this.Controls.SetChildIndex(this.btncalc, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lbl1, 0);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboperador;
        private System.Windows.Forms.Label labelope;
        private System.Windows.Forms.Label labelres;
        private System.Windows.Forms.Label labelv2;
        private System.Windows.Forms.Label labelv1;
        private System.Windows.Forms.TextBox textBoxres;
        private System.Windows.Forms.TextBox textBoxv2;
        private System.Windows.Forms.TextBox textBoxv1;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}