using System;
using System.Collections;
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

      

        ArrayList dtrs = new ArrayList();       

        Doctor d;

        VerDoctores vd;
     
        Doctores dr;
        
       

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


      /*

        private void doctoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {



            dr = new Doctores();

            dr.MdiParent = this; // quien es su padre

            dr.Show();

            dr.WindowState = FormWindowState.Maximized;

        }
        */
       
        private void limpiarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dr.Limpiar();
            
        }


        private void limpiarNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {


            dr.LimpiarN();


        }

        private void limpiarApellidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dr.LimpiarA();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dr.LimpiarE();
        }


        private void verDoctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

         
            //-----------------------
            try
            {
                vd = new VerDoctores(d.getNombre(), d.getApellido(), d.getEspecialidad());

                vd.MdiParent = this; // quien es su padre

                vd.Show();

                vd.WindowState = FormWindowState.Maximized;
            }

            catch(Exception)
            {
                MessageBox.Show("Ingrese Datos para continuar");

            }
        //---------------------------------------------------------------


            foreach (Doctor obj in dtrs)
            {
                vd.dgv2.Rows.Add(obj.getNombre(), obj.getApellido(), obj.getEspecialidad());
            }
          

        }// FIn verDoctores


        private void agregaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            d = new Doctor();

            dr.agregaDres(d);

            dtrs.Add(new Doctor(d.getNombre(), d.getApellido(), d.getEspecialidad()));

            
        }

        private void doctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dr = new Doctores();

            dr.MdiParent = this; // quien es su padre

            dr.Show();

            dr.WindowState = FormWindowState.Maximized;

        }



    }
}
