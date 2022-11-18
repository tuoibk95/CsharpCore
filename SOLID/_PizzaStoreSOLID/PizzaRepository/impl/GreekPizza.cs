using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID._PizzaStoreSOLID.Enum;

namespace SOLID._PizzaStoreSOLID.PizzaRepository.impl
{
	internal class GreekPizza : Pizza
	{
		public GreekPizza()
		{
			Name = "Greek";
			Dough = Dough.Thick;
			Sauce = Sauce.Pepper;
		}
	}
}
