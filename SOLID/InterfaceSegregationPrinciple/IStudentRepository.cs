using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregationPrinciple
{
	internal interface IStudentRepository
	{
        void AddStudent(Student std);
        void EditStudent(Student std);
        void DeleteStudent(Student std);

        bool SubscribeCourse(Course cs);
        bool UnSubscribeCourse(Course cs);
        IList<Student> GetAllStudents();
        IList<Student> GetAllStudents(Course cs);
    }
}
