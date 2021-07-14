using System;
using System.Diagnostics;
using System.Drawing;

namespace ColorCoderProject

{
    class PairNumberDecoder
    {
                public static ColorPairer.ColorPair GetColorFromPairNumber(int pairNumber)
        {
            // The function supports only 1 based index. Pair numbers valid are from 1 to 25
            int minorSize = ColorMapper.colorMapMinor.Length;
            int majorSize = ColorMapper.colorMapMajor.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }

            // Find index of major and minor color from pair number
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;

            // Construct the return val from the arrays
            ColorPairer.ColorPair major_minor_color_pair = new ColorPairer.ColorPair()
            {
                majorColor = ColorMapper.colorMapMajor[majorIndex],
                minorColor = ColorMapper.colorMapMinor[minorIndex]
            };
            return major_minor_color_pair;
        }
        
    }
}