using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DataTypes.AnonymousTypes
{
	/// <summary>
	/// Các thuộc tính của anonymous types là read-only và không được khởi tạo với null
	/// </summary>
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
