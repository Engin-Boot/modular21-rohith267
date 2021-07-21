using System;
using System.Diagnostics;
using System.Drawing;

namespace ColorCoderProject

{
    class ColorMapper
    {
        public static Color[] colorMapMajor;
        public static Color[] colorMapMinor;
        static ColorMapper()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }

    }

}