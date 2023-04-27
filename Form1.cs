using System;
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
        private string _strConn = "Data Source=cissql;Initial Catalog=CPSC285S23B;Integrated Security=True";

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

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.workerTableAdapter.Fill(this.cPSC285S23BDataSet.Worker);
                this.clientTableAdapter.Fill(this.cPSC285S23BDataSet.Client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            rbCurrentDay.Checked = true;
        }

       private void UpdateSchedule()
        {
            var rbToInt = new Dictionary<RadioButton, int>
            {
                { rbCurrentDay, 0 },
                { rbNextWeek, 7 },
                { rbNextMonth, 30 }
            };

            int days = 0;

            foreach (Control control in schedulePanel.Controls)
            {
                if (control is RadioButton button && button.Checked)
                {
                    days = rbToInt[button];
                    break;
                }
            }
            SqlConnection cnnSample;
            SqlCommand cmdGetData;
            DataTable tbl = new DataTable();

            
            String todayDate = DateTime.Now.ToShortDateString();
            String laterDate = DateTime.Now.AddDays(days).ToShortDateString();
          
            string strSql = "select Class.Date, Class.StartTime, C.Name " +
                             " from Class inner join Client C on C.Client_ID = Class.Client_ID "+
                              " where Date BETWEEN '" + todayDate +  "' and '" + laterDate + "' and Class.Staff_ID = '" + staff_IDTextBox.Text + "'";
          
            try
            {
                cnnSample = new SqlConnection(_strConn);
                cnnSample.Open();

                cmdGetData = new SqlCommand();

                cmdGetData.Connection = cnnSample;
                cmdGetData.CommandType = CommandType.Text;
                cmdGetData.CommandText = strSql;

                tbl.Load(cmdGetData.ExecuteReader());
                scheduleDataGridView.DataSource = tbl.DefaultView; 

                cnnSample.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        

        private void UpdateClassGrid()
        {
            SqlConnection cnnSample;
            SqlCommand cmdGetData;
            DataTable tbl = new DataTable();

            string strSql = "select Class.Date, Class.StartTime, Worker.Name " +
                              " from Class inner join Client C on C.Client_ID = Class.Client_ID inner join Worker on Class.Staff_ID = Worker.Staff_ID " +
                              "  where C.Client_ID = '" + client_IDTextBox.Text + "'";
          

            try
            {
                cnnSample = new SqlConnection(_strConn);
                cnnSample.Open();

                cmdGetData = new SqlCommand();

                cmdGetData.Connection = cnnSample;
                cmdGetData.CommandType = CommandType.Text;
                cmdGetData.CommandText = strSql;

                tbl.Load(cmdGetData.ExecuteReader());
                classDataGridView.DataSource = tbl.DefaultView;


                cnnSample.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new AddClass(client_IDTextBox.Text);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void clientBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            UpdateClassGrid();
        }

        private void workerBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            UpdateSchedule();
        }

        private void rbCurrentDay_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSchedule();
        }

        private void rbNextWeek_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSchedule();
        }

        private void rbNextMonth_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSchedule();
        }
    }
}