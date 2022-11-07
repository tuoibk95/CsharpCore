using System;
using System.Collections.Generic;
using System.Text;

namespace Variables
{
	public class AutoImplementedProperty
	{
		/// <summary>
		/// Từ C# 3.0 trở đi thì việc khai báo thuộc tính đã trở nên dễ dàng và ngắn gọn hơn nếu không muốn áp dụng một số logic vào getter và setter.
		/// Sử dụng auto implemented property không cần khai báo private field.
		/// C# sẽ tự động tạo ra nó trong bởi trình biên dịch. Điều này sẽ làm tăng thời gian phát triển và đọc code.
		/// </summary>
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public AutoImplementedProperty(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}
		public string GetFullName()
		{
			return FirstName + " " + LastName;
		}
	}
}
