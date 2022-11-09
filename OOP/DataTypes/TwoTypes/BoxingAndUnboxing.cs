using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP.DataTypes.TwoTypes
{
	/// <summary>
	/// Stack Ngăn xếp trong lập trình (LIFO). data structure
	/// Heap Vùng lưu trữ đặc biệt trong bộ nhớ dùng để cất giữ tài liệu quan trọng. All reference types được lưu trữ ở đây.
	/// Ở heap chỉ chứa địa chỉ của value và value type thực sự được lưu ở trên stack.
	/// 
	/// Boxing and unboxing degrade the performance. + làm giảm hiệu năng
	/// So, avoid using it.+ Tránh sử dụng nó
	/// Use generics to avoid boxing and unboxing. For example, use List instead of ArrayList.
	/// </summary>
	public class BoxingAndUnboxing
	{
		/// <summary>
		/// Boxing is the process of converting a value type to the object type or any interface type implemented by this value type. Boxing is implicit.
		/// </summary>
		public static void PerformsBoxing()
		{
			int i = 10;
			// This process of converting int to object is called boxing.
			object o = i; // performs boxing
			o = 20;
			// A boxing conversion makes a copy of the value. So, changing the value of one variable will not impact others.
			Console.WriteLine(i); // output: 10
			Console.WriteLine(o);
			// Arraylist is a class in C# => reference type
			ArrayList list = new ArrayList();
			// Add an int value 10 in it. So, .NET will perform the boxing process here to asign value type to reference type.
			list.Add(i); // boxing
		}

		/// <summary>
		/// Unboxing is the reverse of boxing.
		/// It is the process of converting a reference type to value type.
		/// Unboxing extract the value from the reference type and assign it to a value type.
		/// </summary>
		public static void PerformsUnboxing()
		{
			object o = 10;
			int i = (int)o; // performs unboxing
		}

		public static void CastingBoxed()
		{
			int i = 10;
			object o = i; // performs boxing
//			double d = (double)o; // InvalidCastException 'Unable to cast object of type 'System.Int32' to type 'System.Double'.
//			int doub = (int)o; // valid
			double doub = (double)(int)o; // valid
			Console.WriteLine(doub);
		}
	}

	/// <summary>
	/// Có 2 cách chuyển đổi kiểu dữ liệu
	/// Ngầm định: Implicit type-cast
	/// Tường minh: explicit type-cast
	/// </summary>

	public class TypeCast
	{
		/// <summary>
		/// C# tự thực hiện, dev không cần can thiệp
		/// </summary>
		public static void ImplicitTypeCast()
		{
			// - Ép từ kiểu nhỏ qua kiểu lớn: int -> long, float -> double, long -> float, byte -> short
			int i = 59;
			double x = i;
			// - Ép từ lớp cơ sở -> lớp dẫn xuất
			string str = "LVT";
			object obj = str;
		}

		/// <summary>
		/// Do dev chỉ định
		/// </summary>
		public static void ExplicitTypeCast()
		{
			// Chuyển từ kiểu lớn sang kiểu nhỏ (kiểu nhỏ bound)
			double x = 19.95;
			int i = (int) x; // i = 19 mất giá trị
			// Chuyển từ lớp dẫn xuất -> lớp cơ sở
			string str = "Hello";
			object obj = str;
			string str2 = (string) obj;
		}

		#region Chuyển kiểu

		#endregion
	}
}
