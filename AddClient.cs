using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseAssignment11
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void UpdateSubmitButtonState(object sender, EventArgs e)
        {
            bool isInValid = string.IsNullOrEmpty(genderComboBox.Text) || // If no gender selected
                             string.IsNullOrEmpty(fullName.Text) || // If no name entered
                             fullName.Text.Split().Length < 2 || // Must have at least first and last name
                             string.IsNullOrEmpty(ageTextBox.Text) || // If no age entered
                             !int.TryParse(ageTextBox.Text, out _); // If age is not a number

            // Enable/Disable submit button based on validation result
            submitButton.Enabled = !isInValid;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // insert into Client(Name, Gender, Age)
            string sql = "insert into Client (Name, Gender, Age) " +
                         "values ('" + fullName.Text + "', '" + genderComboBox.Text + "', " + ageTextBox.Text + ")";
            try
            {
                SqlConnection conn = new SqlConnection(Form1.StrConn);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Close the form
        }
    }
}