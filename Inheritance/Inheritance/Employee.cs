using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Inheritance
{
    class Employee : Person
    {
        // Gọi contructor của lớp base
        public Employee() : base("Parameterized constructor of base class")
		{
			Console.WriteLine("Contructor is Employee;");
		}
        public int EmployeeId { get; set; }
        public string CompanyName { get; set; }
        public string GetMiddleName()
		{
            return this.Address = "Toronto";
		}
        public string GetSubcribedCourse()
		{
            return this.Course = "Math";
		}

    }
}
