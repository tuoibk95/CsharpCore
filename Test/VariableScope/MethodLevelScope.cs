using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.VariableScope
{
	internal class MethodLevelScope
	{
		private static string str = "Hi";
		public static void MethodLevelScopeEx()
		{
			// Khai báo và khởi tạo giá trị cho biến a trong phạm vi method
			int a = 20;
			Console.WriteLine(a);
			// có thể truy cập biến str bởi từ khóa static
			Console.WriteLine(str);
		}
	}
}
