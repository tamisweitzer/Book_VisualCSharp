﻿namespace HelloWorld
{
    partial class HelloWorld
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
            this.messageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageButton
            // 
            this.messageButton.Location = new System.Drawing.Point(187, 71);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(225, 140);
            this.messageButton.TabIndex = 0;
            this.messageButton.Text = "Display Message";
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 386);
            this.Controls.Add(this.messageButton);
            this.Name = "HelloWorld";
            this.Text = "Hello World";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button messageButton;
    }
}

