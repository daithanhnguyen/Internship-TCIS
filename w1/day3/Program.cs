using System;
using System.Linq;
using System.Reflection;
using methods;

namespace day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            Console.WriteLine("while exercise: ");
            int a = 1;
            while (a <= 10)
            {
                Console.WriteLine($"a = {a}");
                Console.WriteLine("12345678");
                Console.WriteLine($"3 x {a} = {3 * a}");
                a++;
            }
            Console.WriteLine();

            // for
            Console.WriteLine("for exercise: ");
            int i = 2;
            for (i = 2; i <= 10; i++)
            {
                Console.WriteLine($"i = {i}");
                Console.WriteLine("acbdefg");
                Console.WriteLine($"3  {i} = {3 * i}");
            }
            Console.WriteLine();

            // do, while
            Console.WriteLine("do, while exercise: ");
            int b = 3; 
            do
            {
                Console.WriteLine($"4 x {b} = {4 * b}");
                b++;
            }
            while (b <= 10);
            Console.WriteLine();

            // break; continue
            Console.WriteLine("break; continue exercise: ");
            int c = 4;

            while (c < 30)
            {
                Console.WriteLine(c);
                c++;
                if (c == 25)
                    break;
            }
            Console.WriteLine();

            for (int d = 10; d < 20; d++)
            {
                if (d % 2 != 0) continue;

                Console.WriteLine($"so d = {d}");
            }
            Console.WriteLine();

            // array
            Console.WriteLine("array exercise: ");
            string[] studentList;
            studentList = new string[3];

            studentList[0] = "Nguyen Van A";
            studentList[1] = "Nguyen Van B";
            studentList[2] = "Nguyen Van C";
            Console.WriteLine();

            // for
            for (int y = 0; y < 3; y++)
            {
                Console.WriteLine(studentList[y]);
            }
            Console.WriteLine();

            // foreach
            foreach (string student in studentList)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            // linq
            Console.WriteLine("linq exercise: ");
            int[] numbers = {1, 8, 12, 7, 45, 26, 17, 88, 29, 110};
            Console.WriteLine($"So phan tu: {numbers.Length}"); // length
            Console.WriteLine($"Chieu: {numbers.Rank}"); // rank
            Console.WriteLine($"min: {numbers.Min()}"); // min
            Console.WriteLine($"max: {numbers.Max()}"); // max
            Console.WriteLine($"sum: {numbers.Sum()}"); // sum
            Console.WriteLine();


            // sort
            Console.WriteLine("sort exercise: ");
            Array.Sort(numbers);

            foreach (int num in numbers) 
            { 
                Console.WriteLine(num); 
            }
            Console.WriteLine();

            // matric
            Console.WriteLine("matric exercise: ");
            double[,] number = new double[3, 4] { { 2, 4, 6, 8 }, { 1, 3, 5, 7 }, { 9, 10, 11, 12 } };

            int row = 3;
            int column = 4;

            for (int e = 0; e < row;  e++)
            {
                for (int f = 0; f < column; f++)
                {
                    Console.Write(number[e,f]);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            // method
            Console.WriteLine("method exercise: ");

            Method.Welcome();

            Method.FullName("Thanh", "Dai", "Nguyen");

            int kq = Method.Tong(5, 7);
            Console.WriteLine($"Tong = {kq}");

            Method.TongHieu(8, 3, out int t, out int h);
            Console.WriteLine($"Tong = {t}, Hieu = {h}");

            int so = 5;
            Method.TangLen(ref so, 10);
            Console.WriteLine($"so = {so}");   // 15
        }
    }
}
