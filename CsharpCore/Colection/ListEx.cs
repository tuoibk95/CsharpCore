using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCore.Colection
{
	/// <summary>
	/// Là 1 Generic Colection: giống với ArrayList
	/// </summary>
	internal class ListEx
	{
		public void ToList()
		{
			List<string> list = new List<string>();
			list.Add("Free");
			list.Add("Education");
			Console.WriteLine(list.Count);
			foreach (var item in list)
			{
				Console.WriteLine(" " + item);
			}
			list.Insert(0, "HowKteam");
			bool isExists = list.Contains("Free");
			if (isExists)
			{
				Console.WriteLine("Có chứa");
			}
			else
			{
				Console.WriteLine("Không chứa.");
			}
		}
	}
}
