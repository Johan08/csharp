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
    public partial class operacion : patron
    {
        int validarTextBox()
        {
            int flag = 0;
            if (textBoxv1.Text == "0" || textBoxv1.Text.Trim().Length < 1)
            {
                flag += 1;
                errorProvider1.SetError(textBoxv1, "ingrese valor distinto a cero");
            }
            else
            {
                flag = 0;
                errorProvider1.SetError(textBoxv1, "");
            }
            if (textBoxv2.Text == "0" || textBoxv2.Text.Trim().Length < 1)
            {
                flag += 1;
                errorProvider1.SetError(textBoxv2, "ingrese valor distinto a cero");
            }
            else
            {
                flag = 0;
                errorProvider1.SetError(textBoxv2, "");
            }
            return flag;

        }
        public operacion()
        {
            InitializeComponent();
        }

        private void operacion_Load(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            int v1 = 0, v2 = 0, res = 0;
            try 
            {
                if (validarTextBox () ==0)
                {
                    v1 = Convert.ToInt32(textBoxv1.Text);
                    v2 = Convert.ToInt32(textBoxv2.Text);
                    // 2 formas de tomar el valor de la combobox
                    // tomaremos el signo que pusimos para elegir
                    // en verde estara la forma para tomar la posicion donde esta el signo dentro de la combobox
                    string ope = cmboperador.Text; // int ope = cmboperador.SelectedIndex;
                    switch (ope)
                    {
                        case ("+"): res = v1 + v2; //case 0:
                            break;
                        case ("-"): res = v1 - v2; //case 1:
                            break;
                        case ("*"): res = v1 * v2; //case 2:
                            break;
                        case ("/"): res = v1 / v2; //case 3:
                            break;
                        case ("&"): res = v1 % v2; //case 4:
                            break;
                        default:
                            throw new Exception("error: debe seleccionar un operador");
                    }
                    textBoxres.Text = res.ToString("###,###,##");
                }

            }
            catch(Exception ex)
            {MessageBox.Show(ex.Message,"error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}
