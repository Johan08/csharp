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
    public partial class factorial : Form
    {
        int resul=1;
        public factorial()
        {
            InitializeComponent();
        }

        private void btnfac_Click(object sender, EventArgs e)
        {
            int val, i ;
            try
            {
                val = Convert.ToInt32(txt1.Text);
                for (i = 1; i <= val; i++)
                {
                    resul *= i;
                }
                txt2.Text = Convert.ToString(resul);
                resul = 1;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }


        }
    }
}
