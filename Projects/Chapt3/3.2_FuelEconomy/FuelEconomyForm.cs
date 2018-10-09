using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._2_FuelEconomy
{
    public partial class FuelEconomyForm : Form
    {
        public FuelEconomyForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Exit button
            this.Close();
        }

        private void btnCalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double milesDriven = double.Parse(txtMilesTextBox.Text);
                double gallonsUsed = double.Parse(txtGallonsTextBox.Text);
                double mpg = milesDriven / gallonsUsed;
                lblMPGLabel.Text = mpg.ToString("n2");
            }
            catch (Exception)
            {
                MessageBox.Show("You must enter a real number");
            }
            

            
        }
    }
}
