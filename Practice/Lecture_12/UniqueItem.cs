using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_12
{
     class UniqueItem
    {
        static int id = 0;
        static int temp;
        public static int ID()
        {
            Int32.TryParse(Console.ReadLine(), out temp);
            if (id >= temp)
            {
                id++;
            }
            else id = temp;
            Console.WriteLine(id);
            return id;
        }
    }
}
