using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCore.Colection
{
	/// <summary>
	///  Hàng đợi: FIFO (First In First Out)
	/// - Là danh sách lưu trữ các đối tượng nhưng không thể truy cập các phần tử thông qua chỉ số phần tử được.
	/// Hành động thêm vào Queue - Enqueue (Xếp hàng)
	/// Hành động lấy phần tử ra khỏi Queue - Dequeue (Ra khỏi hàng) Và luôn lấy ra phần tử được thêm từ đầu tiên
	/// </summary>
	internal class QueueEx
	{
		public void toQueue()
		{
			Queue queue = new Queue();
			queue.Enqueue("Luc ");
			queue.Enqueue("Van ");
			queue.Enqueue("Tien");

			foreach (Object item in queue)
			{
				Console.WriteLine(item);
			}
		}
	}
}
