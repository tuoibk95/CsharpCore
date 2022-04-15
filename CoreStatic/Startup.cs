using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreStatic
{
	internal class Startup
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(Cat.Count);
			Console.WriteLine(TienIch.LuyThua(3, 3));
		}
	}
}
