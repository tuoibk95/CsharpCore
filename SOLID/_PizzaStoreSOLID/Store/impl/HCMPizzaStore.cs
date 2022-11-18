using SOLID._PizzaStoreSOLID.Factory.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._PizzaStoreSOLID.Store.impl
{
	internal class HCMPizzaStore : IPizzaStore
	{
		public void OrderPizza(int pizzaType,List<string> toppingType, int soLuong)
		{
			HCMFactoryPizza factoryPizza = new HCMFactoryPizza();
			factoryPizza.CreatePizza(pizzaType, toppingType, soLuong);
			Console.WriteLine("Order success pizza type: " + pizzaType + " soLuong: " + soLuong);
		}
	}
}
