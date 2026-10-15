using System;

namespace methods
{
    public class Method
    {
        // Không tham số, không trả về
        public static void Welcome()
        {
            Console.WriteLine("Welcome to day 3 at TCIS");
        }

        // Có tham số, không trả về
        public static void FullName(string firstName, string middllename, string lastName)
        {
            Console.WriteLine($"Welcome to Day 3 at TCIS {firstName} {middllename} {lastName}");
        }

        // Có tham số, có trả về giá trị
        public static int Tong(int x, int y)
        {
            return x + y;
        }

        // Dùng out để trả về nhiều giá trị
        public static void TongHieu(int x, int y, out int tong, out int hieu)
        {
            tong = x + y;
            hieu = x - y;
        }

        // Dùng ref để sửa trực tiếp biến gốc
        public static void TangLen(ref int x, int n)
        {
            x += n;
        }
    }
}