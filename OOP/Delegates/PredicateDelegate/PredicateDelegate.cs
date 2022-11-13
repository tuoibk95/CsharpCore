using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Delegates.PredicateDelegate
{
	/// <summary>
	/// Predicate đại diện cho 1 method có chứa tập hợp các tiêu chí và kiểm tra xem tham số đã truyền có đáp ứng các tiêu chí đó hay không
	/// Predicate phải có 1 input param và trả về boolean
	/// </summary>
	public class PredicateDelegate
	{
		public static void TestPredicate()
		{
			// anonymous method
			Predicate<int> predicate = delegate (int i)
			{
				return i.Equals(5);
			};
			//Predicate<int> predicate1 = CompareTwoInt;
			Predicate<int> predicate2 = (i) => { return i.Equals(5); };
			// Lambda expression
			Predicate<int> predicate3 = (i) => i.Equals(5); 
			Predicate<int> predicate4 = i => i.Equals(5);
			bool result = predicate(5);
			Console.WriteLine(result);
		}

		public static bool CompareTwoInt(int x)
		{
			bool result = false;
			result = x.Equals(5);
			return result;
		}

	}
}
