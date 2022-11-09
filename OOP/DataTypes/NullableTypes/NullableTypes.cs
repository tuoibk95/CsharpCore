using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DataTypes.NullableTypes
{
	/*
	 * Nullable<T> type allows assignment of null to value types.
		? operator is a shorthand syntax for Nullable types.
		Use value property to get the value of nullable type.
		Use HasValue property to check whether value is assigned to nullable type or not.
		Static Nullable class is a helper class to compare nullable types.
	 */
	internal class NullableTypes
	{
		public int? A = null;
		public static void TestNullableTypes()
		{
			// int? là ký hiệu viết tắt của Nullable<int>
			Nullable<int> i = null;
			//int? i = null;
			// Nếu i là null thì gán 3 vào j
			int j = i ?? 3;
			Console.WriteLine(j);
			// Nullable.Compare<Int32>(null,3) có giá trị -1
			if (Nullable.Compare<Int32>(i,j) < 0)
			{
				Console.WriteLine("i < j");
			}
			else if (Nullable.Compare<Int32>(i, j) > 0)
			{
				Console.WriteLine("i > j");
			}
			else
			{
				Console.WriteLine("i = j");
			}
		}
	}
}
