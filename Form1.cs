using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            Validate();
            clientBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(cPSC285S23BDataSet);
        }

        private void workerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            workerBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(cPSC285S23BDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                workerTableAdapter.Fill(cPSC285S23BDataSet.Worker);
                clientTableAdapter.Fill(cPSC285S23BDataSet.Client);
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
            int GetDaysFromRadioButtons(RadioButton radioButton)
            {
                switch (radioButton.Name)
                {
                    case "rbCurrentDay":
                        return 0;
                    case "rbNextWeek":
                        return 7;
                    case "rbNextMonth":
                        return 30;
                    default:
                        throw new ArgumentException("Invalid radio button");
                }
            }


            int days = 0;

            foreach (Control control in schedulePanel.Controls)
            {
                if (control is RadioButton button && button.Checked)
                {
                    days = GetDaysFromRadioButtons(button);
                    break;
                }
            }

            string todayDate = DateTime.Now.ToString("MM/dd/yyyy");
            string laterDate = DateTime.Now.AddDays(days).ToString("MM/dd/yyyy");

            string strSql = "select Class.Date, StartTime, C.Name " +
                            "from Class inner join Client C on C.Client_ID = Class.Client_ID " +
                            "where Date BETWEEN '" + todayDate + "' and '" + laterDate + "' " +
                            "and Class.Staff_ID = '" + staff_IDTextBox.Text + "'";
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
                            "where C.Client_ID = '" + client_IDTextBox.Text + "'";

            LoadDataGrid(strSql, classDataGridView);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new AddClass(client_IDTextBox.Text);
            form.ShowDialog();
            UpdateClassGrid(null, null);
            UpdateSchedule(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new AddClient();
            form.ShowDialog();

            // Refresh the data in the Client table after the AddClient form is closed
            try
            {
                clientTableAdapter.Fill(cPSC285S23BDataSet.Client);
                // Then select the newly added client
                clientBindingSource.Position = clientBindingSource.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}