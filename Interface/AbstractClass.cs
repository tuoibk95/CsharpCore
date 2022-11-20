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
		/// <summary>
		/// Phương thức abstract k có triên khai trong body
		/// Lớp kế thừa AbstractClass bắt buộc phải implement
		/// Chỉ có trong abstract class
		/// </summary>
		public abstract void Speak1();
		public void Speak2() { }
		/// <summary>
		/// Nếu muốn lớp kế thừa có thể override thì thêm từ khóa virtual vào phương thức
		/// Có trong cả lớp abstract và normal
		/// </summary>
		public virtual void Speak3()
		{
			Console.WriteLine("123");
		}
	}
}
