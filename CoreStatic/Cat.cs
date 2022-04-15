using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreStatic
{
	internal class Cat
	{
		private int weight;
		private int height;
		public static int Count = 0;
		public  int Dem = 0;

		public int Weight
		{
			get { return weight; }
			set { weight = value; }
		}

		public int Height
		{
			get => height; 
			set => height = value;
		}
		
		public Cat()
		{
			Weight = 20;
			Height = 50;
			Count++;
			Dem++;
		}
	}
}
