using SOLID._PizzaStoreSOLID.Enum;
using SOLID._PizzaStoreSOLID.Store;
using SOLID._PizzaStoreSOLID.Store.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._PizzaStoreSOLID
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			List<string> listsTopping = new List<string>()
			{
				"Mushrooms", "Onions", "Bacon"
			};
			IPizzaStore pizzaHN = new HNPizzaPizzaStore();
			pizzaHN.OrderPizza((int)PizzaType.Chese, listsTopping, (int)Topping.Onions);
			Console.WriteLine("Da dua den khach hang thanh cong");
			Console.ReadLine();
		}
	}
}
