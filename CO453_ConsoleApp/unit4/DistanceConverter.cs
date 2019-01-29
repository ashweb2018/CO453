﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO453_ConsoleApp.unit4
{
    /// <summary>
    /// This class will 
    /// </summary>
    class DistanceConverter
    {
        public const double NO_FEET_PER_MILE = 1760 * 3;

        public static double MilesToFeet(double miles)
        {
            return miles * NO_FEET_PER_MILE;
        }

        public static double FeetToMiles(double feet)
        {
            return feet / NO_FEET_PER_MILE;
        }


    }
}
