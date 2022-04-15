using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreStatic
{
	internal class TienIch
	{
		private string name;
		private decimal price;

		static TienIch()
		{
		}

		public TienIch(string name, decimal price)
		{
			this.name = name;
			this.price = price;
		}

		public static long LuyThua(int coSo, int soMu)
		{
			long ketQua = 1;
			for (int i = 0; i < soMu; i++)
			{
				ketQua *= coSo;
			}
			return ketQua;
		}
	}
}
