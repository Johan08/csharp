using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDI
{
    public partial class Form1 : Form
    {

        Doctores dr;

        ListaDres ldr;

        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

             dr = new Doctores();

            dr.MdiParent = this; // quien es su padre

            dr.Show();

            dr.WindowState = FormWindowState.Maximized;

        }
    

        private void doctoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            dr = new Doctores();

            dr.MdiParent = this; // quien es su padre

            dr.Show();

            dr.WindowState = FormWindowState.Maximized;

        }

        private void limpiarNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
          
            dr.LimpiarN();
           

        }

        private void limpiarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dr.Limpiar();
            
        }

        private void limpiarApellidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dr.LimpiarA();

        }


        private void limpiarEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dr.LimpiarE();
        }

        private void listaDoctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ldr = new ListaDres();
            ldr.MdiParent = this;
            ldr.Show();
            ldr.WindowState = FormWindowState.Maximized;
        }



       
    }
}
