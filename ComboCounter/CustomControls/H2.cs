﻿using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;



namespace ComboCounter.Classes
{
    class H2 : Label
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Font Font { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override Color ForeColor { get => base.ForeColor; set => base.ForeColor = value; }

        public H2() : base()
        {
            FontManager fm = FontManager.getInstance();
            Font = fm.getHeader2Font();
            ForeColor = ThemeManager.initHeaderColor();

            AutoSize = false;

        }

    }
}