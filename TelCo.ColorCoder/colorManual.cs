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
            for (int majorColorNumber = 0; majorColorNumber < 5; majorColorNumber++)
            {
                for (int minorColorNumber = 0; minorColorNumber < 5; minorColorNumber++)
                {

                    Console.WriteLine("[In]Pair Number: {0},Colors: majorColor {1} - minorColor {2}\n", pairNumber, ColorMapper.colorMapMajor[majorColorNumber], ColorMapper.colorMapMinor[minorColorNumber]);
                    pairNumber++;
                }
            }

        }

    }
}