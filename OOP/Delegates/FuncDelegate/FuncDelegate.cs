using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Delegates.FuncDelegate
{
	/// <summary>
	/// public delegate TResult Func<in T, out TResult>(T arg);
	/// T: param type input / TResult : param type output
	/// param cuối cùng trong dấu ngoặc nhọn<> là kiểu trả về
	/// các param còn lại là kiểu input parameter 
	/// </summary>
	public class FuncDelegate
	{
		// 2 input parameter & 1 output parameter
		// Func được built in delegate type
		// Func delegate type phải trả về 1 giá trị, không cho phép từ khóa ref & out in parameter
		public static Func<int, int, int> sumFunc;
		public static Func<int> getRamdomNumber;
		public static void TestFunc()
		{
			//Func<int, int, int> funcDelegate = delegate(int x, int y)
			//{
			//	return x + y;
			//};
			// Sử dụng Sum method cho code tường minh hơn
			sumFunc = Sum;
			int result = sumFunc(10,20); // sử dụng funcDelegate sẽ callback Sum method để thực thi
			Console.WriteLine(result);
		}

		public static void TestFunc1()
		{
			getRamdomNumber = GetRandom;
			// Anonymouse method
			//Func<int> func1 = delegate ()
			//{
			//	Random rand = new Random();
			//	return rand.Next(1, 100);
			//};
			//Func<int> func2 =  () =>
			//{
			//	Random rand = new Random();
			//	return rand.Next(1, 100);
			//};
			//// Lambda expression
			//Func<int> func3 = () => new Random().Next(1, 100);
			Console.WriteLine(getRamdomNumber());
		}

		public static int GetRandom()
		{
			Random rand = new Random();
			return rand.Next(1,100);
		}

		static int Sum(int x, int y)
		{
			return x + y;
		}

	}
}
