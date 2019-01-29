﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO453_ConsoleApp.unit4
{
    public enum GenderTypes
    {
        FEMALE,
        MALE
    }

    class Book
    {
        public string Title { get; set; }
        public string Weapon { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public GenderTypes Gender { get; set; }
        public void GetDetails()
        {
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Weapon: " + Weapon);
            Console.WriteLine("Name: " + Name);

            if (Gender == GenderTypes.FEMALE)
            {
                Console.WriteLine("She is a woman");
            }
            else
            {
                Console.WriteLine("he is a man");
            }
        }

        public void WriteChapter(int chapter)
        {
            UserLib.WriteTitle("Task 4.2" + Title);
            Console.WriteLine("As i slowly opened the door, I saw a \n" +
                Weapon + " lying on the floor.  I called out \n" +
                Name + "'s name and followed the blood trail into \n" +
                "the next room.  In the darkness I saw  \n" +
                Name + " lying at a very sinister angle.");
        }
    }
}
