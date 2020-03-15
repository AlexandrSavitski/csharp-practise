using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            short a = 123;
            object o = a;
            sbyte A = (sbyte)(short)o;

            Console.WriteLine(A + " " + A.GetType());
        }
    }
}
