﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComboCounter
{

    public partial class Main : Form
    {


        public Main()
        {
            InitializeComponent();


        }

        #region Force Tracker
        private void force_tracker_Click(object sender, EventArgs e)
        {
            Forms.SensorAdjusments SensorAdjusments = new Forms.SensorAdjusments();
            SensorAdjusments.Show();

            // combo_tracker1.BringToFront();
        }

        #endregion

        #region Welcome Page
        private void home_button_Click(object sender, EventArgs e)
        {
            // homeControl1.BringToFront();
            //home_user1.BringToFront();
        }

        #endregion

        private void user_button_Click(object sender, EventArgs e)
        {
            //Forms.justToTry UserAccountForm = new Forms.justToTry();
            // UserAccountForm.Show();

            Forms.UserAccountForm UserAccountForm = new Forms.UserAccountForm();
            UserAccountForm.Show();

            // user_control1.BringToFront();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {

            Forms.Exit exit = new Forms.Exit();
            exit.exitApplication += (s, arg) => { Close(); };

            Rectangle dimensions = Screen.FromControl(this).Bounds;
            exit.ClientSize = new Size(Width, Height);
            exit.Show();

        }

        
        private void time_button_Click(object sender, EventArgs e)
        {
             Forms.Exit QuickStartForm = new Forms.Exit();
             QuickStartForm.Show();

            //Forms.QuickStartForm QuickStartForm = new Forms.QuickStartForm();
            // QuickStartForm.Show();

            // timeMode1.BringToFront();
        }

        private void histogram_Click(object sender, EventArgs e)
        {
            Forms.HistogramForm HistogramForm = new Forms.HistogramForm();
            HistogramForm.Show();


            //histogram1.BringToFront();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // homeControl1.BringToFront();
            // home_user1.BringToFront();;

            ToolTip HomeToolTip = new ToolTip();
            HomeToolTip.SetToolTip(home_button, "Home");
            HomeToolTip.SetToolTip(force_tracker, "Force Tracker");
            HomeToolTip.SetToolTip(time_button, "Time Tracker");
            HomeToolTip.SetToolTip(histogram, "Show History");
            HomeToolTip.SetToolTip(user_button, "Show/Edit User Information");
            HomeToolTip.SetToolTip(exit_button, "Exit Program");
        }

        private void quickStart1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.TargetedTotalForce TargetedTotalForce = new Forms.TargetedTotalForce();
            TargetedTotalForce.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboButton_Click(object sender, EventArgs e)
        {
            Forms.ComboScore ComboScore = new Forms.ComboScore();
            ComboScore.Show();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forms.PunchCount PunchCount = new Forms.PunchCount();
               PunchCount.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Forms.CustomPunchCount CustomPunchCount = new Forms.CustomPunchCount();
            CustomPunchCount.Show();

        }

        private void vstimeBtn_Click(object sender, EventArgs e)
        {
            Forms.TargetTotalForceComp CustomTargetTotalForm = new Forms.TargetTotalForceComp();
            CustomTargetTotalForm.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Forms.CustomTargetTotalTime CustomTargetTotalTime = new Forms.CustomTargetTotalTime();
            CustomTargetTotalTime.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.TargetTotalTime TargetTotalTime = new Forms.TargetTotalTime();
            TargetTotalTime.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Forms.PunchChallange PunchChallange = new Forms.PunchChallange();
            PunchChallange.Show();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            Forms.CustomPunchChallange CustomPunchChallange = new Forms.CustomPunchChallange();
            CustomPunchChallange.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Forms.CustomComboScore CustomComboScore = new Forms.CustomComboScore();
            CustomComboScore.Show();

        }


        private void button9_Click(object sender, EventArgs e)
        {
            Forms.SensorAdjusments SensorAdjusments = new Forms.SensorAdjusments();
            SensorAdjusments.Show();


        }

        private void button10_Click(object sender, EventArgs e)
        {
            Forms.ComboScoreComp ComboScoreComp = new Forms.ComboScoreComp();
            ComboScoreComp.Show();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //  private void homeControl1_Load(object sender, EventArgs e)
        //   {

        //  }
    }
}
