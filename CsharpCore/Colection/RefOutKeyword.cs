using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCore.Colection
{
	// Sử dụng từ khóa ref khi biến đã có giá trị trước đó và cần thay đổi
	// Sử dụng từ khóa out thì biến được khởi tạo ngay trong thân hàm và cần thay đổi
	internal class RefOutKeyword
	{
		public void toRefOutKeyword()
		{
			int value = 5;
			Console.WriteLine("Before: {0}", value);

			IncreaseValue(value);
			Console.WriteLine("After: {0}", value);

			/* Đồng thời phải thêm ref trước biến parameter truyền vào khi sử dụng hàm
			* Truyền parameter có từ khóa ref bắt buộc phải là một biến (K thể truyền vào 1 hàng vì hằng là giá trị k thay đổi)
			* có thể có 1 hoặc nhiều parameter với từ khóa ref trong khai báo hàm
			* - Biến tryền vào có từ khóa ref thì phải được khởi tạo giá trị trước khi truyền vào
			* - hàm sử dụng sẽ thao tác trực tiếp với vùng nhớ của các parameter trên RAM => kết thúc lời gọi hàm giá trị các parameter sẽ bị thay đổi
			*/
			IncreaseRef(ref value);
			Console.WriteLine("After: {0}", value);

			/*
			 * Hàm sử dụng sẽ thao tác trực tiếp tới vùng nhớ của các parameter trên RAM => kết thúc lời gọi hàm giá trị các parameter có thể bị thay đổi
			 * phải có từ khóa out trước tên biến truyền vào khi gọi hàm sử dụng
			 * 
			 *  Biến truyền vào có từ khóa out sẽ không cần khởi tạo giá trị ban đầu
			 *  Parameter đó chỉ như một thùng chứa kết quả trả về khi kết thúc gọi hàm ( bỏ khởi tạo ban đầu và thêm int sau out)
			 */
			IncreaseOut(out value);
			Console.WriteLine("After: {0}", value);

			Console.ReadKey();
		}

		static void IncreaseValue(int a)
		{
			a++;
		}

		// Khai báo từ khóa ref trước data type của parameter
		// có thể có 1 hoặc nhiều parameter với từ khóa ref trong khai báo hàm
		static void IncreaseRef(ref int b)
		{
			b++;
		}
		
		// Phải có từ khóa out trước tên parameter của hàm
		// Parameter phải được khởi tạo ngay bên trong lời gọi hàm
		static void IncreaseOut(out int c)
		{
			c = 10;
			c++;
		}
	}
}
