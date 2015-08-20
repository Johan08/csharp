using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyecto_dataset
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void aLUMNOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aLUMNOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.ALUMNO' Puede moverla o quitarla según sea necesario.
            this.aLUMNOTableAdapter.Fill(this.dataSet2.ALUMNO);
            this.aLUMNOBindingSource.Filter = "rut='x-x'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.aLUMNOBindingSource.Filter = "rut'" + this.rUTTextBox.Text.Trim() + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.aLUMNOTableAdapter.DeleteRutAlumno(this.rUTTextBox.Text.Trim());
            this.tableAdapterManager.UpdateAll(this.dataSet2);
            this.aLUMNOTableAdapter.Fill(this.dataSet2.ALUMNO);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.aLUMNOBindingSource.Filter = "rut+'x-x'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.aLUMNOTableAdapter.UpdateAlumno(this.rUTTextBox.Text.Trim(),this.nOMBRETextBox.Text.Trim();
            //this.tableAdapterManager.UpdateAll(this.dataSet2);
            //this.aLUMNOTableAdapter.Fill(this.dataSet2.ALUMNO);
        }
    }
}
