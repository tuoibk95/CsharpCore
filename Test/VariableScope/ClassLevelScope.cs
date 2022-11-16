using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.VariableScope
{
	/// <summary>
	/// 1 biến được khai báo trong 1 class được gọi là 1 field
	/// nó có thể được truy cập trong bất kỳ trong class scope như method, properties...
	/// </summary>
	internal class ClassLevelScope
	{
		private string _firstName = "Steve";
		private string _lastName = "Jobs";
		public string FirstName
		{
			get { return _firstName; }
			set { _firstName = value; }
		}
		public void DisplayFullname()
		{
			Console.WriteLine(_firstName + _lastName);
		}
		public string FullName { get { return _firstName + _lastName; }}

	}
}
