using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismClass
{
    /// <summary>
    /// Code C# chuyển qua machine code để máy tính hiểu được. Qua 2 giai đoạn C# => compile-time => run-time => machine code
    /// Compile-time là từ code ngôn ngữ bậc cao C# sang ngôn ngữ trung gian IL và được lưu dưới dạng file .dll, .exe
    /// During compile time the compiler check for the syntax, semantic, and type of the code.
    /// 
    /// Sử dụng tính đa hình nếu: Nếu muốn có nhiều dạng của một hoặc nhiều phương thức có cùng tên
    /// Method overloading is also known as early binding or static binding because which method to call is decided at compile time, early than the runtime.
    /// </summary>
    public class CompileTimePolymorphism
	{
        public void Print(string str)
        {
            Console.WriteLine(str);
        }

        public void Print(int a, string str)
        {
            Console.WriteLine($"{a}, {str}");
        }

        /// <summary>
        /// Kiểu return không đóng vai trò trong method overloading
        /// Có cùng số parameter khác kiểu trả về sẽ Invalid: compile-time error.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="str"></param>
        /// <returns>int</returns>
        //public int Print(int a, string str)
        //{
        //    Console.WriteLine($"{a}, {str}");
        //    return 0;
        //}

        public void Print(string str, int a)
        {
            Console.WriteLine($"{a}, {str}");
        }

        public void Print(string str1, string str2)
        {
            Console.WriteLine($"{str1}, {str2}");
        }

        public void Print(string str1, string str2, string str3)
        {
            Console.WriteLine($"{str1}, {str2}, {str3}");
        }

        public void Print(int a)
        {
            Console.WriteLine($"Integer {a}");
        }
    }
}
