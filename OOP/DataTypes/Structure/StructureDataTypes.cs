using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DataTypes.Structure
{
	/// <summary>
	/// struct is the value type data type that represents data structures.
	/// It can contain a parameterized constructor, static constructor, constants, fields, methods, properties, indexers, operators, events, and nested types.
	/// 
	/// The default modifier is internal for the struct and its members.
	/// </summary>
	struct Coordinate
	{
		/// <summary>
		/// struct can be used to hold small data values that do not require inheritance,
		/// e.g. coordinate points, key-value pairs, and complex data structure.
		/// </summary>
		public int x;
		public int y;
		/// <summary>
		/// struct không thể chứa 1 phương thức khởi tạo không tham số, Một phương thức khởi tạo trong một cấu trúc phải khởi tạo tất cả các trường trong contructor
		/// chỉ có thể chứa các hàm tạo được tham số hóa hoặc a static contructor.
		/// </summary>
		/// <param name="x"></param>
		public Coordinate(int x, int y) {
			this.x = x;
			this.y = y;
		}
	}
}
