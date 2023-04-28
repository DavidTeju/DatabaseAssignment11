using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseAssignment11
{
    public partial class AddClass : Form
    {
        private List<Time> _defaultTimes;
        private Form1 _parent;
        private string _clientId;

        public AddClass(string currClientId, Form1 parent)
        {
            InitializeComponent();
            _clientId = currClientId;
            _parent = parent;

            _defaultTimes = new List<Time>();
            for (int i = 8; i <= 16; i++)
            {
                _defaultTimes.Add(new Time(i));
            }
        }

        private static bool DateIsValid(DateTime date)
        {
            return date >= DateTime.Today && date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;
        }

        private bool TimeIsValid(Time time)
        {
            if (time == null)
                return false;

            string sql = "SELECT COUNT(*) num " +
                         "FROM Class inner join Worker W on W.Staff_ID = Class.Staff_ID " +
                         "WHERE Date = '" + classDatePicker.Value.Date.ToString("yyyy-MM-dd") + "' " +
                         "AND Class.StartTime = '" + time.hour + "' " +
                         "AND W.Name = '" + instructorNameCombo.SelectedItem + "'";


            try
            {
                SqlConnection conn = new SqlConnection(Form1.StrConn);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                var result = cmd.ExecuteReader();
                result.Read();
                int count = result.GetInt32(0);
                conn.Close();
                return count == 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        private bool ValidateClass()
        {
            var errorProvider = new ErrorProvider();

            if (string.IsNullOrEmpty(instructorNameCombo.SelectedItem as string))
            {
                errorProvider.SetError(instructorNameCombo, "Please select an instructor");
                return false;
            }

            if (!DateIsValid(classDatePicker.Value.Date))
            {
                errorProvider.SetError(classDatePicker, "Please select a valid date in the future");
                return false;
            }

            if (!TimeIsValid((Time)timePicker.SelectedItem))
            {
                errorProvider.SetError(timePicker, "Time is already taken");
                return false;
            }

            return true;
        }

        private void AddClass_Load(object sender, EventArgs e)
        {
            timePicker.DataSource = _defaultTimes;
            instructorNameCombo.DataSource = GetInstructorNames();
        }

        private List<string> GetInstructorNames()
        {
            string query = "select Name from worker where Position = 'Instructor'";
            List<string> names = new List<string>();
            try
            {
                SqlConnection conn = new SqlConnection(Form1.StrConn);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteReader();
                while (result.Read())
                {
                    names.Add(result.GetString(0));
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return names;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (!ValidateClass())
                return;

            string sql = "INSERT INTO Class (Date, StartTime, Staff_ID, Client_ID) " +
                         "VALUES ('" + classDatePicker.Value.ToString("MM/dd/yyyy") + "', " +
                         "'" + ((Time)timePicker.SelectedItem).hour + "', " +
                         "(SELECT Staff_ID FROM Worker WHERE Name = '" + instructorNameCombo.SelectedItem + "'), " +
                         "'" + _clientId + "')";


            try
            {
                SqlConnection conn = new SqlConnection(Form1.StrConn);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                _parent.UpdateClassGrid(null, null);
                MessageBox.Show("Class added successfully");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private class Time
        {
            public int hour;

            public Time(int hour)
            {
                this.hour = hour;
            }

            public override string ToString()
            {
                string amOrPm = hour >= 12 ? "PM" : "AM";
                string hourString = hour % 12 == 0 ? "12" : (hour % 12).ToString();
                return hourString + ":00 " + amOrPm;
            }
        }

        private void ClearError(object sender, EventArgs e)
        {
            var errorProvider = new ErrorProvider();
            errorProvider.SetError((Control)sender, "");
        }
    }
}