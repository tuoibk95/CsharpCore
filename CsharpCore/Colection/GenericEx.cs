using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCore.Colection
{
	internal class GenericEx
	{
		public void change()
		{
			int a = 5, b = 6;
			Swap<int>(ref a, ref b);
			Console.WriteLine("a : {0}", a);
			Console.WriteLine("b : {0}", b);
		}
		public static void Swap<T>(ref T a, ref T b)
		{
			T temp = a;
			a = b;
			b = temp;
		}
	}
}
