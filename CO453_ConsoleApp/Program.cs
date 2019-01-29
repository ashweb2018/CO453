using System;
using CO453_ConsoleApp.unit4;

namespace CO453_ConsoleApp
{
    /// <summary>
    /// author: Ashley Henney
    /// 
    /// This class will run all console app examples
    /// required for module CO453 applications programming
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            TestBook.Test();

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        public void Archive()
        {
            TestDistanceConverter.TestMilesToFeet();
            TestDistanceConverter.TestFeetToMiles();
        }
    }
}
