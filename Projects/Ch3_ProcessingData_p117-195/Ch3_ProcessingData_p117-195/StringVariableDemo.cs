using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch3_ProcessingData_p117_195
{
    public partial class StringVariableDemo : Form
    {
        public StringVariableDemo()
        {
            InitializeComponent();
        }

        private void btnCreateName_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstNameInput.Text;
            string lastName = txtLastNameInput.Text;
            string fullName = firstName + " " + lastName;

            lblFullNameOutput.Text = fullName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
