using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Articles.Asynchronous;
using Articles.Asynchronous;

namespace Articles
{
	/// <summary>
	/// asynchronous method sẽ trả về void, Task, or Task<TResult>: TResult là kiểu trả về của method
	/// </summary>
	public class Program
	{
		public static async Task Main(string[] args)
		{
			//Synchoronous.TestSynchronous();
			//AsynchronousThread.TestAsynchronous();

			#region Sử dụng với Task<TResul> đặt tại phương thức Main()
			//Task<int> result = AsynchronousTask.LongProcess();
			//AsynchronousTask.ShortProcess();
			//// async keyword cho phép sử dụng await trong method để ta có thể đợi phương thức asynchronous hoàn thành cho các phương thức khác phụ thuộc vào giá trị trả về
			//var val = await result; // wait untile get the return value from asynchronous method complete vì phương thức ở dưới có sử dụng giá trị đó
			//Console.WriteLine("Result: {0}", val);
			//Console.ReadKey();
			#endregion

			#region multi asynchronous method
			Task<int> result1 = MultiAsynchronousMethod.LongProcess1();
			Task<int> result2 = MultiAsynchronousMethod.LongProcess2();
			MultiAsynchronousMethod.ShortProcess();
			//do something here
			Console.WriteLine("After two long processes.");

			var val1 = await result1; // wait untile get the return value
			Console.WriteLine("Result: {0}", val1);
			var val2 = await result2; // wait untile get the return value
			Console.WriteLine("Result: {0}", val2);
			Console.ReadKey();
			#endregion
		}
	}
}
