using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void b_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_dividir_Click(object sender, EventArgs e)
        {

            int v1 = 0;
            int v2 = 0;
            int res = 0;
            try
            {

                bool convert = int.TryParse(txt1.Text, out v1);

                if (convert == true)
                {

                    v1 = Convert.ToInt32(txt1.Text);

                    v2 = Convert.ToInt32(txt2.Text);

                    res = v1 / v2;

                    MessageBox.Show("Su división es: " + res);
                }

                else
                {
                    MessageBox.Show("Ingrese valores, no letras");
                }
            }


            catch
            {
                MessageBox.Show("Ingrese valores");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_sumar_Click(object sender, EventArgs e)
        {

           

            int v1 = 0;
            int v2 = 0;
            int res = 0;
            try
            {
                bool convert = int.TryParse(txt1.Text, out v1);

                if (convert == true)
                {

                    v1 = Convert.ToInt32(txt1.Text);

                    v2 = Convert.ToInt32(txt2.Text);

                    res = v1 + v2;

                    MessageBox.Show("Su suma es: " + res);
                }

                else
                {
                    MessageBox.Show("Ingrese valores, no letras");
                }
             }
            catch (Exception ex)
            {

                MessageBox.Show("Ingrese valores");
            
            }

        }

        private void b_restar_Click(object sender, EventArgs e)
        {

            int v1 = 0;
            int v2 = 0;
            int res = 0;
            try
            {
                bool convert = int.TryParse(txt1.Text, out v1);

                if (convert == true)
                {

                    v1 = Convert.ToInt32(txt1.Text);

                    v2 = Convert.ToInt32(txt2.Text);

                    res = v1 - v2;

                    MessageBox.Show("Su resta es: " + res);
                }

                else
                {
                    MessageBox.Show("Ingrese valores, no letras");
                }
            }
            catch
            {
                MessageBox.Show("Ingrese valores");
            }


        }

        private void b_multiplicar_Click(object sender, EventArgs e)
        {
            int v1 = 0;
            int v2 = 0;
            int res = 0;
            try
            {

                bool convert = int.TryParse(txt1.Text, out v1);

                if (convert == true)
                {

                    v1 = Convert.ToInt32(txt1.Text);

                    v2 = Convert.ToInt32(txt2.Text);

                    res = v1 * v2;

                    MessageBox.Show("Su multiplicacion es: " + res);
                }

                else
                {
                    MessageBox.Show("Ingrese valores, no letras");
                }
            }
            catch
            {
                MessageBox.Show("Ingrese valores");
            }
        }

       
    }
}
