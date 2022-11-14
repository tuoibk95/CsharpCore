using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DataType
{
    public class Startup
    {
        public static int DemSoTu()
        {
            string a = "HelloWorld xin chao cac ban";
            int count = 1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ' ')
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Bài tập tìm số chẵn lẻ có chia hết cho 3 hay không?
        /// </summary>
        /// <param name="n"></param>
        public static void PrintChanLe(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("n la so chan");
            }
            else
            {
                Console.WriteLine("n la so le");
            }
            if (n % 3 == 0)
            {
                Console.WriteLine("n la so chia het cho 3");
            }
            else
            {
                Console.WriteLine("n la so khong chia het cho 3");
            }
        }

        /// <summary>
        /// Tìm số lớn hơn hoặc nhỏ hơn hay bằng nhau của 2 số nguyên
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void CompareTwoInteger(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine($"{a} equal {b}");
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine($"{a} > {b}");
                }
                else
                {
                    Console.WriteLine($"{a} < {b}");
                }
            }
        }

        /// <summary>
        /// Tìm giá trị nhỏ nhất và lớn nhất
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        public static void SearchGTNN(int a, int b, int c, int d)
        {
            int[] arr = { a, b, c, d };
            int temp = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    temp = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = temp;
                }
            }
            if (a == b && b == c && c == d)
            {
                Console.WriteLine("Khong co so nho nhat");
            }
            else if (a != b || b != c || c != d)
            {
                Console.WriteLine(arr[0] + " la so nho nhat.");
                Console.WriteLine(arr[2] + " la so lon thu 2.");
            }
        }

        /// <summary>
        /// Sắp xếp sử dụng phương thức có sẵn
        /// </summary>
        public static void SapXep()
        {
            int[] arr = {5, 4, 7, 3, 9, 1};
            Array.Sort(arr);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Array.Reverse(arr);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        public static void DoString()
        {
            StringBuilder sb = new StringBuilder("LVT");
            sb.Append(" is GOD...");
            Console.WriteLine(sb);
        }

        public static void Main(String[] args)
        {
            string str1 = "Hello World;";
            Console.WriteLine(str1.Length);
            Console.WriteLine(str1.IndexOf("W"));
            Console.WriteLine(string.Concat(str1, "LVT"));
            int count = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                count++;
            }
            Console.WriteLine(count);
            Console.WriteLine("Chuoi co: " + DemSoTu() + " tu.");
            PrintChanLe(6);
            CompareTwoInteger(6, 6);
            SearchGTNN(5, 5, 5, 5);
            SapXep();
            DoString();
            Console.ReadLine();
        }
    }
}