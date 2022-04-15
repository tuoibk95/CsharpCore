using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
	public class StructEx
	{
		static void Main(string[] args)
		{
			Product productA = new Product();
			productA.Name = "Iphone";
			productA.price = 20000;
			Console.WriteLine(productA.ToString());

			// Sử dụng hàm tạo của struct 1 tham số
			Product productB = new Product("iphone 12");
			Console.WriteLine(productB.ToString());
			Console.WriteLine("Test enum: " + (int) EnumEx.HocLuc.Kem);
		}
	}
}
