using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace DatabaseAssignment11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String strConn = "Data Source=cissql;Initial Catalog=CPSC285S23B;Integrated Security=True";

            SqlConnection cnnSample;
            SqlCommand cmdGetData;
            DataTable tbl = new DataTable();

            String strSQL;


            strSQL = $@"select Class.Date, StartTime, Worker.Name 
                                from Class inner join Client C on C.Client_ID = Class.Client_ID inner join Worker on Class.Staff_ID = Worker.Staff_ID
                                where C.Client_ID = '{client_IDTextBox.Text}'";
            MessageBox.Show(strSQL);

            try
            {
                cnnSample = new SqlConnection(strConn);
                cnnSample.Open();

                cmdGetData = new SqlCommand();

                cmdGetData.Connection = cnnSample;
                cmdGetData.CommandType = CommandType.Text;
                cmdGetData.CommandText = strSQL;

                tbl.Load(cmdGetData.ExecuteReader());
                classDataGridView.DataSource = tbl.DefaultView;
                cnnSample.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cPSC285S23BDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cPSC285S23BDataSet.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.cPSC285S23BDataSet.Class);
            // TODO: This line of code loads data into the 'cPSC285S23BDataSet.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.cPSC285S23BDataSet.Class);
            // TODO: This line of code loads data into the 'cPSC285S23BDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.cPSC285S23BDataSet.Client);


        }

       
    }
}
