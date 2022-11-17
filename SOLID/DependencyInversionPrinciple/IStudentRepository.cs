using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversionPrinciple
{
	/// <summary>
	/// IStudentRepository is an abstraction of CRUD operations for student-related data.
	/// </summary>
	public interface IStudentRepository
	{
		void AddStudent(Student std);
		void EditStudent(Student std);
		void DeleteStudent(Student std);
		IList GetAllStudents();
	}
}
