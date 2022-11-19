using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Test.JSON
{
	internal class JSONToObject
	{
		public static void ConvertJsonToObject()
		{
			string jsonData = "{\"Description\": \"ALloha\",\"Name\": \"LVT\"}";
			Department department = JsonSerializer.Deserialize<Department>(jsonData);
			Console.WriteLine(department.Name);
			Console.WriteLine(department.Description);
		}

		public static void ConvertArrayJsonToObject()
		{
			string jsonData = "[{\"Description\": \"ALloha\",\"Name\": \"LVT\"},{\"Description\": \"Ahaha\",\"Name\": \"LVX\"}]";
			var department = JsonSerializer.Deserialize<IList<Department>>(jsonData);
			foreach (var item in department)
			{
				Console.WriteLine(item.Name);
				Console.WriteLine(item.Description);
			}
		}
	}
}
