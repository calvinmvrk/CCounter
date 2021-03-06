﻿using ComboCounter.Classes;

namespace ComboCounter.UserControls_Gabriel
{
    partial class ComboScoreControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.forceLabelTable = new System.Windows.Forms.TableLayoutPanel();
            this.timeIntervalLabelTable = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new ComboCounter.CustomControls.OutlineButton();
            this.button2 = new ComboCounter.CustomControls.OutlineButton();
            this.button3 = new ComboCounter.CustomControls.OutlineButton();
            this.totalTime = new ComboCounter.Classes.BigInfo();
            this.headerLabel = new ComboCounter.Classes.Header1();
            this.forceHeader = new ComboCounter.Classes.H2();
            this.timeLabel = new ComboCounter.Classes.H2();
            this.scoreLabel = new ComboCounter.Classes.H3();
            this.totalTimeLabel = new ComboCounter.Classes.H3();
            this.scoreInfoLabel = new ComboCounter.Classes.SmallInfo();
            this.totalTimeLabelnfo = new ComboCounter.Classes.SmallInfo();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.timeIntervalLabelTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.timeIntervalLabelTable.ColumnCount = 8;
            this.timeIntervalLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.timeIntervalLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.timeIntervalLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.timeIntervalLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.timeIntervalLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.timeIntervalLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.timeIntervalLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.timeIntervalLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.timeIntervalLabelTable.Location = new System.Drawing.Point(508, 600);
            this.timeIntervalLabelTable.Margin = new System.Windows.Forms.Padding(4);
            this.timeIntervalLabelTable.Name = "tableLayoutPanel2";
            this.timeIntervalLabelTable.RowCount = 1;
            this.timeIntervalLabelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.timeIntervalLabelTable.Size = new System.Drawing.Size(1516, 102);
            this.timeIntervalLabelTable.TabIndex = 49;
            // 
            // tableLayoutPanel1
            // 
            this.forceLabelTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.forceLabelTable.ColumnCount = 9;
            this.forceLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11014F));
            this.forceLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11014F));
            this.forceLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11014F));
            this.forceLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11451F));
            this.forceLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11451F));
            this.forceLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11014F));
            this.forceLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11014F));
            this.forceLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11014F));
            this.forceLabelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11014F));
            this.forceLabelTable.Location = new System.Drawing.Point(409, 363);
            this.forceLabelTable.Margin = new System.Windows.Forms.Padding(4);
            this.forceLabelTable.Name = "tableLayoutPanel1";
            this.forceLabelTable.RowCount = 1;
            this.forceLabelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.forceLabelTable.Size = new System.Drawing.Size(1711, 102);
            this.forceLabelTable.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(48, 363);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button1.Size = new System.Drawing.Size(207, 63);
            this.button1.TabIndex = 51;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(48, 523);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button2.Size = new System.Drawing.Size(207, 63);
            this.button2.TabIndex = 52;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(48, 683);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button3.Size = new System.Drawing.Size(207, 63);
            this.button3.TabIndex = 53;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // totalTime
            // 
            this.totalTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalTime.AutoSize = true;
            this.totalTime.Location = new System.Drawing.Point(121, 52);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(761, 240);
            this.totalTime.TabIndex = 64;
            this.totalTime.Text = "00:00.0";
            this.totalTime.Visible = false;
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headerLabel.Location = new System.Drawing.Point(784, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(1112, 183);
            this.headerLabel.TabIndex = 65;
            this.headerLabel.Text = "Combo Score";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forceHeader
            // 
            this.forceHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forceHeader.Location = new System.Drawing.Point(403, 240);
            this.forceHeader.Name = "forceHeader";
            this.forceHeader.Size = new System.Drawing.Size(454, 105);
            this.forceHeader.TabIndex = 66;
            this.forceHeader.Text = "Force";
            this.forceHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.Location = new System.Drawing.Point(403, 480);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(811, 116);
            this.timeLabel.TabIndex = 67;
            this.timeLabel.Text = "Time Interval";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(647, 732);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(202, 81);
            this.scoreLabel.TabIndex = 68;
            this.scoreLabel.Text = "Score:";
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.Location = new System.Drawing.Point(1415, 735);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(194, 81);
            this.totalTimeLabel.TabIndex = 69;
            this.totalTimeLabel.Text = "Time:";
            // 
            // scoreInfoLabel
            // 
            this.scoreInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreInfoLabel.AutoSize = true;
            this.scoreInfoLabel.Location = new System.Drawing.Point(952, 747);
            this.scoreInfoLabel.Name = "scoreInfoLabel";
            this.scoreInfoLabel.Size = new System.Drawing.Size(117, 61);
            this.scoreInfoLabel.TabIndex = 71;
            this.scoreInfoLabel.Text = "N/A";
            // 
            // totalTimeLabelnfo
            // 
            this.totalTimeLabelnfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalTimeLabelnfo.AutoSize = true;
            this.totalTimeLabelnfo.Location = new System.Drawing.Point(1686, 747);
            this.totalTimeLabelnfo.Name = "totalTimeLabelnfo";
            this.totalTimeLabelnfo.Size = new System.Drawing.Size(117, 61);
            this.totalTimeLabelnfo.TabIndex = 72;
            this.totalTimeLabelnfo.Text = "N/A";
            // 
            // ComboScoreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.totalTimeLabelnfo);
            this.Controls.Add(this.scoreInfoLabel);
            this.Controls.Add(this.totalTimeLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.forceHeader);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.totalTime);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.forceLabelTable);
            this.Controls.Add(this.forceLabelTable);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ComboScoreControl";
            this.Size = new System.Drawing.Size(2287, 985);
            this.Load += new System.EventHandler(this.ComboScoreControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel forceLabelTable;
        private System.Windows.Forms.TableLayoutPanel timeIntervalLabelTable;
        private System.Windows.Forms.Timer timer1;
        private CustomControls.OutlineButton button1;
        private CustomControls.OutlineButton button2;
        private CustomControls.OutlineButton button3;
        private BigInfo totalTime;
        private Header1 headerLabel;
        private H2 forceHeader;
        private H2 timeLabel;
        private H3 scoreLabel;
        private H3 totalTimeLabel;
        private SmallInfo scoreInfoLabel;
        private SmallInfo totalTimeLabelnfo;
    }
}
