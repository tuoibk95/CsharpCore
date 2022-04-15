namespace MultiThread
{
	public class Asynchronous
	{
		public static async Task Main(string[] args)
		{
			var watch = new System.Diagnostics.Stopwatch();
			watch.Start();

			//Thread th_one = new Thread(ThreadOne);
			//Thread th_two = new Thread(ThreadTwo);

			// Luồng không bắt đầu chạy cho đến khi ta gọi phương thức start
			//th_one.Start();
			//th_two.Start();

			//// Chặn luồng tiếp tục cho tới khi các tiến trình th_one th_two hoàn thành
			//th_one.Join();
			//th_two.Join();

			//watch.Stop();

			//var task_one = TaskOne();
			//var task_two = TaskTwo();
			//Task.WaitAll(task_one, task_two);

			var task_one = await TaskOne();
			var task_two = await TaskTwo("LVT");
			Console.WriteLine(task_one);
			Console.WriteLine(task_two);

			Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
			Console.ReadKey();
		}

		private static void ThreadOne(object? obj)
		{
			Thread.Sleep(5000);
			Console.WriteLine("ThreadOne");
		}

		private static void ThreadTwo(object? obj)
		{
			Thread.Sleep(2000);
			Console.WriteLine("ThreadTwo");
		}

		private static async Task<string> TaskOne()
		{
			await Task.Delay(5000);
			return "TaskOne";
		}
		private static async Task<string> TaskTwo(string name)
		{
			await Task.Delay(2000);
			return "TaskTwo " + name;
		}
	}
}
