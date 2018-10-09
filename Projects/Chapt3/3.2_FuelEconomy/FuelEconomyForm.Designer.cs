namespace _3._2_FuelEconomy
{
    partial class FuelEconomyForm
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
            this.components = new System.ComponentModel.Container();
            this.lblMilesPromptLabel = new System.Windows.Forms.Label();
            this.lblGallonPromptLabel = new System.Windows.Forms.Label();
            this.lblOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.lblMPGLabel = new System.Windows.Forms.Label();
            this.txtMilesTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtGallonsTextBox = new System.Windows.Forms.TextBox();
            this.btnCalculateButton = new System.Windows.Forms.Button();
            this.btnExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMilesPromptLabel
            // 
            this.lblMilesPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilesPromptLabel.Location = new System.Drawing.Point(12, 38);
            this.lblMilesPromptLabel.Name = "lblMilesPromptLabel";
            this.lblMilesPromptLabel.Size = new System.Drawing.Size(219, 19);
            this.lblMilesPromptLabel.TabIndex = 0;
            this.lblMilesPromptLabel.Text = "Enter the number of miles driven";
            // 
            // lblGallonPromptLabel
            // 
            this.lblGallonPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGallonPromptLabel.Location = new System.Drawing.Point(12, 89);
            this.lblGallonPromptLabel.Name = "lblGallonPromptLabel";
            this.lblGallonPromptLabel.Size = new System.Drawing.Size(206, 23);
            this.lblGallonPromptLabel.TabIndex = 1;
            this.lblGallonPromptLabel.Text = "Enter the gallons of gas used";
            // 
            // lblOutputDescriptionLabel
            // 
            this.lblOutputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputDescriptionLabel.Location = new System.Drawing.Point(12, 142);
            this.lblOutputDescriptionLabel.Name = "lblOutputDescriptionLabel";
            this.lblOutputDescriptionLabel.Size = new System.Drawing.Size(206, 23);
            this.lblOutputDescriptionLabel.TabIndex = 2;
            this.lblOutputDescriptionLabel.Text = "Your Car\'s MPG:";
            this.lblOutputDescriptionLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMPGLabel
            // 
            this.lblMPGLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMPGLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMPGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPGLabel.Location = new System.Drawing.Point(252, 142);
            this.lblMPGLabel.Name = "lblMPGLabel";
            this.lblMPGLabel.Size = new System.Drawing.Size(100, 23);
            this.lblMPGLabel.TabIndex = 3;
            // 
            // txtMilesTextBox
            // 
            this.txtMilesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMilesTextBox.Location = new System.Drawing.Point(252, 35);
            this.txtMilesTextBox.Name = "txtMilesTextBox";
            this.txtMilesTextBox.Size = new System.Drawing.Size(100, 22);
            this.txtMilesTextBox.TabIndex = 4;
            // 
            // txtGallonsTextBox
            // 
            this.txtGallonsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGallonsTextBox.Location = new System.Drawing.Point(252, 90);
            this.txtGallonsTextBox.Name = "txtGallonsTextBox";
            this.txtGallonsTextBox.Size = new System.Drawing.Size(100, 22);
            this.txtGallonsTextBox.TabIndex = 5;
            // 
            // btnCalculateButton
            // 
            this.btnCalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateButton.Location = new System.Drawing.Point(15, 186);
            this.btnCalculateButton.Name = "btnCalculateButton";
            this.btnCalculateButton.Size = new System.Drawing.Size(203, 50);
            this.btnCalculateButton.TabIndex = 6;
            this.btnCalculateButton.Text = "Calculate MPG";
            this.btnCalculateButton.UseVisualStyleBackColor = true;
            this.btnCalculateButton.Click += new System.EventHandler(this.btnCalculateButton_Click);
            // 
            // btnExitButton
            // 
            this.btnExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitButton.Location = new System.Drawing.Point(252, 186);
            this.btnExitButton.Name = "btnExitButton";
            this.btnExitButton.Size = new System.Drawing.Size(100, 50);
            this.btnExitButton.TabIndex = 7;
            this.btnExitButton.Text = "E&xit";
            this.btnExitButton.UseVisualStyleBackColor = true;
            this.btnExitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // FuelEconomyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 281);
            this.Controls.Add(this.btnExitButton);
            this.Controls.Add(this.btnCalculateButton);
            this.Controls.Add(this.txtGallonsTextBox);
            this.Controls.Add(this.txtMilesTextBox);
            this.Controls.Add(this.lblMPGLabel);
            this.Controls.Add(this.lblOutputDescriptionLabel);
            this.Controls.Add(this.lblGallonPromptLabel);
            this.Controls.Add(this.lblMilesPromptLabel);
            this.Name = "FuelEconomyForm";
            this.Text = "Fuel Economy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMilesPromptLabel;
        private System.Windows.Forms.Label lblGallonPromptLabel;
        private System.Windows.Forms.Label lblOutputDescriptionLabel;
        private System.Windows.Forms.Label lblMPGLabel;
        private System.Windows.Forms.TextBox txtMilesTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtGallonsTextBox;
        private System.Windows.Forms.Button btnCalculateButton;
        private System.Windows.Forms.Button btnExitButton;
    }
}

