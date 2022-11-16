using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TestNumber
{
	public class TestNumber1
	{
		public void TestNumberQuestion1()
		{
			int i;
//			Console.WriteLine(i); // Compile-time error: Biến value type - compile time - stack
			int k;
//			Display(k); // Compile-time error: Biến value type - compile time - stack
		}

		static void Display(int val = 0)
		{
			Console.WriteLine(val);
		}
	}
}
