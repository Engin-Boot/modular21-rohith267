using System;
using System.Diagnostics;
using System.Drawing;

namespace ColorCoderProject

{
    class ColorPairEncoder
    {
        public static int GetPairNumberFromColor(ColorMapper.ColorPair pair)
        {
            int majorIndex = -1;
            for (int i = 0; i < ColorMapper.colorMapMajor.Length; i++)
            {
                if (ColorMapper.colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }

            int minorIndex = -1;
            for (int i = 0; i < ColorMapper.colorMapMinor.Length; i++)
            {
                if (ColorMapper.colorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i;
                    break;
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