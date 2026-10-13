using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Day 2: Operators, if/else, switch ===");

            // Nhập 4 số một lần, dùng lại cho các phần bên dưới
            int a = ReadInt("a = ");
            int b = ReadInt("b = ");
            int c = ReadInt("c = ");
            int d = ReadInt("d = ");

            Console.WriteLine();
            Console.WriteLine("1. Calculate (tính toán giá trị)");
            Console.WriteLine("2. Compare   (so sánh giá trị)");
            Console.WriteLine("3. Input     (nhập thêm một số để kiểm tra)");
            int choice = ReadInt("Choose 1-3: ");

            switch (choice)
            {
                case 1: CalculateDemo(a, b, c, d); break;
                case 2: CompareDemo(a, b, c, d); break;
                case 3: InputDemo(a, b); break;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }

        // ---------- 1. TÍNH TOÁN: kết quả là SỐ ----------
        static void CalculateDemo(int a, int b, int c, int d)
        {
            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");

            // Chia cho 0 với số nguyên sẽ văng lỗi, nên phải kiểm tra trước
            if (b != 0)
            {
                Console.WriteLine($"a / b = {a / b}");                 // chia nguyên, bỏ phần thập phân
                Console.WriteLine($"a % b = {a % b}");                 // chia lấy dư
                Console.WriteLine($"a / (double)b = {a / (double)b}"); // ép kiểu để ra số thực
            }
            else
            {
                Console.WriteLine("b = 0 nên không thực hiện được phép chia.");
            }

            // Gán rút gọn: += -= *= /= %=
            int total = a;
            total += b;   // total = total + b
            total *= 2;   // total = total * 2
            Console.WriteLine($"total = (a + b) * 2 = {total}");

            // x++ trả giá trị CŨ rồi mới tăng, ++x tăng rồi mới trả giá trị
            int n = a;
            int post = n++;
            int pre = ++n;
            Console.WriteLine($"a = {a}: post = {post}, pre = {pre}, n = {n}");

            // Ví dụ cần d và b khác 0
            if (d != 0 && b != 0)
            {
                int x = 1;
                x = c / d + x++;
                Console.WriteLine($"x = c / d + x++ = {x}");

                int y = d * a;
                int z = y / b + --y + --y;
                Console.WriteLine($"z = y / b + --y + --y = {z}");
            }
        }

        // ---------- 2. SO SÁNH: kết quả là bool (True/False) ----------
        static void CompareDemo(int a, int b, int c, int d)
        {
            // So sánh: == != > < >= <=
            Console.WriteLine($"a + b == c ==> {a + b == c}");
            Console.WriteLine($"a - b == c ==> {a - b == c}");
            Console.WriteLine($"a * b == c ==> {a * b == c}");
            Console.WriteLine($"d - a == c ==> {d - a == c}");
            Console.WriteLine($"a != b ==> {a != b}");
            Console.WriteLine($"a < b ==> {a < b}");
            Console.WriteLine($"a >= d ==> {a >= d}");

            // Logic: && (và), || (hoặc), ! (phủ định)
            Console.WriteLine($"a < b && b < c ==> {a < b && b < c}");
            Console.WriteLine($"a > b || c == d ==> {a > b || c == d}");
            Console.WriteLine($"!(a == b) ==> {!(a == b)}");

            // Lưu kết quả vào biến bool để dùng lại
            bool isEqual = (a + b == c);
            Console.WriteLine($"isEqual = {isEqual}");
        }

        // ---------- 3. NHẬP SỐ: so với kết quả tính toán ----------
        static void InputDemo(int a, int b)
        {
            int sum = a + b;
            int number = ReadInt($"Input number (so với a + b = {sum}): ");

            // if / else if / else: điều kiện phải là bool
            if (number == sum)
            {
                Console.WriteLine("The number equals a + b.");
            }
            else if (number > sum)
            {
                Console.WriteLine("The number is greater than a + b.");
            }
            else
            {
                Console.WriteLine("The number is less than a + b.");
            }

            // ?: là if/else viết gọn
            string parity = number % 2 == 0 ? "even" : "odd";
            Console.WriteLine($"{number} is {parity}.");

            // switch: tên thứ trong tuần
            switch (number)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;
                default: Console.WriteLine("Not a weekday number (1-7)."); break;
            }
        }

        // ---------- Đọc số nguyên, nhập sai thì hỏi lại ----------
        static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    return value;
                }
                Console.WriteLine("Please enter a whole number.");
            }
        }
    }
}