using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversionPrinciple
{
    /// <summary>
    /// The StudentRepository class provides the implementation of that methods, so it depends on the methods of the IStudentRepository interface.
    /// </summary>
	public class StudentRepository1 : IStudentRepository
	{
        public void AddStudent(Student std)
        {
            //code removed for clarity
        }

        public void DeleteStudent(Student std)
        {
            //code removed for clarity
        }

        public void EditStudent(Student std)
        {
            //code removed for clarity
        }
        public IList GetAllStudents()
        {
            //code removed for clarity
            return null;
        }
    }
}
