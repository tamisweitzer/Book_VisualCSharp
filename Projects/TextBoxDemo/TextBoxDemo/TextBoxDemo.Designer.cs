namespace TextBoxDemo
{
    partial class frmTextBoxDemo
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameEntered = new System.Windows.Forms.Label();
            this.txtNameInput = new System.Windows.Forms.TextBox();
            this.btnReadInput = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblNameOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(73, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter your name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNameEntered
            // 
            this.lblNameEntered.AutoSize = true;
            this.lblNameEntered.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEntered.Location = new System.Drawing.Point(107, 103);
            this.lblNameEntered.Name = "lblNameEntered";
            this.lblNameEntered.Size = new System.Drawing.Size(98, 20);
            this.lblNameEntered.TabIndex = 1;
            this.lblNameEntered.Text = "You entered";
            this.lblNameEntered.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNameInput
            // 
            this.txtNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameInput.Location = new System.Drawing.Point(225, 50);
            this.txtNameInput.Name = "txtNameInput";
            this.txtNameInput.Size = new System.Drawing.Size(154, 27);
            this.txtNameInput.TabIndex = 2;
            // 
            // btnReadInput
            // 
            this.btnReadInput.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReadInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadInput.Location = new System.Drawing.Point(97, 168);
            this.btnReadInput.Name = "btnReadInput";
            this.btnReadInput.Size = new System.Drawing.Size(126, 49);
            this.btnReadInput.TabIndex = 4;
            this.btnReadInput.Text = "Read Input";
            this.btnReadInput.UseVisualStyleBackColor = true;
            this.btnReadInput.Click += new System.EventHandler(this.btnReadInput_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(245, 168);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 49);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblNameOutput
            // 
            this.lblNameOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNameOutput.Location = new System.Drawing.Point(225, 96);
            this.lblNameOutput.Name = "lblNameOutput";
            this.lblNameOutput.Size = new System.Drawing.Size(154, 27);
            this.lblNameOutput.TabIndex = 6;
            // 
            // frmTextBoxDemo
            // 
            this.AcceptButton = this.btnReadInput;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReadInput;
            this.ClientSize = new System.Drawing.Size(457, 303);
            this.Controls.Add(this.lblNameOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReadInput);
            this.Controls.Add(this.txtNameInput);
            this.Controls.Add(this.lblNameEntered);
            this.Controls.Add(this.lblName);
            this.Name = "frmTextBoxDemo";
            this.Text = "TextBox Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameEntered;
        private System.Windows.Forms.TextBox txtNameInput;
        private System.Windows.Forms.Button btnReadInput;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblNameOutput;
    }
}

