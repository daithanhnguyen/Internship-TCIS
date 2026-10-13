// Declaring variables in C#
using System;


// Data type
namespace Class1
{
    class Class1
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            string studentFirstName;
            Console.WriteLine("What is your first name?: ");
            studentFirstName = Console.ReadLine(); // Input
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Red;
            string studentLastName;
            Console.WriteLine("What is your last name?: ");
            studentLastName = Console.ReadLine(); // Input
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            var studentAge = 1; // var
            Console.WriteLine("What is your age?: ");
            studentAge = int.Parse(Console.ReadLine()); // Input, int type

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(
                "Welcome to Day 2 of Internship at TCIS {0} {1}, {2} years old",
                studentFirstName,
                studentLastName,
                studentAge); // Output
            Console.ResetColor();

        }
    }
}
