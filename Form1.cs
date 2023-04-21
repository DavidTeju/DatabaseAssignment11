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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbCurrentDay_CheckedChanged(object sender, EventArgs e)
        {
            String strConn = "Data Source=cissql;Initial Catalog=CPSC285S23B;Integrated Security=True";

            SqlConnection cnnSample;
            SqlCommand cmdGetData;
            DataTable tbl = new DataTable();

            String strSQL;
            string todayDate = DateTime.Now.ToString("MM/dd/yyyy");

            strSQL = $@"select Class.Date, StartTime, C.Name 
                                from Class inner join Client C on C.Client_ID = Class.Client_ID inner join Worker on Class.Staff_ID = Worker.Staff_ID
                                where Date = '{todayDate}' and Class.Staff_ID = '{staff_IDTextBox.Text}'";
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
                dataGridView1.DataSource = tbl.DefaultView;
                cnnSample.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbNextWeek_CheckedChanged(object sender, EventArgs e)
        {
            String strConn = "Data Source=cissql;Initial Catalog=CPSC285S23B;Integrated Security=True";

            SqlConnection cnnSample;
            SqlCommand cmdGetData;
            DataTable tbl = new DataTable();

            String strSQL;
            DateTime todayDate = DateTime.Now;
            DateTime weekDate = todayDate.AddDays(7);

            strSQL = $@"select Class.Date, StartTime, C.Name 
                                from Class inner join Client C on C.Client_ID = Class.Client_ID inner join Worker on Class.Staff_ID = Worker.Staff_ID
                                where Date BETWEEN '{todayDate}' and '{weekDate}' and Class.Staff_ID = '{staff_IDTextBox.Text}'";
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
                dataGridView1.DataSource = tbl.DefaultView;
                cnnSample.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbNextMonth_CheckedChanged(object sender, EventArgs e)
        {
            String strConn = "Data Source=cissql;Initial Catalog=CPSC285S23B;Integrated Security=True";

            SqlConnection cnnSample;
            SqlCommand cmdGetData;
            DataTable tbl = new DataTable();

            String strSQL;
            DateTime todayDate = DateTime.Now;
            DateTime monthDate = todayDate.AddDays(30);

            strSQL = $@"select Class.Date, StartTime, C.Name 
                                from Class inner join Client C on C.Client_ID = Class.Client_ID inner join Worker on Class.Staff_ID = Worker.Staff_ID
                                where Date BETWEEN '{todayDate}' and '{monthDate}' and Class.Staff_ID = '{staff_IDTextBox.Text}'";
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
                dataGridView1.DataSource = tbl.DefaultView;
                cnnSample.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
