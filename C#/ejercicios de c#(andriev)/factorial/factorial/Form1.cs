using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcularFactorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            factorial obj = new factorial();
            obj.MdiParent = this;
            obj.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fecha.Text = DateTime.Now.ToString("ddd, dd - MM - yyy");
            hora.Text = DateTime.Now.ToString("HH.mm.ss");
        }

        private void verificadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rut obj = new rut();
            obj.MdiParent = this;
            obj.Show();
        }

        private void calcuadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operacion obj = new operacion();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
