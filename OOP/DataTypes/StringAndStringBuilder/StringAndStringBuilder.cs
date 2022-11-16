using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DataTypes.StringAndStringBuilder
{
	/*
		StringBuilder is mutable.
		StringBuilder performs faster than string when appending multiple string values.
		Use StringBuilder when you need to append more than three or four strings.
		Use the Append() method to add or append strings to the StringBuilder object.
		Use the ToString() method to retrieve a string from the StringBuilder object.
	*/
	public class StringAndStringBuilder
	{
		/// In C#, String type là bất biến.(Nó không thể thay đổi được sau khi tạo)
		/// Khi được tạo nó sẽ lưu vào bộn nhớ heap
		/// Hành vi này sẽ làm giảm performance nếu chuỗi ban đầu thay đổi nhiều lần
		public static void PrintString()
		{
			string str = "LVT1234567";
			/// Khi thay đổi chuỗi khởi tạo ban đầu => sẽ tạo một đối tượng mới ở bộ nhớ heap thay vì sửa đổi nội dung ở chuỗi ban đầu ở cùng địa chỉ bộ nhớ
			str = "abc"; //
			Console.WriteLine(str);
		}
		public static void PrintStringBuilder()
		{
			string str = "LVT1234567";
			StringBuilder sb = new StringBuilder(10);
			// Capacity tự động nhân 2 khi chuỗi str vượt quá 10 kí tự, nếu vượt quá x2 thì max của nó là (2X10 + mỗi ký tự được thêm)
			sb.Append(str);
			Console.WriteLine(sb.Capacity);
			Console.WriteLine(sb);
		}

		public static void StringEx()
		{
			// * String là immutable (không thể thay đổi) và read-only sau khi được tạo trong bộ nhớ
			// Mỗi lần nối chuỗi .NET CLR sẽ tạo một vị trí bộ nhớ mới cho chuỗi đc nối => 
			// String không thể bao gồm  ngoặc kép bên trong ""
			// string str = "This is a "string" in C#."; // Compile time error
			// C# bao gồm ký tự gạch chéo ngược \ trước các ký tự đặc biệt (\,\n,\r,\t, ...) này để đưa vào 1 chuỗi
			string text = "This is a \"string\" in C#.";
			// note that you cannot use a backslash to allow " in a varbatim string. If you wish to include @, then use double double-quotes "" to include " in a verbatim string.
			string text1 = "This is a \"string\" in C#."; // valid
			// string text2 = @"This is a "string." in C#."; // error
			// string text3 = @"This is a \"string\" in C#."; // error
			// string text 4 = @"This is a ""string"" in C#."; // valid

			// Trong C#, String là 1 collection hoặc 1 mảng các ký tự => Chuỗi được tạo bằng char array hoặc được truy cập như char array
			char[] chars = {'H','e','l','l','o'};

			string str1 = new string(chars);
			String str2 = new String(chars);
			
			foreach (char c in str1)
			{
				Console.WriteLine(c);
			}

			// C# 6 bao gồm một ký tự đặc biệt $ để xác định một String Interpolation
			string firstName = "James";
			string lastName = "Bond";
			string code = "007";
			string fullName = $"Mr. {firstName} {lastName}, Code: {code}";
		}
	}
}
