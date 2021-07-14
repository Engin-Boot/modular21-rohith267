using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace ColorCoderProject
{
    class colorManual
    {

        public static void manual()
        {

            int pairNumber = 1;
            for (int majorColorNumber = 0; majorColorNumber < ColorMapper.colorMapMajor.Length; majorColorNumber++)
            {
                for (int minorColorNumber = 0; minorColorNumber < ColorMapper.colorMapMinor.Length; minorColorNumber++)
                {

                    Console.WriteLine("[In]Pair Number: {0},Colors: majorColor {1} - minorColor {2}\n", pairNumber, ColorMapper.colorMapMajor[majorColorNumber], ColorMapper.colorMapMinor[minorColorNumber]);
                    pairNumber++;
                }
            }

        }

    }
}