public delegate int TinhToan(int x, int y);

namespace CsharpCore.Delegate
{
	public delegate void UpdateNameHandler(string name);
	public class DelegateEx
	{
//		public delegate int TinhToan(int x, int y);
		protected internal void TinhToanUseDelegate()
		{
			TinhToan tinhTong = delegate (int x, int y)
			{
				return x + y; 
			};
			// Các kiểu viết ngắn của  delegate
//			TinhToan tinhTong1 = (int x, int y) => { return x + y; };
//			TinhToan tinhTong2 =  (x,y) => { x + y; };
//			TinhToan tinhTong3 =  (x,y) => x + y;

			int ketQua = tinhTong(3, 2);
			Console.WriteLine(ketQua);
		}

		//public static void Main(string[] args)
		//{
		//	DelegateEx delegateEx = new DelegateEx();
		//	delegateEx.TinhToanUseDelegate();
		//	Console.ReadLine();
		//	Console.ReadKey();
		//}

		//public static void Main(string[] args)
		//{
		//	HocSinh hs = new HocSinh();
		//	hs.NameChanged += Hs_NameChanged;

		//	hs.Name = "LVT";
		//	Console.WriteLine("Name from class: " + hs.Name);
		//	hs.Name = "LVX";
		//	Console.WriteLine("Name from class: " + hs.Name);
		//	Console.ReadLine();
		//}

		private static void Hs_NameChanged(string name)
		{
			Console.WriteLine("New name: " + name);
		}
	}

	public class HocSinh
	{
		public event UpdateNameHandler NameChanged;

		private string name;
		public string Name
		{
			get { return name; }
			set
			{
				name = value;
				if (NameChanged != null)
				{
					NameChanged(Name);
				}
			}
		}
	}
}
