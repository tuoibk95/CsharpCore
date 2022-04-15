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
	 */
	class HashtableEx
	{
		public void toHashtableEx()
		{
			Hashtable ht = new Hashtable();
			ht.Add("K", "Kteam");
			ht.Add("H", "HowKteam");
			ht.Add("FE", "Free Education");

			Console.WriteLine(ht["K"]);

			foreach (DictionaryEntry list in ht)
			{
				Console.WriteLine(list.Key + "\t" + list.Value);
			}
			Console.ReadKey();
		}
	}
}
