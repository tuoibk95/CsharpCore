using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismClass
{
	public class Employee : Person
	{
		public override void Greet()
		{
			Console.WriteLine("Hello! I am an employee.");
		}
	}
}
