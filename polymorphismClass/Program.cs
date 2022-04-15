using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismClass
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Animal cat = new Cat();
			Animal dog = new Dog();
			//  2 đối tượng dog, cat được cấp phát 2 vùng nhớ thuộc 2 lớp 2 khác nhau nhưng khi cùng gọi phương thức Speak()
			//  thì đối tượng tham chiếu đến vùng nhớ của lớp nào sẽ được gọi đúng phương thức của lớp đó.
			cat.Speak();
			dog.Speak();
		}
	}
}
