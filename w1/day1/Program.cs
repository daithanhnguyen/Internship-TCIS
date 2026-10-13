// Day 1: biến, kiểu dữ liệu, nhập xuất dữ liệu
using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hỏi họ tên, mỗi câu hỏi một màu
            string firstName = ReadInput("What is your first name?: ", ConsoleColor.Yellow);
            string lastName = ReadInput("What is your last name?: ", ConsoleColor.Red);

            // int.Parse: đổi chuỗi sang số nguyên
            int age = int.Parse(ReadInput("What is your age?: ", ConsoleColor.DarkMagenta));

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Green;

            // $"...": nội suy chuỗi, {biến} được thay bằng giá trị
            Console.WriteLine($"Welcome For First Day of Internship at TCIS {firstName} {lastName}, {age} years old");

            Console.ResetColor(); // Trả về màu mặc định

            Console.ReadLine();   // Chờ nhấn Enter
            Console.Clear();

            // PIN là mã, không tính toán nên dùng string
            string email = ReadInput("Input your Email: ", ConsoleColor.Cyan);
            string pin = ReadInput("Input your PIN: ", ConsoleColor.Cyan);

            Console.WriteLine($"Your login account is: {email}");
            Console.WriteLine($"Your PIN is: {pin}");
        }

        // static: gọi trực tiếp, không cần tạo đối tượng
        // string (trước tên hàm): kiểu dữ liệu trả về
        static string ReadInput(string prompt, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(prompt);   // Không xuống dòng
            Console.ResetColor();    // Chữ người dùng gõ giữ màu mặc định

            // ?? string.Empty: đổi null thành chuỗi rỗng
            return Console.ReadLine() ?? string.Empty;
        }
    }
}