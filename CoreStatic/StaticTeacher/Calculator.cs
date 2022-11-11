using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreStatic.StaticTeacher
{
    /// <summary>
    /// cannot create an object of a static class and cannot access static members using an object.
    /// Static là không thể được khởi tạo instance, all trong static class must static
    /// A static class cannot contain instance members and constructors.
    /// Indexers and destructors cannot be static
    /// var cannot be used to define static members.
    /// * Static classes are sealed class and therefore, cannot be inherited.
    /// A static class remains in memory for the lifetime of the application domain in which your program resides.
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
    }
}
