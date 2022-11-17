using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosedPrinciple
{
	/// <summary>
	/// a new class can inherit the Logger class and change one or more method behavior.
	/// Dev muốn sử dụng Debug method với triển khai theo ý họ
	/// 
	/// OCP using inheritance makes it "Open for extension and closed for modification"
	/// </summary>
	public class NewLogger : Logger
	{
		public override void Debug(string message)
		{
			Console.WriteLine($"Dev Debug -> {message}");
		}
	}
}
