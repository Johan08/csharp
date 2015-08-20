using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormulariosVarios
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void b_uvnumeros_Click(object sender, EventArgs e)
        {

            // de esta forma se abre otro formulario

            FormValidaNum frm = new FormValidaNum();

            frm.Show();

        }

        private void b_uvletras_Click(object sender, EventArgs e)
        {

            // de esta forma se abre otro formulario

            FormValidaLetras frm = new FormValidaLetras();

            frm.Show();

        }

        private void b_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
