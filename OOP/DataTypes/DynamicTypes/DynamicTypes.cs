using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DataTypes.DynamicTypes
{
	/// <summary>
	/// Dynamic types change types at run-time based on the assigned value.
	/// </summary>
	internal class DynamicTypes
	{
		public static void TestDynamicType()
		{
			dynamic MyDynamicVar = 100;
			Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

			MyDynamicVar = "Hello World!!";
			Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

			MyDynamicVar = true;
			Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

			MyDynamicVar = DateTime.Now;
			Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

			dynamic d1 = 100;
			int i = d1;
			Console.WriteLine(i + " is type: " + i.GetType());
		}
	}
}
