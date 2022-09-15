using System;

namespace Lesson5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "yarin";
            int sum2Number = 0;
            PrintName();
            PrintName(name);
            sum2Number = SumNumbers();
            Console.WriteLine(SumNumbers());
        }

        //פונקציה שמחזירה ערך
        static int SumNumbers()
        {
            int a = 1;
            int b = 2;
            int sum = a + b;
            return sum;
        }

        //פונקציה שלא מחזירה ערך
        static void PrintName(string name)
        {
            Console.WriteLine($"hello {name}");
        }
 
        static void PrintName()
        {
            Console.WriteLine("hello world");
        }
        static void PrintSumNumbers()
        {
            int a = 1;
            int b = 2;
            Console.WriteLine($"a + b = {a + b}");
        }


    }
}
