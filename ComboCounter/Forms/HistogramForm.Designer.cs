﻿namespace ComboCounter.Forms
{
    partial class HistogramForm
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
            this.histogram1 = new ComboCounter.UserControls.histogram();
            this.SuspendLayout();
            // 
            // histogram1
            // 
            this.histogram1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.histogram1.Location = new System.Drawing.Point(192, 21);
            this.histogram1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.histogram1.Name = "histogram1";
            this.histogram1.Size = new System.Drawing.Size(1297, 675);
            this.histogram1.TabIndex = 0;
            // 
            // HistogramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1658, 761);
            this.ControlBox = false;
            this.Controls.Add(this.histogram1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistogramForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistogramForm";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.histogram histogram1;
    }
}