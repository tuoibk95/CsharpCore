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

	}
}
