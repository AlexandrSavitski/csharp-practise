using System;

namespace Lect5.LetterA
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
