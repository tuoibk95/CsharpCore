using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.InterfaceTutorials
{
	public class NormalClass
	{
		// abstract method chỉ có trong abstract class
		//public abstract void AbstractMethod();
		public virtual void VirtualMethod()
		{
			Console.WriteLine("Virtual method print...");
		}
	}
}
