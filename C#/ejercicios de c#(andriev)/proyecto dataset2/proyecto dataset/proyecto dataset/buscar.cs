﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proyecto_dataset
{
    public partial class buscar : Form
    {
        public buscar()
        {
            InitializeComponent();
        }

        private void aLUMNOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aLUMNOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }

        private void buscar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.ALUMNO' Puede moverla o quitarla según sea necesario.
            this.aLUMNOTableAdapter.Fill(this.dataSet2.ALUMNO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 0)
            {
                this.aLUMNOBindingSource.Filter = "rut='"+
                                                textBox1.Text.Trim()
                                                    +"'";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        this.aLUMNOBindingSource.Filter="";
        }
    }
}
