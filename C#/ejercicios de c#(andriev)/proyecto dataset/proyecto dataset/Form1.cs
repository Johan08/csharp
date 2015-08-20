using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyecto_dataset
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aLUMNOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aLUMNOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.ALUMNO' Puede moverla o quitarla según sea necesario.
            //this.aLUMNOTableAdapter.Fill(this.dataSet2.ALUMNO);
            this.aLUMNOBindingSource.AddNew();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            aLUMNOBindingNavigatorSaveItem_Click(sender, e);
            MessageBox.Show("datos ingresados correctamente");
            this.Close();

        }
    }
}
