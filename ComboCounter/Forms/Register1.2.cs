﻿using ComboCounter.Classes;
using System;
using System.Data.Common;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ComboCounter.Forms
{
    public partial class Register1 : Form
    {

        public Register1()
        {
            InitializeComponent();
        }


        private void Register1_Load(object sender, EventArgs e)
        {
            FontManager fm = FontManager.getInstance();

            username_tb.Font = fm.getTextBoxFont();
            passwordBox.Font = fm.getTextBoxFont();
            fNameBox.Font = fm.getTextBoxFont();
            lNameBox.Font = fm.getTextBoxFont();
            sexBox.Font = fm.getTextBoxFont();
            heightBox.Font = fm.getTextBoxFont();
            weightBox.Font = fm.getTextBoxFont();
            yearBox.Font = fm.getTextBoxFont();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            DBConnection db = DBConnection.getInstance();

            Random r = new Random();

            int id = r.Next();

            Guid guid = Guid.NewGuid();

            // Need to change to the year
            User newUser = db.insertUser(
                id,
                username_tb.Text,
                passwordBox.Text,
                fNameBox.Text,
                lNameBox.Text,
                sexBox.Text,
                Int32.Parse(heightBox.Text),
                Int32.Parse(weightBox.Text),
                Int32.Parse(yearBox.Text)
                );

            if (newUser != null)
            {

                UserManager.setUser(newUser);

                UserManager.SetUserSettings(db.CreateNewUserSettings(newUser.Id));
                Main main = new Main();
                Hide();
                main.Show();
                main.FormClosed += (o, closeEvent) => { Close(); };
            }

        }

        private void submit_b_Click(object sender, EventArgs e)
        {
            DBConnection db = DBConnection.getInstance();

            Random r = new Random();

            int id = r.Next();

            Guid guid = Guid.NewGuid();

            // Need to change to the year
            User newUser = db.insertUser(
                id,
                username_tb.Text,
                passwordBox.Text,
                fNameBox.Text,
                lNameBox.Text,
                sexBox.Text,
                Int32.Parse(heightBox.Text),
                Int32.Parse(weightBox.Text),
                2002);

            if (newUser != null)
            {

                UserManager.setUser(newUser);

                UserManager.SetUserSettings(db.CreateNewUserSettings(newUser.Id));
                Main main = new Main();
                Hide();
                main.Show();
                main.FormClosed += (o, closeEvent) => { Close(); };
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnReturnToLogin(EventArgs.Empty);
        }

        protected virtual void OnReturnToLogin(EventArgs e)
        {
            ReturnToLogin?.Invoke(this, e);
        }

        public event EventHandler ReturnToLogin;


    }
}
