﻿using ComboCounter.Classes;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ComboCounter.CustomControls
{
    class OutlineButton : Button
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Font Font { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Color ForeColor { get => base.ForeColor; set => base.ForeColor = value; }

        public OutlineButton() : base()
        {
            Font = FontManager.getInstance().getButtonFont();
            ForeColor = ThemeManager.initButtonColor();


            BackColor = Color.Transparent;
            TextAlign = ContentAlignment.MiddleCenter;


            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 2;
            FlatAppearance.BorderColor = Color.SteelBlue;

            ForeColor = Color.White;

            AutoSize = true;

            Padding = new Padding()
            {
                Top = 5,
                Bottom = 5,
                Left = 10,
                Right = 10
            };

        }

    }
}
