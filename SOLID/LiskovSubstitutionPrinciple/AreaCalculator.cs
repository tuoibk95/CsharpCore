using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitutionPrinciple
{
	internal class AreaCalculator
	{
		// Không thể áp dụng cho hình vuông vì có các cạnh bằng nhau
		// => giữ lại tính đúng đắn của chương trình thì hình vuông width = height
		public static int CalculateArea(Rectangle r)
		{
			return r.Height * r.Width;
		}
	}
}
