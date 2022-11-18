using SOLID._PizzaStoreSOLID.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._PizzaStoreSOLID.PizzaRepository
{
	public abstract class Pizza
	{
		public Pizza()
		{

		}
		~Pizza() { }
		private struct STT
		{
			public static int Id { get; set; }
			public static string? Name { get; set; }
			public const string Point = "Point";
			public STT(int id, string name)
			{
				Id = id;
				Name = name;
			}
		}

		protected string? Name { get; set; }
		protected Dough Dough { get; set; }
		protected Sauce Sauce { get; set; }

		public void Prepare(List<string> topping)
		{
			topping.ForEach(x => Console.WriteLine(x));
		}
		// sử dụng virtual để class kế thừa có thể override theo cách nướng của riêng họ
		public virtual void Bake()
		{
			Console.WriteLine("Bake name: " + Name + " dough: " + Dough + " Sauce: " + Sauce);
		}

		public void Box(int soLuong)
		{
			Console.WriteLine("Box so luong: " + soLuong + " Point: " + STT.Point);
		}
	}
}
