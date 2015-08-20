using System;

//using System.Collections.Generic;

// para usar arrayList

using System.Collections;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDI
{
    public partial class ListaDres : Form
    {

         VariablesDr ob = new VariablesDr(VariablesDr.Nombre, VariablesDr.Apellido, VariablesDr.Especialidad);
        // VariablesDr ob = new VariablesDr();
        // creamos nuestro obList de tipo ArrayLIst
        ArrayList doctores = new ArrayList();

        public ListaDres()
        {
            InitializeComponent();
        }

        private void bmostrar_Click(object sender, EventArgs e)
        {


            dgDatos.Rows.Add(ob.getNombre(),ob.getApellido(),ob.getEspecialidad());



            /*
            textBox1.Text = ob.getNombre();
            //textBox1.Text = VariablesDr.Nombre.ToString();
            textBox2.Text = ob.getApellido();
            textBox3.Text = ob.getEspecialidad();

            doctores.Add(new VariablesDr(textBox1.Text, textBox2.Text,textBox3.Text));

            */
        }

        public void mostrarAlumno()
        {


            foreach(VariablesDr obj in doctores)
            {


              

            }



        }//FIN FUNCION mostrarAlumno()
       
        /////////////////////////////////////////////////////////////////////

        public static void Limpiar(Form ofrm)
        {
            foreach (Control oControls in ofrm.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = ""; // Eliminar el texto del TextBox
                }
            }

        }


        private void bLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar(this);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {


            mostrarAlumno();

        }

      
       /////////////////////////////////////////////////////////////////////            

        }


       
    }

