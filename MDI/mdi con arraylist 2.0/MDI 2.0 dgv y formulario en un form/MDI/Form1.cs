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
        

       // Perteneciente a la clase Doctor, pero todavia no se utiliza
     

       
       

    // Pertenece al formulario Doctores. 
        Doctores dr;
    
    // ldr Pertenece al formulario ListaDr. permitira usar los metodos y propiedades.
     
        

        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // todavia no lo usamos
          
            // instanciamos el objeto a la clase LsitaDr.
          

// al momento de cargarse el form1 aparecera el formulario para registrar un doctor llamado Doctores.
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


        private void mostrarDoctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

     
       

          

        }
        


    }
}
