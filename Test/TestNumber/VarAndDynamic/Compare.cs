using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TestNumber.VarAndDynamic
{
	public class Compare
	{
		#region C# 3.0 Var variable
		/// <summary>
		/// Phải khởi tạo giá trị ban đầu cho biến tại thời điểm khai báo (kiểu dữ liệu được chỉ ra tại compile time)
		/// Không thể khai báo biến var trong 1 câu lệnh duy nhất
		/// Biến var không thể được dùng cho param của phương thức
		/// biến var có thể được sử dụng cho: build-in data type, 2- user defined type, 3 - anonymous type.
		/// biến kiểu ngầm định
		/// Không cho phép thay đổi kiểu dữ liệu sau khi khai báo
		/// </summary>
		#endregion

		#region C# 4.0 .NET 4.5
		/// Không cần khởi tạo giá trị ban đầu cho biến tại thời điểm khai báo
		/// Tránh kiểm tra kiểu compile time, Nó kiểu giải quyết at run time
		/// kiểu dynamic thay đổi kiểu at run time dựa trên giá trị gán.
		/// Cho phép thay đổi kiểu dữ liệu sau khi khai báo
		#endregion
	}
}
