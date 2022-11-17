using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitutionPrinciple
{
	// hình chữ nhật có độ dài 2 cạnh khác nhau
	internal class Rectangle
	{
		public virtual int Height { get; set; }
		public virtual int Width { get; set; }
	}
}
