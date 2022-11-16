using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Data
{
	/// <summary>
	///			==												Equal()
	/// Compares the content of strings.				Compares the content of strings.
	/// Always compares case-sensitive.					Compares case-sensitive or insensitive, culture specific or invariant culture strings using StringComparison enum.
	/// Compares null values also.						Throws NullReferenceException if string is null.
	/// Cannot be overloaded.							Can be overloaded to customize it.
	/// 
	/// C# bao gồm 2 phương thức String.Compare() & String.CompareTo(): 
	/// 2 method này không nhằm so sánh sự bằng nhau của chuỗi mà để kiể tra vị trí tương đối của các chuỗi theo thứ tự đã sắp xếp => k dùng khi chỉ cần so sánh sự bằng nhau
	/// </summary>
	public class Compare
	{
		/// <summary>
		/// == được triển khai dưới dạng phương thức nạp chồng toán tử => phụ thuộc vào phương thức overload
		/// Phương thức Equal(): là 1 phương thức ảo và result phụ thuộc vào việc triển khai
		/// 
		/// </summary>
		/// <param name="==">Kiểm tra 2 toán hạng có bằng nhau hay không</param>
		/// <param name="Object.Equals()">Kiểm tra 2 object instance có bằng nhau hay không</param>
		public void CompareEqualAndBB()
		{
			// value type variable
			int j = 10, i = 10;
			long k = 10;
			Console.WriteLine( j == k);							// true
			Console.WriteLine( j.Equals(k));					// false
			Console.WriteLine(i == j);							// true
			Console.WriteLine(j.Equals(i));						// true
			// reference type variable: Cả 2 so sánh nội dung của chuỗi (*) phân biệt chữ hoa chữ thường
			string a = "Hello", b = "Hello", c = "hello", d = null;
			Console.WriteLine(a == b);							// true
			Console.WriteLine(a == c);							// false
			Console.WriteLine(a.Equals(b));						// true
			Console.WriteLine(a.Equals(c));						// false
			Console.WriteLine(a == d);							// false
			Console.WriteLine(d == a);							// false
			Console.WriteLine(a.Equals(d));						// false
//			Console.WriteLine(d.Equals(a)); // NullReferenceException
			Console.WriteLine(d?.Equals(a)); // K trả ra kq, để tránh exception

			string str1 = "London";
			string str2 = String.Copy(str1);
			Console.WriteLine(str1 == str2);					// true
			Console.WriteLine(str1.Equals(str2));				// true
			Console.WriteLine(Object.ReferenceEquals(str1, str2)); // false
			object obj1 = "London";

			Console.WriteLine(str1 == obj1);					// True
			Console.WriteLine(str1.Equals(obj1));				// True
			Console.WriteLine(obj1.Equals(str1));				// True

			// Use StringBuilder
			string str = "London";
			StringBuilder sb = new StringBuilder("London");
			object obj = sb.ToString();
			Console.WriteLine("====================================");
			Console.WriteLine(str == obj);						// False ???  // Khi chuyển đổi từ StringBuilder -> object nó gọi overload method khác nhau dẫn đến kết quả k đúng
			Console.WriteLine(str == sb.ToString());			// True
			Console.WriteLine(str.Equals(obj));					// True
			Console.WriteLine(obj.Equals(str));					// True
		}

	}
}
