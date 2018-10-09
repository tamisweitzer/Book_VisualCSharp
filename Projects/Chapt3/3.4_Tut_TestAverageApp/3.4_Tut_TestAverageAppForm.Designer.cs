namespace _3._4_Tut_TestAverageApp
{
    partial class frmTestAveragesApp
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
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.lblTest3 = new System.Windows.Forms.Label();
            this.lblAverageScore = new System.Windows.Forms.Label();
            this.lblAverageScoreOutput = new System.Windows.Forms.Label();
            this.txtTest1Input = new System.Windows.Forms.TextBox();
            this.txtTest2Input = new System.Windows.Forms.TextBox();
            this.txtTest3Input = new System.Windows.Forms.TextBox();
            this.btnCalculateAverage = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Location = new System.Drawing.Point(93, 39);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(40, 13);
            this.lblText1.TabIndex = 0;
            this.lblText1.Text = "Text 1:";
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.Location = new System.Drawing.Point(93, 74);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(40, 13);
            this.lblText2.TabIndex = 1;
            this.lblText2.Text = "Test 2:";
            // 
            // lblTest3
            // 
            this.lblTest3.AutoSize = true;
            this.lblTest3.Location = new System.Drawing.Point(93, 109);
            this.lblTest3.Name = "lblTest3";
            this.lblTest3.Size = new System.Drawing.Size(40, 13);
            this.lblTest3.TabIndex = 2;
            this.lblTest3.Text = "Test 3:";
            // 
            // lblAverageScore
            // 
            this.lblAverageScore.AutoSize = true;
            this.lblAverageScore.Location = new System.Drawing.Point(28, 154);
            this.lblAverageScore.Name = "lblAverageScore";
            this.lblAverageScore.Size = new System.Drawing.Size(105, 13);
            this.lblAverageScore.TabIndex = 3;
            this.lblAverageScore.Text = "Average Test Score:";
            // 
            // lblAverageScoreOutput
            // 
            this.lblAverageScoreOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAverageScoreOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAverageScoreOutput.Location = new System.Drawing.Point(162, 144);
            this.lblAverageScoreOutput.Name = "lblAverageScoreOutput";
            this.lblAverageScoreOutput.Size = new System.Drawing.Size(100, 23);
            this.lblAverageScoreOutput.TabIndex = 4;
            // 
            // txtTest1Input
            // 
            this.txtTest1Input.Location = new System.Drawing.Point(162, 36);
            this.txtTest1Input.Name = "txtTest1Input";
            this.txtTest1Input.Size = new System.Drawing.Size(100, 20);
            this.txtTest1Input.TabIndex = 5;
            // 
            // txtTest2Input
            // 
            this.txtTest2Input.Location = new System.Drawing.Point(162, 71);
            this.txtTest2Input.Name = "txtTest2Input";
            this.txtTest2Input.Size = new System.Drawing.Size(100, 20);
            this.txtTest2Input.TabIndex = 6;
            // 
            // txtTest3Input
            // 
            this.txtTest3Input.Location = new System.Drawing.Point(162, 106);
            this.txtTest3Input.Name = "txtTest3Input";
            this.txtTest3Input.Size = new System.Drawing.Size(100, 20);
            this.txtTest3Input.TabIndex = 7;
            // 
            // btnCalculateAverage
            // 
            this.btnCalculateAverage.Location = new System.Drawing.Point(31, 207);
            this.btnCalculateAverage.Name = "btnCalculateAverage";
            this.btnCalculateAverage.Size = new System.Drawing.Size(80, 56);
            this.btnCalculateAverage.TabIndex = 8;
            this.btnCalculateAverage.Text = "Calculate Average";
            this.btnCalculateAverage.UseVisualStyleBackColor = true;
            this.btnCalculateAverage.Click += new System.EventHandler(this.btnCalculateAverage_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(131, 207);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 56);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(231, 207);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 56);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTestAveragesApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 275);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculateAverage);
            this.Controls.Add(this.txtTest3Input);
            this.Controls.Add(this.txtTest2Input);
            this.Controls.Add(this.txtTest1Input);
            this.Controls.Add(this.lblAverageScoreOutput);
            this.Controls.Add(this.lblAverageScore);
            this.Controls.Add(this.lblTest3);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.lblText1);
            this.Name = "frmTestAveragesApp";
            this.Text = "Test Averages App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.Label lblTest3;
        private System.Windows.Forms.Label lblAverageScore;
        private System.Windows.Forms.Label lblAverageScoreOutput;
        private System.Windows.Forms.TextBox txtTest1Input;
        private System.Windows.Forms.TextBox txtTest2Input;
        private System.Windows.Forms.TextBox txtTest3Input;
        private System.Windows.Forms.Button btnCalculateAverage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

