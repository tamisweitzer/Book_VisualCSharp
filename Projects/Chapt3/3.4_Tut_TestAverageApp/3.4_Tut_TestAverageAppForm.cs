using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._4_Tut_TestAverageApp
{
    public partial class frmTestAveragesApp : Form
    {
        public frmTestAveragesApp()
        {
            InitializeComponent();
        }

        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            double test1 = double.Parse(txtTest1Input.Text);
            double test2 = double.Parse(txtTest2Input.Text);
            double test3 = double.Parse(txtTest3Input.Text);
            double average = (test1 + test2 + test3) / 3;

            lblAverageScoreOutput.Text = average.ToString("n2");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTest1Input.Text = "";
            txtTest2Input.Text = "";
            txtTest3Input.Text = "";
            lblAverageScoreOutput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
