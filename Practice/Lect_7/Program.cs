using System;

namespace Lect_7
{
    class Program
    {
        static void Task1()
        {
            object[] obj = new object[10];
            Console.WriteLine(obj[1]);
        }

        static void Task2()
        {
            object[] obj = { 32, 'A', "Hello" };
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }

           //obj[0] = obj[0] + 10;
            obj[2] = obj[2] + ", guys!";

            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
        }

        static void Task3()
        {
            Random rnd = new Random();
            int[] arr = new int[13];
            int num = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(100);
                for (int j = 0; j < arr.Length; j++)
                {
                    num = arr[j];
                    if (num > arr[j])
                    {
                        num = arr[j];
                    }
                }
            }

            Console.WriteLine(num);
        }

        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }
    }
}
