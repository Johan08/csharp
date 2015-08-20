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
    public partial class Doctores : Form
    {      
         // ListarDr obListi = new ListarDr();

        ArrayList dtrs = new ArrayList();
        // ListarDr dg = new ListarDr();
        

       Doctor obDoctor = new Doctor();


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



        // en el momento de que pulsemos aceptar(agregara el nombre de la persona)
        private void b1_Click(object sender, EventArgs e)
        {

            obDoctor.setNombre(txt1.Text);
            obDoctor.setApellido(txt2.Text);
            obDoctor.setEspecialidad(cbb.Text);

            
            //dtrs.Add(new Doctor(txt1.Text,txt2.Text,cbb.Text));
            dtrs.Add(new Doctor(obDoctor.getNombre(), obDoctor.getApellido(), obDoctor.getEspecialidad()));
            //dgv.DataSource = dtrs;

         // ldr.ShowDialog();   
            MessageBox.Show("Ingreso De Datos!");
            txt1.Text = "";
            txt2.Text = "";
            cbb.Text =  "";
        }

        private void b4_Click(object sender, EventArgs e)
        {

            //dgv.Rows.Add(obDoctor.getNombre(), obDoctor.getApellido(), obDoctor.getEspecialidad());

              foreach (Doctor obj in dtrs)           
            {

                dgv.Rows.Add(obj.getNombre(), obj.getApellido(), obj.getEspecialidad());
                
            }

        }


      
    }
}
