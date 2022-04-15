using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCore.ThreadTasks
{
	public class Tasks
	{
		//public static async void Main(string[] args) {
		//	Console.WriteLine("Thread and Async/Await...");

		//	var watch = new System.Diagnostics.Stopwatch();
		//	watch.Start();

		//	await TaskOne();
		//	await TaskTwo();
		//}

		public static async Task TaskOne() {
			await Task.Delay(5000);
			Console.WriteLine("TaskOne");
		}
		public static async Task TaskTwo() {
			await Task.Delay(2000);
			Console.WriteLine("TaskTwo");
		}
	}

	interface a
	{
		public void c();
	}
	interface b
	{
		public void c();
	}

	public class d : a, b
	{
		public void c()
		{
			Console.WriteLine("TaskTwo");
		}
	}

	public abstract class E { };
}
