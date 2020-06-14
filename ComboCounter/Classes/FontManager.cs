﻿using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace ComboCounter.Classes
{
    class FontManager
    {

        PrivateFontCollection pfc;

        private static FontManager instance;

        private FontManager()
        {

            pfc = new PrivateFontCollection();

            AddToPfc(Properties.Resources.RobotoSlab_ExtraBold);
            AddToPfc(Properties.Resources.Roboto_Regular);
            AddToPfc(Properties.Resources.Roboto_Medium);

            foreach(FontFamily font in pfc.Families)
            {
                Console.WriteLine(font.Name);
            }

        }

        private void AddToPfc(byte[] newFont)
        {
            int fontLength = newFont.Length;

            System.IntPtr fontPtr = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(newFont, 0, fontPtr, fontLength);

            this.pfc.AddMemoryFont(fontPtr, fontLength);
        }

        public static FontManager getInstance()
        {
            if (instance == null)
            {
                instance = new FontManager();
            }

            return instance;
        }

        public Font getHeaderFont()
        {
            return new Font(pfc.Families[2], 80);
        }

        public Font getHeader2Font()
        {
            return new Font(pfc.Families[2], 70);
        }

        public Font getHeader3Font()
        {
            return new Font(pfc.Families[2], 36);
        }

        public Font getBigInfoFont()
        {
            return new Font(pfc.Families[0], 120);
        }

        public Font getSmallInfoFont()
        {
            return new Font(pfc.Families[0], 30);
        }

        public Font getButtonFont()
        {
            return new Font(pfc.Families[1], 20);
        }
    }
}
