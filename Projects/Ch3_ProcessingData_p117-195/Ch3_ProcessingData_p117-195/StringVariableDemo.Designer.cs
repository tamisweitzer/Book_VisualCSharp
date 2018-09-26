namespace Ch3_ProcessingData_p117_195
{
    partial class StringVariableDemo
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblFullNameOutput = new System.Windows.Forms.Label();
            this.btnCreateName = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtFirstNameInput = new System.Windows.Forms.TextBox();
            this.txtLastNameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(46, 71);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(190, 25);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Enter your first name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(46, 133);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(190, 25);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Enter your last name";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(46, 195);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(195, 25);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "This is your full name";
            // 
            // lblFullNameOutput
            // 
            this.lblFullNameOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFullNameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNameOutput.Location = new System.Drawing.Point(287, 187);
            this.lblFullNameOutput.Name = "lblFullNameOutput";
            this.lblFullNameOutput.Size = new System.Drawing.Size(181, 33);
            this.lblFullNameOutput.TabIndex = 3;
            // 
            // btnCreateName
            // 
            this.btnCreateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateName.Location = new System.Drawing.Point(51, 282);
            this.btnCreateName.Name = "btnCreateName";
            this.btnCreateName.Size = new System.Drawing.Size(185, 44);
            this.btnCreateName.TabIndex = 4;
            this.btnCreateName.Text = "Show Name";
            this.btnCreateName.UseVisualStyleBackColor = true;
            this.btnCreateName.Click += new System.EventHandler(this.btnCreateName_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(346, 282);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 44);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtFirstNameInput
            // 
            this.txtFirstNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstNameInput.Location = new System.Drawing.Point(290, 73);
            this.txtFirstNameInput.Name = "txtFirstNameInput";
            this.txtFirstNameInput.Size = new System.Drawing.Size(178, 30);
            this.txtFirstNameInput.TabIndex = 6;
            // 
            // txtLastNameInput
            // 
            this.txtLastNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastNameInput.Location = new System.Drawing.Point(290, 132);
            this.txtLastNameInput.Name = "txtLastNameInput";
            this.txtLastNameInput.Size = new System.Drawing.Size(178, 30);
            this.txtLastNameInput.TabIndex = 7;
            // 
            // StringVariableDemo
            // 
            this.AcceptButton = this.btnCreateName;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(545, 393);
            this.Controls.Add(this.txtLastNameInput);
            this.Controls.Add(this.txtFirstNameInput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateName);
            this.Controls.Add(this.lblFullNameOutput);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "StringVariableDemo";
            this.Text = "String Variable Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblFullNameOutput;
        private System.Windows.Forms.Button btnCreateName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtFirstNameInput;
        private System.Windows.Forms.TextBox txtLastNameInput;
    }
}

