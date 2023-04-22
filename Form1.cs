﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseAssignment11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cPSC285S23BDataSet);
        }

        private void workerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cPSC285S23BDataSet);

        }

        private void workerBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.workerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cPSC285S23BDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.workerTableAdapter.Fill(this.cPSC285S23BDataSet.Worker);
                // TODO: This line of code loads data into the 'cPSC285S23BDataSet.Class' table. You can move, or remove it, as needed.
                this.classTableAdapter.Fill(this.cPSC285S23BDataSet.Class);
                // TODO: This line of code loads data into the 'cPSC285S23BDataSet.Client' table. You can move, or remove it, as needed.
                this.clientTableAdapter.Fill(this.cPSC285S23BDataSet.Client);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbCurrentDay_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
