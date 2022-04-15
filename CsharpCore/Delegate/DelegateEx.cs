namespace CsharpCore.Delegate
{
	public class DelegateEx
	{
		public delegate int TinhToan(int x, int y);

		protected string vaytien = "khongchovay";

		protected internal void TinhToanUseDelegate()
		{
			TinhToan tinhTong = (int x, int y) =>
			{
				return x + y;
			};
			int ketQua = tinhTong(3, 2);
			Console.WriteLine(ketQua);
		}
	}
}
