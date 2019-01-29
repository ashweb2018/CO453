using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO453_ConsoleApp.unit4
{
    class TestBook
    {
        public static void Test()
        {
            Book myBook = new Book()
            {
                Author = "Ashley",
                Title = "Once Upon A Time",
                Weapon = "Laser",
                Name = "James",
                Gender = GenderTypes.MALE
            };

            myBook.GetDetails();
            myBook.WriteChapter(1);
        }
    }
}
