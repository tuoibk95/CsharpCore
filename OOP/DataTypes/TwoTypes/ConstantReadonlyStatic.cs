using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DataTypes.TwoTypes
{
	public class ConstantReadonlyStatic
	{
		/// <summary>
		/// Có 3 loại hằng : 
		/// - giá trị hằng: literal
		/// - Biểu tượng hằng: symbolic constants
		/// - Kiểu liệt kê: enumerations
		/// 
		/// 0 - default a const is static that cannot be changed.
		/// 1 - Only the class level fields or variables can be constant.
		/// 2 - The constant fields must be initialized at the time of declaration.
		///		Therefore, const variables are used for compile-time constants.
		/// 3 - Constant variables cannot be modified after declaration.
		/// 4 - Const members can be accessed using ClassName.ConstVariableName, but cannot be accessed using object.
		/// <summary>
		public const int xx = 5;
		/// <summary>
		/// 1 - Only the class level fields can be readonly. The local variables of methods cannot be readonly.
		/// 2 - Readonly fields can be initialized at declaration or in the constructor.
		///		Therefore, readonly variables are used for the run-time constants.
		/// 3 - Readonly variable cannot be modified at run-time. It can only be initialized or changed in the constructor.
		/// 4 - Readonly members can be accessed using object, but not ClassName.ReadOnlyVariableName.
		/// </summary>
		public readonly int yy = 20;
		/// <summary>
		/// 1 - Can be static: classes, constructors, methods, variables, properties, event and operators 
		///		Cannot be static: the struct, indexers, enum, destructors, or finalizers 
		/// 2 - Static members can only be accessed within the static methods. The non-static methods cannot access static members.
		/// 3 - Value of the static members can be modified using ClassName.StaticMemberName. but cannot be accessed using object.
		/// Biến static k thể được tạo trong method
		/// </summary>
		public static int zz = 20;
		public ConstantReadonlyStatic()
		{
			// Readonly fields can be initialized at declaration or in the constructor.
			yy = 30;
		}
		public static void TestConstant()
		{
			zz = 40;
			if (zz == 40)
			{
				zz = 50;
				Console.WriteLine(zz);
			}
			Console.WriteLine(ConstantReadonlyStatic.xx); // Const members can be accessed using ClassName.ConstVariableName, but cannot be accessed using object.
			Console.WriteLine(ConstantReadonlyStatic.zz); // Value of the static members can be modified using ClassName.StaticMemberName. but cannot be accessed using object.
			ConstantReadonlyStatic constant = new ConstantReadonlyStatic();
			Console.WriteLine(constant.yy); // Readonly members can be accessed using object, but not ClassName.ReadOnlyVariableName.
		}
	}
}
