﻿namespace ComboCounter.Forms
{
    partial class Exit
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
            this.exitMenu1 = new ComboCounter.UserControls_Gabriel.exitMenu();
            this.SuspendLayout();
            // 
            // exitMenu1
            // 
            this.exitMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.exitMenu1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exitMenu1.Location = new System.Drawing.Point(653, 289);
            this.exitMenu1.Name = "exitMenu1";
            this.exitMenu1.Size = new System.Drawing.Size(495, 350);
            this.exitMenu1.TabIndex = 24;
            // 
            // Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1875, 954);
            this.ControlBox = false;
            this.Controls.Add(this.exitMenu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 40);
            this.Name = "Exit";
            this.Opacity = 0.95D;
            this.Text = "Warning";
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls_Gabriel.exitMenu exitMenu1;
    }
}