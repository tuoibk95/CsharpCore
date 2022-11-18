using SOLID._PizzaStoreSOLID.Factory.impl;
using SOLID._PizzaStoreSOLID.PizzaRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._PizzaStoreSOLID.Store.impl
{
	internal class HNPizzaPizzaStore : IPizzaStore
	{
		public void OrderPizza(int pizzaType,List<string> toppingType, int soLuong)
		{
			HNFactoryPizza factoryPizza = new HNFactoryPizza();
			factoryPizza.CreatePizza(pizzaType, toppingType, soLuong);
			Console.WriteLine("Order success pizza type: " + pizzaType + " soLuong: " + soLuong);
		}
	}
}
