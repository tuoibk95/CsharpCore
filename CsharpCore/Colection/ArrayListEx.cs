using System.Collections;

namespace CsharpCore.Colection
{
	/// <summary>
	/// Là 1 collection non-generic và tự động tăng (dynamic array)
	/// Có thể chứa nhiều giá trị null và trùng lặp
	/// 
	/// Note: It is not recommended to use the ArrayList class due to performance issue.
	/// Instead, use List<object> to store heterogeneous objects.
	/// To store data of same data type, use Generic List<T>.
	/// </summary>
	internal class ArrayListEx
	{
		public void toArrayListEx()
		{
			// Là 1 colection lưu trữ và quản lý một danh sách các đối tượng theo kiểu mảng (truy cập thông qua chỉ số index)
			// Giống mảng trong object nhưng có thể thêm xóa phần tử 1 cách linh hoạt và có thể tự điều chỉnh size một cách tự động
			ArrayList arrayList = new ArrayList(); // không cần khởi tạo size như array
			// Có thể được sử dụng để thêm dữ liệu k xác định (unknown) khi k biết type and size của data.
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

			// recommend khuyến nghị
			var arrayListVar = new ArrayList();
			arrayListVar.Add(1);
			arrayListVar.Add("Bill");
			arrayListVar.Add(" ");
			arrayListVar.Add(4.5);
			arrayListVar.Add(null);

			for (int i = 0; i < arrayListVar.Count; i++)
			{
				Console.Write(arrayListVar[i] + ", ");
			}

			// or khuyến nghị sử dụng object initializer syntax
			var arrayListVar2 = new ArrayList()
			{
				2,"Steve", " ", 4.5, null
			};

			#region Use AddRange(ICollection c) method to add an entire Array, HashTable, SortedList, ArrayList, BitArray, Queue, and Stack in the ArrayList.
			int[] arr = { 100, 200, 300, 400 };

			Queue myQ = new Queue();
			myQ.Enqueue("Hello");
			myQ.Enqueue("World!");
			arrayListVar2.AddRange(arr);
			arrayListVar2.AddRange(myQ);
			#endregion

			#region ArrayList : IList => có thể sử dụng indexer để truy cập phần tử như array
			// Ép kiểu rõ ràng nếu muốn lấy giá trị theo index ra, hoặc có thể dụng var để tránh phải ép kiểu tường minh
			var arlist = new ArrayList()
				{
					1,
					"Bill",
					300,
					4.5f
				};

			//Access individual item using indexer
			int firstElement = (int)arlist[0];			//returns 1
			string secondElement = (string)arlist[1];	//returns "Bill"
			//int secondElement = (int) arlist[1]; //Error: cannot cover string to int

			//using var keyword without explicit casting
			var firstElement1 = arlist[0];				//returns 1
			var secondElement1 = arlist[1];				//returns "Bill"
			//var fifthElement = arlist[5]; //Error: Index out of range

			//update elements
			arlist[0] = "Steve";
			arlist[1] = 100;
			//arlist[5] = 500; //Error: Index out of range
			#endregion

			#region ArayList : ICollection => hỗ trợ lặp của kiểu collection
			ArrayList arrlist = new ArrayList()
						{
							1,
							"Bill",
							300,
							4.5F
						};

			foreach (var item in arrlist)
				Console.Write(item + ", "); //output: 1, Bill, 300, 4.5, 

			for (int i = 0; i < arrlist.Count; i++)
				Console.Write(arlist[i] + ", "); //output: 1, Bill, 300, 4.5, 
			#endregion

			#region Insert, InsertRange(),Remove, Check Elements in ArrayList

			#endregion
		}
	}
}
