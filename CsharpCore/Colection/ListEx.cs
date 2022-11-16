using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCore.Colection
{
	/// <summary>
	/// List : IList kiểu generic Colection của ArrayList, faster và it lỗi hơn ArrayList
	/// có thể chứa phần tử thuộc loại đã được chỉ định
	/// Cung cấp compile time type check. Vì là Generic nên không thực hiện boxing & unboxing
	/// </summary>
	internal class ListEx
	{
		public void ToList()
		{
			List<string> list = new List<string>();
			list.Add("Free");
			list.Add("Education");
			list.Add(null);
			Console.WriteLine(list.Count);
			foreach (var item in list)
			{
				Console.WriteLine(" " + item);
			}
			list.Insert(0, "HowKteam");
			bool isExists = list.Contains("Free");
			if (isExists)
			{
				Console.WriteLine("Có chứa");
			}
			else
			{
				Console.WriteLine("Không chứa.");
			}

			#region adding elements using collection-initializer syntax
			var bigCities = new List<string>()
					{
						"New York",
						"London",
						"Mumbai",
						"Chicago"
					};
			bigCities.ForEach(city => Console.WriteLine(city + ", "));
			var students = new List<Student>() {
				new Student(){ Id = 1, Name="Bill"},
				new Student(){ Id = 2, Name="Steve"},
				new Student(){ Id = 3, Name="Ram"},
				new Student(){ Id = 4, Name="Abdul"}
			};
			// Anonymous method
			students.ForEach(delegate (Student std) { Console.WriteLine(std.Id + ": " + std.Name); });
			// Lambda expression
			students.ForEach(std => Console.WriteLine(std.Id + ": " + std.Name));

			var result = from s in students
						 where s.Name == "Bill"
						 select s;

			foreach (var student in result)
				Console.WriteLine(student.Id + ", " + student.Name);
			#endregion
		}
	}

	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
}
