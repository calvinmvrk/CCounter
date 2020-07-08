﻿using System;
using System.Timers;
using System.Media;
using System.Diagnostics;
using ComboCounter.Classes;

namespace ComboCounter.UserControls
{
    public partial class targeted_total_of_force : BaseFormControl
    {
        Timer t;
        int totalForceBox;
        int forceGoalNum = 15000;

        const int FORCE_INTERVAL = 100;

        Stopwatch stopwatch = new Stopwatch();
        Session session;

        DateTime animationStart;

        TimeSpan animationDuration = new TimeSpan(2000000);

        public targeted_total_of_force()
        {
            InitializeComponent();
            header.Left = (Width - header.Width) / 2;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!t.Enabled)
            {
                t.Start();
                session = new Session(DateTime.Now);
                stopwatch.Start();
            }
        }

        private void targeted_total_of_force_Load(object sender, EventArgs e)
        {
            this.splitContainer1.SplitterDistance = Width / 2;

            t = new Timer();
            t.Interval = 100;
            t.Elapsed += OnTimeEvent;
            
        }

        private void plusIcon_Click(object sender, EventArgs e)
        {
            forceGoalNum += FORCE_INTERVAL;
            forceGoalLabel.Text = string.Format("{0:n0}", forceGoalNum);
        }

        private void minusIcon_Click(object sender, EventArgs e)
        {
            if (forceGoalNum != 0)
            {
                forceGoalNum -= FORCE_INTERVAL;
                forceGoalLabel.Text = string.Format("{0:n0}", forceGoalNum);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            SoundPlayer bellRing = new SoundPlayer(@"soundEffect\old-fashioned-bell.wav");
            Invoke(new Action(() =>
            {
                       
                txtResult.Text = Tools.FormatCurrentTime(stopwatch.ElapsedMilliseconds);

                if (totalForceBox >= forceGoalNum)
                {
                    totalForce.ForeColor = System.Drawing.Color.Green;
                    bellRing.Play();
                    t.Stop();
                    stopwatch.Stop();
                    History.InsertSession(session);
                }
                else
                {
                    double time = stopwatch.Elapsed.TotalSeconds;
                    int newForce = new Random().Next(100, 700);
                    totalForceBox = totalForceBox + newForce;
                    totalForce.Text = totalForceBox.ToString();

                    session.insertHit(newForce, time);
                }
            }));
        }

        private void IndicateHit()
        {
            Timer animate = new Timer();
            animate.Interval = 10;
            animate.Elapsed += (object sender, ElapsedEventArgs e) =>
            {
                TimeSpan span = e.SignalTime - animationStart;
                double percentTime = span.TotalMilliseconds / animationDuration.TotalMilliseconds;

                if (span >= animationDuration)
                {
                    animate.Stop();
                }

                punchIndicator.BackColor = System.Drawing.Color.FromArgb((int)(255 * percentTime), 255, 255, 255);
            };
            animationStart = DateTime.Now;
            animate.Start();
            
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            PauseTimers();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            t.Stop();
            totalForceBox = 0;
            totalForce.Text = "0";
            txtResult.Text = Tools.FormatCurrentTime(0);
            totalForce.ForeColor = System.Drawing.Color.DimGray;
            stopwatch.Stop();
            stopwatch.Reset(); 

        }

        private void PauseTimers()
        {
            t.Stop();
            stopwatch.Stop();
        }

        public override void OnPageRemoved()
        {
            if (UserManager.TimerSetting())
            {
                PauseTimers();
            }
        }

    }
}
