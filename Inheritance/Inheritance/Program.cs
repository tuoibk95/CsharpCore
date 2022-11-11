using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Inheritance
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Tạo đối tượng của lớp dẫn xuất - đầu tiên sẽ gọi contructor của lớp base và sau đó là lớp derived.
			// Nếu có nhiều mức kế thừa thì contructor của lớp base đầu tiên sẽ gọi và sau đó là contructor của lớp base thứ 2 ...
			// Lớp dẫn xuất (derived) có thể kế thừa members của lớp base, lớp base thì KHÔNG.
			Employee employee = new Employee();
			employee.FirstName = "Steve";
			employee.LastName = "Jobs";
			employee.EmployeeId = 1;
			employee.CompanyName = "Apple";

			var fullName = employee.GetFullName();
			Console.WriteLine(fullName);

			Console.WriteLine(employee.GetMiddleName());
//			Console.WriteLine(employee.Address);// Compile-time error. 

			Console.WriteLine(employee.GetSubcribedCourse());
			Console.WriteLine(employee.Course);
		}
	}
}
