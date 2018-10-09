namespace _3._3_Tut_SalePriceCalculator
{
    partial class SalePriceCalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOriginalPricePromptLabel = new System.Windows.Forms.Label();
            this.lblDiscPercentagePromptLabel = new System.Windows.Forms.Label();
            this.lblOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.lblSalePriceLabel = new System.Windows.Forms.Label();
            this.txtOriginalPriceTextBox = new System.Windows.Forms.TextBox();
            this.txtDiscountPercentageTextBox = new System.Windows.Forms.TextBox();
            this.btnCalculateSalePrice = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOriginalPricePromptLabel
            // 
            this.lblOriginalPricePromptLabel.AutoSize = true;
            this.lblOriginalPricePromptLabel.Location = new System.Drawing.Point(41, 40);
            this.lblOriginalPricePromptLabel.Name = "lblOriginalPricePromptLabel";
            this.lblOriginalPricePromptLabel.Size = new System.Drawing.Size(141, 13);
            this.lblOriginalPricePromptLabel.TabIndex = 0;
            this.lblOriginalPricePromptLabel.Text = "Enter the item\'s original price";
            // 
            // lblDiscPercentagePromptLabel
            // 
            this.lblDiscPercentagePromptLabel.AutoSize = true;
            this.lblDiscPercentagePromptLabel.Location = new System.Drawing.Point(32, 75);
            this.lblDiscPercentagePromptLabel.Name = "lblDiscPercentagePromptLabel";
            this.lblDiscPercentagePromptLabel.Size = new System.Drawing.Size(150, 13);
            this.lblDiscPercentagePromptLabel.TabIndex = 1;
            this.lblDiscPercentagePromptLabel.Text = "Enter the discount percentage";
            // 
            // lblOutputDescriptionLabel
            // 
            this.lblOutputDescriptionLabel.AutoSize = true;
            this.lblOutputDescriptionLabel.Location = new System.Drawing.Point(124, 114);
            this.lblOutputDescriptionLabel.Name = "lblOutputDescriptionLabel";
            this.lblOutputDescriptionLabel.Size = new System.Drawing.Size(58, 13);
            this.lblOutputDescriptionLabel.TabIndex = 2;
            this.lblOutputDescriptionLabel.Text = "Sale Price:";
            // 
            // lblSalePriceLabel
            // 
            this.lblSalePriceLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSalePriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalePriceLabel.Location = new System.Drawing.Point(206, 104);
            this.lblSalePriceLabel.Name = "lblSalePriceLabel";
            this.lblSalePriceLabel.Size = new System.Drawing.Size(100, 23);
            this.lblSalePriceLabel.TabIndex = 3;
            // 
            // txtOriginalPriceTextBox
            // 
            this.txtOriginalPriceTextBox.Location = new System.Drawing.Point(206, 33);
            this.txtOriginalPriceTextBox.Name = "txtOriginalPriceTextBox";
            this.txtOriginalPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.txtOriginalPriceTextBox.TabIndex = 4;
            // 
            // txtDiscountPercentageTextBox
            // 
            this.txtDiscountPercentageTextBox.Location = new System.Drawing.Point(206, 68);
            this.txtDiscountPercentageTextBox.Name = "txtDiscountPercentageTextBox";
            this.txtDiscountPercentageTextBox.Size = new System.Drawing.Size(100, 20);
            this.txtDiscountPercentageTextBox.TabIndex = 5;
            // 
            // btnCalculateSalePrice
            // 
            this.btnCalculateSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateSalePrice.Location = new System.Drawing.Point(35, 162);
            this.btnCalculateSalePrice.Name = "btnCalculateSalePrice";
            this.btnCalculateSalePrice.Size = new System.Drawing.Size(135, 59);
            this.btnCalculateSalePrice.TabIndex = 6;
            this.btnCalculateSalePrice.Text = "Calculate Sale Price";
            this.btnCalculateSalePrice.UseVisualStyleBackColor = true;
            this.btnCalculateSalePrice.Click += new System.EventHandler(this.btnCalculateSalePrice_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(191, 162);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 59);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SalePriceCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 233);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateSalePrice);
            this.Controls.Add(this.txtDiscountPercentageTextBox);
            this.Controls.Add(this.txtOriginalPriceTextBox);
            this.Controls.Add(this.lblSalePriceLabel);
            this.Controls.Add(this.lblOutputDescriptionLabel);
            this.Controls.Add(this.lblDiscPercentagePromptLabel);
            this.Controls.Add(this.lblOriginalPricePromptLabel);
            this.Name = "SalePriceCalculatorForm";
            this.Text = "Sale Price Calculator";
            this.Load += new System.EventHandler(this.SalePriceCalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOriginalPricePromptLabel;
        private System.Windows.Forms.Label lblDiscPercentagePromptLabel;
        private System.Windows.Forms.Label lblOutputDescriptionLabel;
        private System.Windows.Forms.Label lblSalePriceLabel;
        private System.Windows.Forms.TextBox txtOriginalPriceTextBox;
        private System.Windows.Forms.TextBox txtDiscountPercentageTextBox;
        private System.Windows.Forms.Button btnCalculateSalePrice;
        private System.Windows.Forms.Button btnExit;
    }
}

