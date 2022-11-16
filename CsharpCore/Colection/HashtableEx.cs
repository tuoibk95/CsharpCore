using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCore.Colection
{
	/* Là 1 colection lưu trữ data dạng key: value
	 * - Key đại diện cho 1 khóa giống như chỉ số phần tử của mảng, Value là giá trị tương ứng của key đó
	 * - key, value đều là kiểu object nên ta có thể lưu trữ được mọi data type từ cơ bản đến phức tạp
	 * implement : IDictionary
	 * Keys must be unique and cannot be null.
	 * Values can be null or duplicate.
	 * Elements are stored as DictionaryEntry objects.
	 */
	class HashtableEx
	{
		public void toHashtableEx()
		{
			Dictionary<int, string> dict = new Dictionary<int, string>();
			dict.Add(1, "one");
			dict.Add(2, "two");
			dict.Add(3, "three");

			Hashtable ht = new Hashtable(dict);
			ht.Add(4, "Kteam");
			ht.Add(5, "HowKteam");
			ht.Add(6, "Free Education");

			Console.WriteLine(ht[2]);

			foreach (DictionaryEntry list in ht)
			{
				Console.WriteLine(list.Key + "\t" + list.Value);
			}
			Console.ReadKey();

		}
	}
}
