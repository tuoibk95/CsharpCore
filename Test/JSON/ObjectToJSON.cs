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

		public static void TestObject()
		{
			Student student = new Student()
			{
				StudentId = 1,
				FirstName = "Le Van",
				LastName = "Tuoi",
				Courses = new Course() { CourseId = 1, Title = "Hello", Type = "convoi" }
			};
			var opt = new JsonSerializerOptions() { WriteIndented = true };
			string strJSON = JsonSerializer.Serialize<Student>(student, opt);
			Console.WriteLine(strJSON);
		}

		public static void TestObject2()
		{
			Student student = new Student()
			{
				StudentId = 1,
				FirstName = "Le Van",
				LastName = "Tuoi",
				Courses = new Course() { CourseId = 1, Title = "Hello", Type = "convoi" },
				Teachers = new List<Teacher>() {
					new Teacher() { TeacherId = 1, TeacherName = "Hoho"},
					new Teacher() { TeacherId = 1, TeacherName = "Haha"}
				}
			};
			var opt = new JsonSerializerOptions() { WriteIndented = true };
			string strJSON = JsonSerializer.Serialize<Student>(student, opt);
			Console.WriteLine(strJSON);
		}
	}
}
