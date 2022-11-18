using SOLID._PizzaStoreSOLID.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._PizzaStoreSOLID.Store
{
	internal interface IPizzaStore
	{
		void OrderPizza(int pizzaType, List<string> toppingType, int soLuong);
	}
}
