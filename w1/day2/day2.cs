// Arithmetic operators in C#
using System;

namespace Class2
{
    class Class2
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            int c = 40;
            int d = 20;
            int x = 1;
            x = c / d + x++;
            Console.WriteLine(x);


            int y = d * a;
            int z = 2; 
            z = y / b + --y + --y;
            Console.WriteLine(z);
        }
    }
}