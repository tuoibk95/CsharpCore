using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID._PizzaStoreSOLID.PizzaRepository;
using SOLID._PizzaStoreSOLID.PizzaRepository.impl;
using SOLID._PizzaStoreSOLID.Store;
using SOLID._PizzaStoreSOLID.Store.impl;

namespace SOLID._PizzaStoreSOLID.Factory
{
	internal interface IFactoryPizza
	{
		public void CreatePizza(int pizzaType, List<string> toppingType, int soLuong);
	}
}
