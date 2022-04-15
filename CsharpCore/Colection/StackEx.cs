using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCore.Colection
{
	/// <summary>
	/// Ngăn xếp: hoạt động theo nguyên lý LIFO (Last In First Out).
	/// - Là 1 DS lưu trữ các đối tượng nhưng không thể truy cập các phần tử thông qua chỉ số phần tử được.
	/// - Add (Push)
	/// - lấy phần tử ra (Pop). Và luôn lấy ra phần tử được thêm vào cuối cùng.
	/// </summary>
	internal class StackEx
	{
		public void toStack()
		{
			Stack stack = new Stack();
			stack.Push("Le");
			stack.Push("Van");
			stack.Push("Tuoi");
			Console.WriteLine(stack.Count);
			Console.WriteLine(stack.Peek());

			foreach (Object item in stack)
			{
				Console.Write(item);
			}
			Console.ReadLine();
		}
	}
}
