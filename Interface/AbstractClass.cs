using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	// Không thể tạo được instance của Abstract class & interface
	public abstract class AbstractClass
	{
		protected int Age = 10;
		public AbstractClass() { }
		~AbstractClass() { }
		public abstract void Speak1();
		public void Speak2() { }
	}
}
