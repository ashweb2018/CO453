using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("Hello Ashley!");

            // create two new objects from the class

            //Ashley ashley1 = new Ashley();
           //Ashley ashley2 = new Ashley();

            // Use the static method from the class

            Ashley.WriteTitle("My Wonder Application");
            Ashley.WriteTitle("My Wizard Application");

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
