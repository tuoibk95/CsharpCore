using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregationPrinciple
{
	internal interface ICourseRepository
	{
		void AddCourse(Course cs);
		void EditCourse(Course cs);
		void DeleteCourse(Course cs);

		IList<Course> GetAllCourse();
		IList<Course> GetAllCourses(Student std);
	}
}
