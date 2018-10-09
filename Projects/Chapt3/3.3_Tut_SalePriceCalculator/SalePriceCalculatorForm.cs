using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._3_Tut_SalePriceCalculator
{
    public partial class SalePriceCalculatorForm : Form
    {
        public SalePriceCalculatorForm()
        {
            InitializeComponent();
        }

        private void SalePriceCalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculateSalePrice_Click(object sender, EventArgs e)
        {
            try
            {
                decimal originalPrice = decimal.Parse(txtOriginalPriceTextBox.Text);
                decimal discountRate = decimal.Parse(txtDiscountPercentageTextBox.Text);
                decimal discountAmount;
                decimal salePrice;

                discountRate = discountRate / 100;
                discountAmount = originalPrice * discountRate;
                salePrice = originalPrice - discountAmount;
                7b
                lblSalePriceLabel.Text = salePrice.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
