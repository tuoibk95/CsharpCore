using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCore.AccessModifier
{
	class F
	{
		public void Test() {
			Console.WriteLine("Constant = " + PublicAccessModifier.MY_CONSTANT);
			PublicAccessModifier publicAccessModifier = new PublicAccessModifier();
			publicAccessModifier.Myfield = 2000;
			publicAccessModifier.MyMethod();
		}
	}
}
