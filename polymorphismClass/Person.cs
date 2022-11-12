using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismClass
{
	public class Person
	{
		public virtual void Greet()
		{
			Console.WriteLine("Hi! I am a person.");
		}
	}
}
