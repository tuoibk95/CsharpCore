using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DataTypes.TwoTypes
{
	/// <summary>
	/// Lưu trữ dữ liệu có độ dài thay đổi và khá đồ sộ (ví dụ: string, phương thức của một đối tượng);
	/// Khi lời gọi hàm kết thúc dữ liệu không được tống ra, mà ở nguyên tại chổ có thể trao cho phương thức khác.
	/// 
	/// Reference types include class types, interface types, delegate types, and array types.
	/// </summary>
	public class ReferenceTypes
	{
		static void ChangedReferenceType(string str)
		{
			str = "Hello";
			Console.WriteLine(str);
		}

		public static void TestReferenceType()
		{
			string st = "Hi";
			// Passing a string value to a function will create a new variable in the memory,
			// and any change in the value in the function will not be reflected in the original value
			ChangedReferenceType(st); // output Hello
			Console.WriteLine(st); // output Hi
		}
	}

	public class Hocsinh{
		private string FirstName;

		public static void ReferenceType(Hocsinh hs)
		{
			hs.FirstName = "LVT";
		}

		public static void TestReferenceTypes()
		{
			Hocsinh hocsinh = new Hocsinh();
			hocsinh.FirstName = "LVX";
			ReferenceType(hocsinh);
			// hs & hocsinh trỏ đến cùng địa chỉ trong bộ nhớ
			Console.WriteLine(hocsinh.FirstName); // output LVT
		}
	}
}
