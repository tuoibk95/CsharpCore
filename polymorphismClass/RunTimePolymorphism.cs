using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismClass
{
	/// <summary>
	/// Run-time polymorphism is also known as inheritance-based polymorphism or method overriding.
	/// Inheritance allows you to inherit a base class into a derived class
	/// and all the public members of the base class automatically become members of the derived class
	/// 
	/// Có thể định nghĩa lại members của lớp base trong lớp dẫn xuất để cung cấp cách triển khai khác với lớp cơ sở 
	/// => method Overriding cũng đc biết như runtime polymorphism
	/// Sử dụng "virtual" trong lớp base để chỉ định nó có thể bị ghi đèm, lớp dẫn xuất dùng từ khóa "override" để ghi đè phương thức của lớp base
	/// </summary>
	public class RunTimePolymorphism
	{
		public static void TestRunTimePolymorphism()
		{
			// C# sẽ gọi phương thức tùy vào kiểu đối tượng chứ không phải kiểu của biến
			Person person = new Person();
			person.Greet();
			Person person1 = new Employee();
			person1.Greet();
			Employee employee = new Employee();
			employee.Greet();
		}
	}
}
