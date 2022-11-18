using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreStatic.StaticTeacher
{
    /// <summary>
    /// 1 - Static classes cannot be instantiated.
    /// 2 - All the members of a static class must be static; otherwise the compiler will give an error.
    /// 3 - A static class can contain static variables, static methods, static properties, static operators, static events, and static constructors.
    /// 4 - A static class cannot contain instance members and constructors.
    /// 5 - Indexers and destructors cannot be static
    /// 6 - var cannot be used to define static members. You must specify a type of member explicitly after the static keyword.
    /// 7 - Static classes are sealed class and therefore, cannot be inherited.
    /// 8 - Static class members can be accessed using ClassName.MemberName. cannot access static members using an object.
    /// 9 - * A static class remains in memory for the lifetime of the application domain in which your program resides.
    /// </summary>
    public static class Calculator
    {
        private static int _resultStorage = 0;

        public static string Type = "Arithmetic";

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void Store(int result)
        {
            _resultStorage = result;
        }
        /// <summary>
        /// Extension method: Ở trong static class 
        /// </summary>
        /// <param name="i">this int i : tham số đầu tiên của extension method chỉ định kiểu mà nó sẽ chuyển sang toán tử, đứng trước từ khóa this</param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsGreaterThan(this int i, int value)
		{
            return i > value;
		}

        // using namespace là có thể sử dụng được extension method
        public static void TestExtensionMethod()
		{
            int i = 100;
            bool b = i.IsGreaterThan(101);
			Console.WriteLine(b);
		}
    }
}
