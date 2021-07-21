using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace ColorCoderProject
{
    class colorManual
    {

        public static void printManual(IManualOutput target)
        {

            int pairNumber = 1;
            for (int majorColorNumber = 0; majorColorNumber < ColorMapper.colorMapMajor.Length; majorColorNumber++)
            {
                for (int minorColorNumber = 0; minorColorNumber < ColorMapper.colorMapMinor.Length; minorColorNumber++)
                {

                    target.PrintLine("Pair Number: "+pairNumber+", Colors:: majorColor: "+ ColorMapper.colorMapMajor[majorColorNumber]+" minorColor: "+ ColorMapper.colorMapMinor[minorColorNumber]);
                    pairNumber++;
                }
            }

        }

    }
}