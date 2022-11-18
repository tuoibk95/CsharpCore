using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID._PizzaStoreSOLID.Enum;

namespace SOLID._PizzaStoreSOLID.PizzaRepository.impl
{
	internal class ChesePizza : Pizza
	{
		public ChesePizza()
		{
			Name = "Chese";
			Dough = Dough.Thin;
			Sauce = Sauce.Tomato;
		}

		public override void Bake()
		{
			Console.WriteLine("Nuong 20 p" + "Bake name: " + Name + " dough: " + Dough + " Sauce: " + Sauce);
		}
	}
}
