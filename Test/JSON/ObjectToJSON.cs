using System.Text.Json;

namespace Test.JSON
{
	internal class ObjectToJSON
	{
		public static void TestObjectToJSON()
		{
			Department department = new Department()
			{
				Description = "ALloha",
				Name = "LVT"
			};
			string strJSON = JsonSerializer.Serialize<Department>(department);
			Console.WriteLine(strJSON);
		}

		public static void TestObjectToJSONOption()
		{
			var department = new List<Department>()
			{
				new Department() { Description = "ALloha",Name = "LVT" },
				new Department() { Description = "Ahaha", Name = "LVX" }
			};
			var opt = new JsonSerializerOptions() { WriteIndented = true };
			string strJSON = JsonSerializer.Serialize<IList<Department>>(department, opt);
			Console.WriteLine(strJSON);
		}
	}
}
