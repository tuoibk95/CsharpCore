using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Delegates
{
	public delegate void MyDelegate(string msg);
	public delegate int MyDelegate1();
	public class MulticastDelegate
	{
		public static void TestMulticastDelegate()
		{
			MyDelegate del1 = classC.MethodC;
			MyDelegate del2 = classD.MethodD;

			// Thực hiện từ bến trái sang phải
			MyDelegate del = del1 + del2;
			del.Invoke("Hello del1 + del2: ");

			MyDelegate del3 = (string msg) => Console.WriteLine("Lamba expression: " + msg);
			del += del3; // del1 + del2 + del3
			del("=> lamba");
		}

		public static void TestIntMulticastDelegate()
		{
			MyDelegate1 del1 = classC.MethodE;
			MyDelegate1 del2 = classD.MethodF;

			// Nếu delegate trả về giá trị, thì giá trị của target method cuối sẽ được trả về when a multicast delegate called.
			MyDelegate1 del = del1 + del2;
			Console.WriteLine(del());
		}
	}
	public class classC
	{
		public static void MethodC(string msg)
		{
			Console.WriteLine("MethodA: " + msg);
		}

		public static int MethodE()
		{
			return 100;
		}
	}

	public class classD
	{
		public static void MethodD(string msg)
		{
			Console.WriteLine("MethodB: " + msg);
		}

		public static int MethodF()
		{
			return 200;
		}
	}

}
