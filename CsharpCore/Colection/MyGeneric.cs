using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCore.Colection
{
	/// <summary>
	/// Generic cho phép định nghĩa 1 hàm, mộ tlowsp mà không cần chỉ ra đối số kiểu dữ liệu là gì
	/// Tùy vào kiểu dữ liệu mà người dùng truyền vào thì sẽ hoạt động theo kiểu dữ liệu đó
	/// </summary>
	/// <typeparam name="T"></typeparam>
	internal class MyGeneric<T>
	{
		private T[] items;
		public T[] Items { get { return items; } }
		public MyGeneric(int size)
		{
			items = new T[size];
		}

		public T GetByIndex(int Index)
		{
			// Nếu index vượt ra khỏi chỉ số phần tử của mảng thì ném ra ngoại lệ
			if (Index < 0 || Index >= items.Length)
			{
				throw new IndexOutOfRangeException();
			}
			else
			{
				return items[Index];
			}
		}

		public void SetItemValue(int Index, T value)
		{
			if (Index < 0 || Index >=items.Length)
			{
				throw new IndexOutOfRangeException();
			}
			else
			{
				items[Index] = value;
			}
			Console.WriteLine(items[Index]);
		}
	}
}
