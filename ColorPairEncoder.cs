using System;
using System.Diagnostics;
using System.Drawing;

namespace ColorCoderProject

{
    class ColorPairEncoder
    {
        public static int GetPairNumberFromColor(ColorPairer.ColorPair pair)
        {
            int majorIndex = -1;
            int minorIndex = -1;
            int ColorMapMajorLength=ColorMapper.colorMapMajor.Length;
            int ColorMapMinorLength=ColorMapper.colorMapMinor.Length;
            for (int i = 0; i < Math.Max(ColorMapper.colorMapMajor.Length,ColorMapper.colorMapMinor.Length); i++)
            {
                if (i<ColorMapMajorLength && ColorMapper.colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                }
                if(i<ColorMapMinorLength && ColorMapper.colorMapMinor[i] == pair.minorColor)
                {
                    minorIndex=i;
                }
            }

          
            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            // Compute pair number and Return  
            // (Note: +1 in compute is because pair number is 1 based, not zero)
            return (majorIndex * ColorMapper.colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}