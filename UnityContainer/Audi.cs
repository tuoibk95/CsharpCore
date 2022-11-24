using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityContainerEx
{
	public class Audi : ICar
	{
		private int _miles = 0;
		public int Run()
		{
			return ++_miles;
		}
	}
}
