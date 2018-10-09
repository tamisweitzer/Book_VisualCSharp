using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._9_FieldDemo
{
    public partial class FieldDemoForm : Form
    {
        private string name = "Charles";


        public FieldDemoForm()
        {
            InitializeComponent();
        }

        private void btnShowName_Click(object sender, EventArgs e)
        {
            lblNameOutput.Text = name.ToString();
        }

        private void btnChangeChris_Click(object sender, EventArgs e)
        {
            lblNameOutput.Text = "Chris";
        }

        private void btnChangeCarmen_Click(object sender, EventArgs e)
        {
            lblNameOutput.Text = "Carmen";
        }
    }
}
