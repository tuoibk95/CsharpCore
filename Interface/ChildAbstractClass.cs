using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	public class ChildAbstractClass : AbstractClass
	{
		public override void Speak1()
		{
			Console.WriteLine("Speak1 ChildAbstractClass");
		}

		public void Test()
		{
			ChildAbstractClass childAbstractClass = new ChildAbstractClass();
			childAbstractClass.Speak1();
			childAbstractClass.Speak2();
			// Có thể ovveride của Speak3 method nếu cần implement khác với base class / không thì có thể dùng luôn
			childAbstractClass.Speak3();
		}
	}
}
