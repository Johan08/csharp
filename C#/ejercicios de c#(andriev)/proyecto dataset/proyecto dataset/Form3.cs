using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyecto_dataset
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void aLUMNOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aLUMNOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.ALUMNO' Puede moverla o quitarla según sea necesario.
            this.aLUMNOTableAdapter.Fill(this.dataSet2.ALUMNO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.aLUMNOBindingSource.Filter = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.aLUMNOBindingSource.Filter = "rut='"+
                                            this.comboBox1.SelectedValue
                                                + "'";
        }
    }
}
