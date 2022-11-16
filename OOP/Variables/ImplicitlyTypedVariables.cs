using System;
using System.Collections.Generic;
using System.Text;

namespace Variables
{
	/// <summary>
	/// Phải khởi tạo giá trị ban đầu cho biến tại thời điểm khai báo
	/// Không thể khai báo biến var trong 1 câu lệnh duy nhất
	/// Biến var không thể được dùng cho param của phương thức
	/// biến var có thể được sử dụng cho: build-in data type, 2- user defined type, 3 - anonymous type.
	/// biến kiểu ngầm định
	/// </summary>
	public class ImplicitlyTypedVariables
	{
		public void PrintImplicitlyType()
		{
			/// <summary>
			/// Implicitly-typed variables must be initialized at the time of declaration
			/// </summary>
			var IVar = 10;
			/// <summary>
			/// Multiple declarations of var variables in a single statement are not allowed.
			/// </summary>
//			var i = 100, j = 200, k = 300; // Error: cannot declare var variables in a single statement

			/// <summary>
			/// The followings are also valid
			/// <summary>
			var M = 100;
			var N = 200;
			var L = 300;

			/// <summary>
			/// var cannot be used for function parameters.
			/// <summary>
//			void Display(var param) { }//Compile-time error
		}
	}
}
