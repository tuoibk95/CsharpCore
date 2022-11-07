using System;
using Variables;

// Name space đóng một vai trò quan trọng trong việc quản lý các lớp liên quan trong C#.
namespace OOP
{
    /// <summary>
    /// 1 - Abstraction
    /// 2 - Encapsulation
    /// 3 - Inheritance
    /// 4 - polymorphism
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            AutoImplementedProperty prog = new AutoImplementedProperty("Luc","Van Tien");
            
			Console.WriteLine(prog.GetFullName());
        }
    }
}
