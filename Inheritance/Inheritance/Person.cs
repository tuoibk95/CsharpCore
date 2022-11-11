using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Inheritance
{
    /// <summary>
    /// Kế thừa: là cơ chế sử dụng lại các chức năng của 1 lớp này vào 1 lớp khác có liên quan
    /// Không cần tạo các properties giống nhau trong các class, chúng phải có some common behaviors và có thể thay thế được.
    /// </summary>
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        /// <summary>
        /// Protected: Các thành viên của lớp cơ sở có thể được truy cập từ lớp dẫn xuất nhưng KHÔNG THỂ là 1 phần của đối tượng lớp dẫn xuất
        /// </summary>
        protected string Address { get; set; }
        /// <summary>
        /// Internal: Các thành viên của lớp cơ sở có thể được truy cập từ lớp dẫn xuất và là 1 phần của đối tượng lớp dẫn xuất
        /// </summary>
        internal string Course { get; set; }

        public Person()
		{
			Console.WriteLine("Contructor is Person");
		}

        public Person(string str)
        {
            Console.WriteLine(str);
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
