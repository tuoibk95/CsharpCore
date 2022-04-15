using System.Threading;

class Program
{
	static void DemoThread(string threadIndex)
	{
		for (int i = 0; i < 3; i++)
		{
//			Thread.Sleep(TimeSpan.FromSeconds(1));
			Console.WriteLine(i);
			Console.WriteLine(threadIndex + " - " + i);
		}
	}

	//public static void Main()
	//{
	//	for (int i = 0; i < 5; i++)
	//	{
	//		// có thể dùng foreach để thay thế
	//		// nếu không tạo biến thì có thể chương trình chạy sẽ bị miss thread, 1 thread chạy vài lần
	//		int tempI = i;
	//		Thread t = new Thread(() =>
	//		{
	//			DemoThread("Thread " + tempI);
	//		});
	//		t.Start();
	//		// Tránh vòng lặp vô tận: khi chương trình tắt thì thread sẽ được giải phóng
	//		// ngược lại nếu là false thì thread chạy xong mới có thể kết thúc
	//		t.IsBackground = true;
	//	}
	//}
}
