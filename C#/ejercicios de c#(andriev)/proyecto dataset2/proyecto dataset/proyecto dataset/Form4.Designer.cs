﻿namespace proyecto_dataset
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label rUTLabel;
            System.Windows.Forms.Label nOMBRELabel;
            System.Windows.Forms.Label aPE_PATLabel;
            System.Windows.Forms.Label aPE_MATLabel;
            System.Windows.Forms.Label cARRERALabel;
            System.Windows.Forms.Label nOTA1Label;
            System.Windows.Forms.Label nOTA2Label;
            System.Windows.Forms.Label nOTA3Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataSet2 = new proyecto_dataset.DataSet2();
            this.aLUMNOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLUMNOTableAdapter = new proyecto_dataset.DataSet2TableAdapters.ALUMNOTableAdapter();
            this.tableAdapterManager = new proyecto_dataset.DataSet2TableAdapters.TableAdapterManager();
            this.aLUMNOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aLUMNOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rUTTextBox = new System.Windows.Forms.TextBox();
            this.nOMBRETextBox = new System.Windows.Forms.TextBox();
            this.aPE_PATTextBox = new System.Windows.Forms.TextBox();
            this.aPE_MATTextBox = new System.Windows.Forms.TextBox();
            this.cARRERATextBox = new System.Windows.Forms.TextBox();
            this.nOTA1TextBox = new System.Windows.Forms.TextBox();
            this.nOTA2TextBox = new System.Windows.Forms.TextBox();
            this.nOTA3TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            rUTLabel = new System.Windows.Forms.Label();
            nOMBRELabel = new System.Windows.Forms.Label();
            aPE_PATLabel = new System.Windows.Forms.Label();
            aPE_MATLabel = new System.Windows.Forms.Label();
            cARRERALabel = new System.Windows.Forms.Label();
            nOTA1Label = new System.Windows.Forms.Label();
            nOTA2Label = new System.Windows.Forms.Label();
            nOTA3Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOBindingNavigator)).BeginInit();
            this.aLUMNOBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // rUTLabel
            // 
            rUTLabel.AutoSize = true;
            rUTLabel.Location = new System.Drawing.Point(184, 92);
            rUTLabel.Name = "rUTLabel";
            rUTLabel.Size = new System.Drawing.Size(33, 13);
            rUTLabel.TabIndex = 1;
            rUTLabel.Text = "RUT:";
            // 
            // nOMBRELabel
            // 
            nOMBRELabel.AutoSize = true;
            nOMBRELabel.Location = new System.Drawing.Point(184, 118);
            nOMBRELabel.Name = "nOMBRELabel";
            nOMBRELabel.Size = new System.Drawing.Size(57, 13);
            nOMBRELabel.TabIndex = 3;
            nOMBRELabel.Text = "NOMBRE:";
            // 
            // aPE_PATLabel
            // 
            aPE_PATLabel.AutoSize = true;
            aPE_PATLabel.Location = new System.Drawing.Point(184, 144);
            aPE_PATLabel.Name = "aPE_PATLabel";
            aPE_PATLabel.Size = new System.Drawing.Size(55, 13);
            aPE_PATLabel.TabIndex = 5;
            aPE_PATLabel.Text = "APE PAT:";
            // 
            // aPE_MATLabel
            // 
            aPE_MATLabel.AutoSize = true;
            aPE_MATLabel.Location = new System.Drawing.Point(184, 170);
            aPE_MATLabel.Name = "aPE_MATLabel";
            aPE_MATLabel.Size = new System.Drawing.Size(57, 13);
            aPE_MATLabel.TabIndex = 7;
            aPE_MATLabel.Text = "APE MAT:";
            // 
            // cARRERALabel
            // 
            cARRERALabel.AutoSize = true;
            cARRERALabel.Location = new System.Drawing.Point(184, 196);
            cARRERALabel.Name = "cARRERALabel";
            cARRERALabel.Size = new System.Drawing.Size(62, 13);
            cARRERALabel.TabIndex = 9;
            cARRERALabel.Text = "CARRERA:";
            // 
            // nOTA1Label
            // 
            nOTA1Label.AutoSize = true;
            nOTA1Label.Location = new System.Drawing.Point(184, 222);
            nOTA1Label.Name = "nOTA1Label";
            nOTA1Label.Size = new System.Drawing.Size(46, 13);
            nOTA1Label.TabIndex = 11;
            nOTA1Label.Text = "NOTA1:";
            // 
            // nOTA2Label
            // 
            nOTA2Label.AutoSize = true;
            nOTA2Label.Location = new System.Drawing.Point(184, 248);
            nOTA2Label.Name = "nOTA2Label";
            nOTA2Label.Size = new System.Drawing.Size(46, 13);
            nOTA2Label.TabIndex = 13;
            nOTA2Label.Text = "NOTA2:";
            // 
            // nOTA3Label
            // 
            nOTA3Label.AutoSize = true;
            nOTA3Label.Location = new System.Drawing.Point(184, 274);
            nOTA3Label.Name = "nOTA3Label";
            nOTA3Label.Size = new System.Drawing.Size(46, 13);
            nOTA3Label.TabIndex = 15;
            nOTA3Label.Text = "NOTA3:";
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLUMNOBindingSource
            // 
            this.aLUMNOBindingSource.DataMember = "ALUMNO";
            this.aLUMNOBindingSource.DataSource = this.dataSet2;
            // 
            // aLUMNOTableAdapter
            // 
            this.aLUMNOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ALUMNOTableAdapter = this.aLUMNOTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = proyecto_dataset.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aLUMNOBindingNavigator
            // 
            this.aLUMNOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aLUMNOBindingNavigator.BindingSource = this.aLUMNOBindingSource;
            this.aLUMNOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aLUMNOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aLUMNOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.aLUMNOBindingNavigatorSaveItem});
            this.aLUMNOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aLUMNOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aLUMNOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aLUMNOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aLUMNOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aLUMNOBindingNavigator.Name = "aLUMNOBindingNavigator";
            this.aLUMNOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aLUMNOBindingNavigator.Size = new System.Drawing.Size(866, 25);
            this.aLUMNOBindingNavigator.TabIndex = 0;
            this.aLUMNOBindingNavigator.Text = "bindingNavigator1";
            this.aLUMNOBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // aLUMNOBindingNavigatorSaveItem
            // 
            this.aLUMNOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aLUMNOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aLUMNOBindingNavigatorSaveItem.Image")));
            this.aLUMNOBindingNavigatorSaveItem.Name = "aLUMNOBindingNavigatorSaveItem";
            this.aLUMNOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aLUMNOBindingNavigatorSaveItem.Text = "Guardar datos";
            this.aLUMNOBindingNavigatorSaveItem.Click += new System.EventHandler(this.aLUMNOBindingNavigatorSaveItem_Click);
            // 
            // rUTTextBox
            // 
            this.rUTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOBindingSource, "RUT", true));
            this.rUTTextBox.Location = new System.Drawing.Point(252, 89);
            this.rUTTextBox.Name = "rUTTextBox";
            this.rUTTextBox.Size = new System.Drawing.Size(100, 20);
            this.rUTTextBox.TabIndex = 2;
            // 
            // nOMBRETextBox
            // 
            this.nOMBRETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOBindingSource, "NOMBRE", true));
            this.nOMBRETextBox.Location = new System.Drawing.Point(252, 115);
            this.nOMBRETextBox.Name = "nOMBRETextBox";
            this.nOMBRETextBox.Size = new System.Drawing.Size(100, 20);
            this.nOMBRETextBox.TabIndex = 4;
            // 
            // aPE_PATTextBox
            // 
            this.aPE_PATTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOBindingSource, "APE_PAT", true));
            this.aPE_PATTextBox.Location = new System.Drawing.Point(252, 141);
            this.aPE_PATTextBox.Name = "aPE_PATTextBox";
            this.aPE_PATTextBox.Size = new System.Drawing.Size(100, 20);
            this.aPE_PATTextBox.TabIndex = 6;
            // 
            // aPE_MATTextBox
            // 
            this.aPE_MATTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOBindingSource, "APE_MAT", true));
            this.aPE_MATTextBox.Location = new System.Drawing.Point(252, 167);
            this.aPE_MATTextBox.Name = "aPE_MATTextBox";
            this.aPE_MATTextBox.Size = new System.Drawing.Size(100, 20);
            this.aPE_MATTextBox.TabIndex = 8;
            // 
            // cARRERATextBox
            // 
            this.cARRERATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOBindingSource, "CARRERA", true));
            this.cARRERATextBox.Location = new System.Drawing.Point(252, 193);
            this.cARRERATextBox.Name = "cARRERATextBox";
            this.cARRERATextBox.Size = new System.Drawing.Size(100, 20);
            this.cARRERATextBox.TabIndex = 10;
            // 
            // nOTA1TextBox
            // 
            this.nOTA1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOBindingSource, "NOTA1", true));
            this.nOTA1TextBox.Location = new System.Drawing.Point(252, 219);
            this.nOTA1TextBox.Name = "nOTA1TextBox";
            this.nOTA1TextBox.Size = new System.Drawing.Size(100, 20);
            this.nOTA1TextBox.TabIndex = 12;
            // 
            // nOTA2TextBox
            // 
            this.nOTA2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOBindingSource, "NOTA2", true));
            this.nOTA2TextBox.Location = new System.Drawing.Point(252, 245);
            this.nOTA2TextBox.Name = "nOTA2TextBox";
            this.nOTA2TextBox.Size = new System.Drawing.Size(100, 20);
            this.nOTA2TextBox.TabIndex = 14;
            // 
            // nOTA3TextBox
            // 
            this.nOTA3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLUMNOBindingSource, "NOTA3", true));
            this.nOTA3TextBox.Location = new System.Drawing.Point(252, 271);
            this.nOTA3TextBox.Name = "nOTA3TextBox";
            this.nOTA3TextBox.Size = new System.Drawing.Size(100, 20);
            this.nOTA3TextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(520, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(520, 248);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 394);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(rUTLabel);
            this.Controls.Add(this.rUTTextBox);
            this.Controls.Add(nOMBRELabel);
            this.Controls.Add(this.nOMBRETextBox);
            this.Controls.Add(aPE_PATLabel);
            this.Controls.Add(this.aPE_PATTextBox);
            this.Controls.Add(aPE_MATLabel);
            this.Controls.Add(this.aPE_MATTextBox);
            this.Controls.Add(cARRERALabel);
            this.Controls.Add(this.cARRERATextBox);
            this.Controls.Add(nOTA1Label);
            this.Controls.Add(this.nOTA1TextBox);
            this.Controls.Add(nOTA2Label);
            this.Controls.Add(this.nOTA2TextBox);
            this.Controls.Add(nOTA3Label);
            this.Controls.Add(this.nOTA3TextBox);
            this.Controls.Add(this.aLUMNOBindingNavigator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOBindingNavigator)).EndInit();
            this.aLUMNOBindingNavigator.ResumeLayout(false);
            this.aLUMNOBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource aLUMNOBindingSource;
        private DataSet2TableAdapters.ALUMNOTableAdapter aLUMNOTableAdapter;
        private DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aLUMNOBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton aLUMNOBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox rUTTextBox;
        private System.Windows.Forms.TextBox nOMBRETextBox;
        private System.Windows.Forms.TextBox aPE_PATTextBox;
        private System.Windows.Forms.TextBox aPE_MATTextBox;
        private System.Windows.Forms.TextBox cARRERATextBox;
        private System.Windows.Forms.TextBox nOTA1TextBox;
        private System.Windows.Forms.TextBox nOTA2TextBox;
        private System.Windows.Forms.TextBox nOTA3TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}