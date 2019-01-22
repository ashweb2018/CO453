using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO453_ConsoleApp
{
    /// <summary>
    /// Author:Ashley Henney
    /// 
    /// This class is just used to try things out!
    /// </summary>
    ///public static class Ashley
   /// {
        ///private static string name;

        /// <summary>
        /// This initialises the Ashley class and is used
        /// for creating object
        /// </summary>
        public Ashley(string newName)
        {
            name = newName; 
        }

        /// <summary>
        /// This method writes out a title for an application
        /// </summary>       
        public static void WriteTitle(string title)
        {
            Console.WriteLine("==================");
            Console.WriteLine(name + "'s " + title);
            Console.WriteLine("==================");
        }
    }
}
