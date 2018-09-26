using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxDemo
{
    public partial class frmTextBoxDemo : Form
    {
        public frmTextBoxDemo()
        {
            InitializeComponent();
        }

        private void btnReadInput_Click(object sender, EventArgs e)
        {
            lblNameOutput.Text = txtNameInput.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
