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
using System.Data.SqlClient;

namespace DatabaseAssignment11
{
    public partial class Form1 : Form
    {
        public static string StrConn = "Data Source=cissql;Initial Catalog=CPSC285S23B;Integrated Security=True";

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

            UpdateClassGrid(null, null);
            UpdateSchedule(null, null);
        }

        public void UpdateSchedule(object sender, EventArgs e)
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

            string todayDate = DateTime.Now.ToString("MM/dd/yyyy");
            string laterDate = DateTime.Now.AddDays(days).ToString("MM/dd/yyyy");

            string strSql = $@"select Class.Date, StartTime, C.Name 
                                from Class inner join Client C on C.Client_ID = Class.Client_ID
                                where Date BETWEEN '{todayDate}' and '{laterDate}' and Class.Staff_ID = '{staff_IDTextBox.Text}'";
            LoadDataGrid(strSql, scheduleDataGridView);
        }


        private void LoadDataGrid(string sqlQuery, DataGridView toFill)
        {
            try
            {
                var sqlConnection = new SqlConnection(StrConn);
                sqlConnection.Open();
                var cmdGetData = new SqlCommand(sqlQuery, sqlConnection);
                DataTable tbl = new DataTable();
                tbl.Load(cmdGetData.ExecuteReader());
                sqlConnection.Close();

                toFill.DataSource = tbl.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateClassGrid(object sender, EventArgs e)
        {
            string strSql = "select Class.Date, Class.StartTime, Worker.Name " +
                            "from Class inner join Client C on C.Client_ID = Class.Client_ID inner join Worker on Class.Staff_ID = Worker.Staff_ID " +
                            "where C.Client_ID = \'" + client_IDTextBox.Text + "\'";

            LoadDataGrid(strSql, classDataGridView);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new AddClass(client_IDTextBox.Text, this);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}