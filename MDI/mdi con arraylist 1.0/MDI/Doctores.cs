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
    public partial class Doctores : Form
    {      
       

        public Doctores()
        {
            InitializeComponent();
         
        }

   
        private void b3_Click(object sender, EventArgs e)
        {
            this.Close();
      
        }

        public void Limpiar()
        {
            txt1.Text = "";
            txt2.Text = "";
            cbb.SelectedItem = null;

        }

        private void b2_Click(object sender, EventArgs e)
        {

            Limpiar();

        }

        public void LimpiarN()
        {
            txt1.Text = "";
            

        }

        public void LimpiarA()
        {
           
            txt2.Text = "";


        }

        public void LimpiarE()
        {

            cbb.SelectedItem = null;


        }


        public void agregaDres(Doctor d)
        {

            char a, b;

            string valida = txt1.Text;
            string valida2 = txt2.Text;

            int i, j;

            bool ad = false;
            bool aa = false;

     do
     {
            for (i = 0; i < valida.Length; i++)
            {
                a = valida[i];
                if (!char.IsLetter(a))
                {
                    ad = true;
                    i += valida.Length;
                }

                else
                {
                    ad = false;
                }
            }

            for (j = 0; j < valida2.Length; j++)
            {
                b = valida2[j];

                if (!char.IsLetter(b))
                {
                    aa = true;
                    j += valida2.Length;
                }

                else
                {
                    aa = false;

                }

            }

        } while (i < valida.Length && j < valida2.Length);

     if (ad == true || aa == true)
     {
         MessageBox.Show("Usted a ingresado caracteres no permitidos. Intente nuevamente. ");
         txt1.Clear();
         txt2.Clear();
         cbb.Text = "";
     }


     else if (txt1.Text == "" || txt2.Text == "" || cbb.Text == "")
     {

         MessageBox.Show("Ingrese los campos requeridos...");

     }

     else if (ad == false && aa == false)
     {
         
         d.setNombre(txt1.Text);
         d.setApellido(txt2.Text);
         d.setEspecialidad(cbb.Text);

         MessageBox.Show("Doctor Agregado Correctamente");

         txt1.Text = "";
         txt2.Text = "";
         cbb.Text = "";

     }
    }


 
   
    }
}
