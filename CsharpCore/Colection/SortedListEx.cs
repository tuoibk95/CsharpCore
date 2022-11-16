using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCore.Colection
{
	/// <summary>
	/// Là 1 Hashtable nhưng các giá trị được sắp xếp theo Key.
	/// Việc sắp xếp này được thực hiện auto mỗi khi thêm 1 phần tử mới vào SortedList
	/// Có thể truy xuất phần tử trong SortedList thông qua Key(Hashtable), chỉ số phần tử (ArrayList) => Là sự kết hợp của cả 2
	/// </summary>
	internal class SortedListEx
	{
		public void toSortedList()
		{
			SortedList mySL = new SortedList();
			mySL.Add("2", "two");
			mySL.Add("1", "one");
			mySL.Add("4", "four");
			mySL.Add("3", "three");
			Console.WriteLine(mySL.Count);
			Console.WriteLine(mySL.Capacity);

			foreach (DictionaryEntry item in mySL)
			{
				Console.WriteLine(item.Key + "\t" + item.Value);
			}
			Console.ReadKey();
		}
	}
}
