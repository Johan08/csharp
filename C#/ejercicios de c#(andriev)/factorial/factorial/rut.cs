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
    public partial class rut : patron
    {
        public rut()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int dig, a=3,sum=0;
                        
            try
            {
                string rut = txt1.Text;
                int[] num = new int[rut.Length];

                for (int i = 0; i < num.Length; i++)
                {
                    num[i] = Convert.ToInt32(Convert.ToString(rut[i]));
                }
                
                for (int i = 0; i < num.Length; i++)
                {

                    sum += (num[i] * a);
                    a--;
                    if (a == 1)
                        a = 7;
                    
                }
                
                dig = 11 - (sum % 11);

                if (dig < 10)
                    txt2.Text = Convert.ToString(dig);
                else if
                    (dig == 10)
                    txt2.Text = ("k");
                else
                    txt2.Text = ("0");

               


                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void rut_Load(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

        }
    }
}
