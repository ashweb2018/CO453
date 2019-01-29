using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO453_ConsoleApp.unit4
{
    /// <summary>
    /// 
    /// </summary>
    class TestDistanceConverter
    {
        private static double miles;
        private static double feet;
        /// <summary>
        /// Ths method will ask the user to enter number of miles 
        /// and it will convert the value to feet and display the
        /// result to the user
        /// </summary>
        public static void TestMilesToFeet()
        {

            UserLib.WriteTitle("Task 4.1 Miles -> Feet");

            miles = UserLib.GetDouble("Pleases enter number of miles > ");
            feet = DistanceConverter.MilesToFeet(miles);
            Console.WriteLine("the number of feet =" + miles.ToString("#.#"));
        }





        public static void TestFeetToMiles()
        {
            UserLib.WriteTitle("Task 4.1 Feet -> Miles");
        }
    }
}
