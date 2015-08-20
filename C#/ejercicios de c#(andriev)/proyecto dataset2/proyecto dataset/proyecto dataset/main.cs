using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyecto_dataset
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.MdiParent = this;
            obj.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscar obj = new buscar();
            obj.MdiParent = this;
            obj.Show();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.MdiParent = this;
            obj.Show();
        }

        private void insertarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.MdiParent = this;
            obj.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
