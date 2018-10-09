namespace _3._9_FieldDemo
{
    partial class FieldDemoForm
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
            this.btnShowName = new System.Windows.Forms.Button();
            this.btnChangeChris = new System.Windows.Forms.Button();
            this.btnChangeCarmen = new System.Windows.Forms.Button();
            this.lblNameOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowName
            // 
            this.btnShowName.Location = new System.Drawing.Point(78, 32);
            this.btnShowName.Name = "btnShowName";
            this.btnShowName.Size = new System.Drawing.Size(135, 45);
            this.btnShowName.TabIndex = 0;
            this.btnShowName.Text = "Show Name";
            this.btnShowName.UseVisualStyleBackColor = true;
            this.btnShowName.Click += new System.EventHandler(this.btnShowName_Click);
            // 
            // btnChangeChris
            // 
            this.btnChangeChris.Location = new System.Drawing.Point(12, 83);
            this.btnChangeChris.Name = "btnChangeChris";
            this.btnChangeChris.Size = new System.Drawing.Size(136, 40);
            this.btnChangeChris.TabIndex = 1;
            this.btnChangeChris.Text = "Change Name to Chris";
            this.btnChangeChris.UseVisualStyleBackColor = true;
            this.btnChangeChris.Click += new System.EventHandler(this.btnChangeChris_Click);
            // 
            // btnChangeCarmen
            // 
            this.btnChangeCarmen.Location = new System.Drawing.Point(154, 83);
            this.btnChangeCarmen.Name = "btnChangeCarmen";
            this.btnChangeCarmen.Size = new System.Drawing.Size(135, 40);
            this.btnChangeCarmen.TabIndex = 2;
            this.btnChangeCarmen.Text = "Change Name to Carmen";
            this.btnChangeCarmen.UseVisualStyleBackColor = true;
            this.btnChangeCarmen.Click += new System.EventHandler(this.btnChangeCarmen_Click);
            // 
            // lblNameOutput
            // 
            this.lblNameOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNameOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNameOutput.Location = new System.Drawing.Point(78, 142);
            this.lblNameOutput.Name = "lblNameOutput";
            this.lblNameOutput.Size = new System.Drawing.Size(135, 42);
            this.lblNameOutput.TabIndex = 3;
            this.lblNameOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FieldDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 214);
            this.Controls.Add(this.lblNameOutput);
            this.Controls.Add(this.btnChangeCarmen);
            this.Controls.Add(this.btnChangeChris);
            this.Controls.Add(this.btnShowName);
            this.Name = "FieldDemoForm";
            this.Text = "Field Demo Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowName;
        private System.Windows.Forms.Button btnChangeChris;
        private System.Windows.Forms.Button btnChangeCarmen;
        private System.Windows.Forms.Label lblNameOutput;
    }
}

