using System.Windows.Forms;

namespace DatabaseAssignment11
{
    public partial class AddClass : Form
    {
        private string clientID;

        public AddClass(string currClientID)
        {
            InitializeComponent();
            clientID = currClientID;
        }
    }
}