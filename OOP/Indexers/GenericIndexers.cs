using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Indexers
{
	public class GenericIndexers<T>
	{
		private T[] store;
		public GenericIndexers()
		{
			store = new T[6];
		}
		public GenericIndexers(int length)
		{
			store = new T[length];
		}

		public T this[int index]
		{
			get {
				if (index < 0 && index >= store.Length)
				{
					throw new IndexOutOfRangeException("Index out of range");
				}
				return store[index];
			}
			set
			{
				if (index < 0 && index >= store.Length)
				{
					throw new IndexOutOfRangeException("Index out of range");
				}
				store[index] = value;
			}
		}

		public int Length { get { return store.Length; } }

		public static void TestGenericIndexers()
		{
			GenericIndexers<int> genericIndexers = new GenericIndexers<int>();
			genericIndexers[0] = 1;
			genericIndexers[1] = 2;
			genericIndexers[2] = 3;
			genericIndexers[3] = 4;
			genericIndexers[4] = 5;

			for (int i = 0; i < genericIndexers.Length; i++)
			{
				Console.Write(genericIndexers[i]);
			}
			Console.Write("+++++++++++++++++++++++++");

			GenericIndexers<string> strGenericIndexers = new GenericIndexers<string>(5);
			strGenericIndexers[0] = "A";
			strGenericIndexers[1] = "B";
			strGenericIndexers[2] = "C";
			strGenericIndexers[3] = "D";
			strGenericIndexers[4] = "E";
			for (int i = 0; i < strGenericIndexers.Length; i++)
			{
				Console.Write(strGenericIndexers[i]);
			}
		}
	}
}
