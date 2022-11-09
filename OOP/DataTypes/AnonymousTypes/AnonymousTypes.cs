using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DataTypes.AnonymousTypes
{
	internal class AnonymousTypes
	{
		public static void Test()
		{
			var students = new
			{
				Id = 1,
				FirstName = "Tuoi",
				LastName = "Le Van ",
				Addres = new { Id = 1, City = "Thanh hoa" }
			};
			Console.WriteLine(students.LastName + students.FirstName);
			// Không thay đổi được giá trị
			// students.Id = 5;
			// Code kết hợp LINQ sau sẽ làm tiếp
		}
	}
}
