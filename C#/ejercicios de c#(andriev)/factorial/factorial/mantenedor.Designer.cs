namespace factorial
{
    partial class mantenedor
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
            this.lblrut = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblapp = new System.Windows.Forms.Label();
            this.lblprom = new System.Windows.Forms.Label();
            this.lblcarr = new System.Windows.Forms.Label();
            this.lblam = new System.Windows.Forms.Label();
            this.txtrut = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtapp = new System.Windows.Forms.TextBox();
            this.txtapm = new System.Windows.Forms.TextBox();
            this.txtprom = new System.Windows.Forms.TextBox();
            this.txtdig = new System.Windows.Forms.TextBox();
            this.btnelim = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbcarrera = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbcarrera);
            this.groupBox1.Controls.Add(this.txtdig);
            this.groupBox1.Controls.Add(this.txtprom);
            this.groupBox1.Controls.Add(this.txtapm);
            this.groupBox1.Controls.Add(this.txtapp);
            this.groupBox1.Controls.Add(this.txtnom);
            this.groupBox1.Controls.Add(this.txtrut);
            this.groupBox1.Controls.Add(this.lblprom);
            this.groupBox1.Controls.Add(this.lblcarr);
            this.groupBox1.Controls.Add(this.lblam);
            this.groupBox1.Controls.Add(this.lblapp);
            this.groupBox1.Controls.Add(this.lblnom);
            this.groupBox1.Controls.Add(this.lblrut);
            // 
            // lbl1
            // 
            this.lbl1.Size = new System.Drawing.Size(141, 17);
            this.lbl1.Text = "mantenedor alumnos";
            // 
            // lblrut
            // 
            this.lblrut.AutoSize = true;
            this.lblrut.Location = new System.Drawing.Point(17, 33);
            this.lblrut.Name = "lblrut";
            this.lblrut.Size = new System.Drawing.Size(25, 17);
            this.lblrut.TabIndex = 0;
            this.lblrut.Text = "rut";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(17, 69);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(56, 17);
            this.lblnom.TabIndex = 1;
            this.lblnom.Text = "nombre";
            // 
            // lblapp
            // 
            this.lblapp.AutoSize = true;
            this.lblapp.Location = new System.Drawing.Point(17, 98);
            this.lblapp.Name = "lblapp";
            this.lblapp.Size = new System.Drawing.Size(110, 17);
            this.lblapp.TabIndex = 2;
            this.lblapp.Text = "apellido paterno";
            // 
            // lblprom
            // 
            this.lblprom.AutoSize = true;
            this.lblprom.Location = new System.Drawing.Point(17, 194);
            this.lblprom.Name = "lblprom";
            this.lblprom.Size = new System.Drawing.Size(67, 17);
            this.lblprom.TabIndex = 5;
            this.lblprom.Text = "promedio";
            // 
            // lblcarr
            // 
            this.lblcarr.AutoSize = true;
            this.lblcarr.Location = new System.Drawing.Point(17, 165);
            this.lblcarr.Name = "lblcarr";
            this.lblcarr.Size = new System.Drawing.Size(54, 17);
            this.lblcarr.TabIndex = 4;
            this.lblcarr.Text = "carrera";
            // 
            // lblam
            // 
            this.lblam.AutoSize = true;
            this.lblam.Location = new System.Drawing.Point(17, 129);
            this.lblam.Name = "lblam";
            this.lblam.Size = new System.Drawing.Size(113, 17);
            this.lblam.TabIndex = 3;
            this.lblam.Text = "apellido materno";
            // 
            // txtrut
            // 
            this.txtrut.Location = new System.Drawing.Point(136, 34);
            this.txtrut.Name = "txtrut";
            this.txtrut.Size = new System.Drawing.Size(100, 22);
            this.txtrut.TabIndex = 6;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(136, 67);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 22);
            this.txtnom.TabIndex = 7;
            // 
            // txtapp
            // 
            this.txtapp.Location = new System.Drawing.Point(136, 99);
            this.txtapp.Name = "txtapp";
            this.txtapp.Size = new System.Drawing.Size(100, 22);
            this.txtapp.TabIndex = 8;
            // 
            // txtapm
            // 
            this.txtapm.Location = new System.Drawing.Point(136, 127);
            this.txtapm.Name = "txtapm";
            this.txtapm.Size = new System.Drawing.Size(100, 22);
            this.txtapm.TabIndex = 9;
            // 
            // txtprom
            // 
            this.txtprom.Location = new System.Drawing.Point(136, 189);
            this.txtprom.Name = "txtprom";
            this.txtprom.Size = new System.Drawing.Size(100, 22);
            this.txtprom.TabIndex = 11;
            // 
            // txtdig
            // 
            this.txtdig.Location = new System.Drawing.Point(251, 34);
            this.txtdig.Name = "txtdig";
            this.txtdig.Size = new System.Drawing.Size(22, 22);
            this.txtdig.TabIndex = 12;
            // 
            // btnelim
            // 
            this.btnelim.Location = new System.Drawing.Point(51, 287);
            this.btnelim.Name = "btnelim";
            this.btnelim.Size = new System.Drawing.Size(126, 23);
            this.btnelim.TabIndex = 4;
            this.btnelim.Text = "eliminar alumno";
            this.btnelim.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(208, 287);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(124, 23);
            this.btnbuscar.TabIndex = 5;
            this.btnbuscar.Text = "buscar alumno";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(360, 286);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(132, 23);
            this.btnguardar.TabIndex = 6;
            this.btnguardar.Text = "guardar alumno";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbcarrera
            // 
            this.cmbcarrera.FormattingEnabled = true;
            this.cmbcarrera.Items.AddRange(new object[] {
            "informatica",
            "telecomunicaciones",
            "arquitectura",
            "medicina",
            "derecho",
            "periodismo"});
            this.cmbcarrera.Location = new System.Drawing.Point(136, 156);
            this.cmbcarrera.Name = "cmbcarrera";
            this.cmbcarrera.Size = new System.Drawing.Size(121, 24);
            this.cmbcarrera.TabIndex = 13;
            // 
            // mantenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 329);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnelim);
            this.Name = "mantenedor";
            this.Text = "mantenedor";
            this.Load += new System.EventHandler(this.mantenedor_Load);
            this.Controls.SetChildIndex(this.btnelim, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lbl1, 0);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.btnbuscar, 0);
            this.Controls.SetChildIndex(this.btnguardar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbcarrera;
        private System.Windows.Forms.TextBox txtdig;
        private System.Windows.Forms.TextBox txtprom;
        private System.Windows.Forms.TextBox txtapm;
        private System.Windows.Forms.TextBox txtapp;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtrut;
        private System.Windows.Forms.Label lblprom;
        private System.Windows.Forms.Label lblcarr;
        private System.Windows.Forms.Label lblam;
        private System.Windows.Forms.Label lblapp;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lblrut;
        private System.Windows.Forms.Button btnelim;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}