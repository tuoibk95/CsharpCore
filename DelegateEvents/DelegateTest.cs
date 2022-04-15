using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvents
{
	public class DelegateTest
	{
		delegate int NumberChanger(int changer);

		static int num = 10;

		public static int AddNum(int a)
		{
			num += a;
			return num;
		}

		public static int MultNum(int b)
		{
			num *= b;
			return num;
		}

		public static int GetNum()
		{
			return num;
		}

		//public static void Main(string[] args)
		//{
		//	NumberChanger numberChanger = new NumberChanger(MultNum);
		//	numberChanger(5);
		//	Console.WriteLine(GetNum());
		//}
	}
}
