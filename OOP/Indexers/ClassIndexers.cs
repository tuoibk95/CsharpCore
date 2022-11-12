using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Indexers
{
	public class ClassIndexers
	{
		private string[] strArr = new string[10];
		public string this[int index]
		{
			get
			{
				if (index < 0 || index > strArr.Length)
				{
					throw new IndexOutOfRangeException("Index out of range");
				}
				return strArr[index];
			}
			set
			{
				if (index < 0 || index > strArr.Length)
				{
					throw new IndexOutOfRangeException("Index out of range");
				}
				strArr[index] = value;
			}
		}

		public static void TestIndexers()
		{
			ClassIndexers stringDataStore = new ClassIndexers();
			stringDataStore[0] = "One";
			stringDataStore[1] = "Two";
			stringDataStore[2] = "Three";
			stringDataStore[3] = "Four";

			for (int i = 0; i < 10; i++)
			{
				Console.Write(stringDataStore[i] + " ");
			}
		}

		// Overload
		public string this[string name]
		{
			get
			{
				foreach (string str in strArr)
				{
					if (str.ToLower() == name.ToLower())
						return str;
				}
				return null;
			}
		}

		public static void TestOverloadIndexers()
		{
			ClassIndexers stringDataStore = new ClassIndexers();
			stringDataStore[0] = "One";
			stringDataStore[1] = "Two";
			stringDataStore[2] = "Three";
			stringDataStore[3] = "Four";

			Console.WriteLine(stringDataStore["one"]);
			Console.WriteLine(stringDataStore[0]);
		}
	}
}
