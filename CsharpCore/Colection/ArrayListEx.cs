using System.Collections;

namespace CsharpCore.Colection
{
	internal class ArrayListEx
	{
		public void toArrayListEx()
		{
			// Là 1 colection lưu trữ và quản lý một danh sách các đối tượng theo kiểu mảng (truy cập thông qua chỉ số index)
			// Giống mảng trong object nhưng có thể thêm xóa phần tử 1 cách linh hoạt và có thể tự điều chỉnh size một cách tự động
			ArrayList arrayList = new ArrayList();
			arrayList.Add("Vo ");
			arrayList.Add("Lam ");
			arrayList.Add("Truyen ");
			arrayList.Add("Ky ");

			Console.WriteLine("Count : {0}", arrayList.Count);
			Console.WriteLine("Capacity: {0}", arrayList.Capacity);

			foreach (object i in arrayList)
			{
				Console.Write(i);
			}
		}
	}
}
