using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregationPrinciple
{
	public class Student
	{
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }

        /// <summary>
        /// Thus, it also depends on the abstraction (interface) rather than the low-level concrete class (StudentRepository).
        /// This will create loose coupling and also make each class unit testable.
        /// The caller of the Student class can pass an object of any class that implements the IStudentRepository interface and by so not tied to the specific concrete class.
        /// </summary>
        private I _stdRepo;

        /// <summary>
        /// The constructor requires a parameter of the IStudentRepository class which will be passed from the calling code.
        /// </summary>
        /// <param name="stdRepo"></param>
        public Student(I stdRepo)
        {
            _stdRepo = stdRepo;
        }
        public void Save()
        {
            _stdRepo.AddStudent(this);
        }
    }
}
