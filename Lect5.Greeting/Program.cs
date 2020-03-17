using System;
using System.Globalization;

namespace Lect5.Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime moment = new DateTime();
            int hour = moment.Hour;
            if (hour >= 9 && hour < 12)
            {
                Console.WriteLine("Good morning, guys");
            }
            else if (hour > 12 && hour < 15)
            {
                Console.WriteLine("Good day, guys");
            }
            else if (hour > 15 && hour < 22)
            {
                Console.WriteLine("Good evening, guys");
            }
            else Console.WriteLine("Good night, guys");
        }
    }
}
