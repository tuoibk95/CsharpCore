using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreStatic.StaticTeacher;

namespace CoreStatic
{
	internal class Startup
	{
		static int counter = 0;
		public static void Main(string[] args)
		{
			Console.WriteLine(Cat.Count);
			Console.WriteLine(TienIch.LuyThua(3, 3));
			Console.WriteLine("====================================");
			TestStaticTeacher();
		}

		public static void TestStaticTeacher()
		{
			Console.WriteLine(Calculator.Sum(1,2));
			Console.WriteLine(Calculator.Type);
			StopWatch.DisplayInfo();
			StopWatch sw1 = new StopWatch();
			StopWatch sw2 = new StopWatch();
			Console.WriteLine(StopWatch.NoOfInstances); //2 

			StopWatch sw3 = new StopWatch();
			StopWatch sw4 = new StopWatch();
			Console.WriteLine(StopWatch.NoOfInstances);//4

			Display("Hello World!");
		}
		/// <summary>
		/// Static methods cannot access or call non-static variables unless they are explicitly passed as parameters.
		/// Static methods can be overloaded but cannot be overridden.
		/// </summary>
		/// <param name="text"></param>
		public static void Display(string text)
		{
			Console.WriteLine(text);
		}
	}
}
