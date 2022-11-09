using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DataTypes.TwoTypes
{
	/// <summary>
	/// Lưu trữ dữ liệu có độ dài cố định
	/// Khi hàm được gọi thì tất cả các biến cục bộ được ấn vào Stack, khi gọi thành công thì các biến cục bộ được tống ra
	/// 
	/// Value types include simple types (Built In: (Kiểu xây dựng sẵn) such as int, float, bool, and char), enum types, struct types(User defined), and Nullable value types
	/// Có 3 cách chuyển kiểu từ string to int: Int32.Parse(), Int32.TryParse() method, Convert.ToInt32() class
	/// </summary>
	public class ValueTypes
	{
		// C# 7.1 onwards
		//int i = default; // 0
		//float f = default;// 0
		//decimal d = default;// 0
		//bool b = default;// false
		//char c = default;// '\0'
		#region enumeration
		private enum HocLuc
		{
			Kem = 0,
			TrungBinh = 1,
			Kha = 2,
			Gioi = 3
		}
		#endregion

		#region struct
		private struct ParamCodeType
		{
			public const string NEW = "New";
			public const string MOD = "Mod";
			public const string VIEW = "View";
			public const string COPY = "Copy";
			public const string COPYQ = "CopyQ";
		}
		#endregion
	}
}
