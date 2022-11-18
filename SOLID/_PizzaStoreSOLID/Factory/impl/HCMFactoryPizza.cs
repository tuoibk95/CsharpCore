using SOLID._PizzaStoreSOLID.PizzaRepository;
using SOLID._PizzaStoreSOLID.PizzaRepository.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._PizzaStoreSOLID.Factory.impl
{
	internal class HCMFactoryPizza : IFactoryPizza
	{
		public void CreatePizza(int pizzaType, List<string> toppingType, int soLuong)
		{
			Pizza pizza;
			switch (pizzaType)
			{
				case 0:
					pizza = new ChesePizza();
					break;
				case 1:
					pizza = new GreekPizza();
					break;
				case 2:
					pizza = new PepperoniPizza();
					break;
				default:
					return;
			}
			pizza.Prepare(toppingType);
			pizza.Bake();
			pizza.Box(soLuong);
			Console.WriteLine("Da lam & dong hop xong pizza");
		}
	}
}
