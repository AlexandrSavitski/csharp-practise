using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_12
{
     class UniqueItem
    {
        static int id = 0;
        public static int ID()
        {
            id++;
            Int32.TryParse(Console.ReadLine(), out id);
            return id;
        }
    }
}
