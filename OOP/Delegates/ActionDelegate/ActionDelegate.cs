using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Delegates.ActionDelegate
{
	public class ActionDelegate
	{
		// Action delegate type không có kiểu trả về (kiểu trả về phải là void)
		// can have input param 0-16
		static Action<int, int> sumAction;
		public static void TestActionDelegate()
		{
			//sumAction = delegate (int x, int y)
			//{
			//	Console.WriteLine(x + y);
			//};
			sumAction = (x, y) => Console.WriteLine(x + y);
			sumAction(20,30);
		}
	}
}
