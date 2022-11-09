using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DataTypes.TwoTypes
{
	/// <summary>
	/// const: phải được gán giá trị khi khai báo/ Là hằng số được khởi tạo khi biên dịch chương trình
	/// read-only: không cần khởi tạo trước - khi gán giá trị thì sau đó không thay đổi được / là hằng số được khởi tạo khi thực thi chương trình
	/// </summary>
	public class Constant
	{
		/// Có 3 loại hằng : 
		/// - giá trị hằng: literal
		/// - Biểu tượng hằng: symbolic constants
		/// - Kiểu liệt kê: enumerations
		const int X = 5;
		readonly int yy;
		public Constant()
		{
			yy = 30;
		}
	}
}
