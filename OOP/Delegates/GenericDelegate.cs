using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Delegates
{
	public delegate T MyDelegate<T>(T param1, T param2);
	public class GenericDelegate
	{
		public static void TestGenericDelegate()
		{
			MyDelegate<int> myDelegate = new MyDelegate<int>(Add); // Viết tắt là Add
			Console.WriteLine(myDelegate(10, 20));

			MyDelegate<string> myDelegateString = new MyDelegate<string>(Concat);
			Console.WriteLine(myDelegateString("Delegate ", "generic"));
		}

		public static int Add(int val1, int val2)
		{
			return val1 + val2;
		}

		public static string Concat(string str1, string str2)
		{
			return str1 + str2;
		}
	}
}
