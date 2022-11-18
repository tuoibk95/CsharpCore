using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID._PizzaStoreSOLID.Enum;

namespace SOLID._PizzaStoreSOLID.PizzaRepository.impl
{
	internal class PepperoniPizza : Pizza
	{
		public PepperoniPizza()
		{
			Name = "Pepperoni";
			Dough = Dough.Thin;
			Sauce = Sauce.Chilli;
		}
	}
}
