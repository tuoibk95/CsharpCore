using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregationPrinciple
{
    /// <summary>
    /// Clients should not be forced to depend on methods they do not use.
    /// who is the client?
    /// - a client is a code that calls the methods of a class with an instance of the interface.
    /// --- a class implements an interface that contains 10 methods.
    /// --- you create an object of that class with a variable of that interface and call only 5 methods for the functionality you wanted and never call the other 5 methods.
    /// this means that the interface contains more methods that are not used by all client codes.
    /// 
    /// ISP suggests segregating that interface into two or more interfaces so that a class can implement the specific interface that it requires.
    /// what and whose methods it is talking about?
    /// 
    /// ISP is not specific to interfaces only but it can be used with abstract classes or any class that provides some services to the client code.
    /// ISP helps in implementing Liskov Substitution Principle, increasing cohesion that in turn supports the Single Responsibility Principle.
    /// </summary>
    /// 
    public interface I
    {
        #region interface contains 12 methods for different purposes.
        /// <summary>
        /// When you have large interfaces.
        ///  When you implement an interface in a concrete class where some methods do not have any implementation code or throw NotImplementedException.
        /// When you call only a small set of methods of a larger interface.
        /// Solution: 
        /// Split large interfaces into smaller ones.
        /// inherit multiple small interfaces if required.
        /// Use the adapter design pattern for the third-party large interface so that your code can work with the adapter.
        /// </summary>
        void AddStudent(Student std);
        void EditStudent(Student std);
        void DeleteStudent(Student std);

        void AddCourse(Course cs);
        void EditCourse(Course cs);
        void DeleteCourse(Course cs);

        bool SubscribeCourse(Course cs);
        bool UnSubscribeCourse(Course cs);
        IList<Student> GetAllStudents();
        IList<Student> GetAllStudents(Course cs);

        IList<Course> GetAllCourse();
        IList<Course> GetAllCourses(Student std);
		#endregion
	}

	public class StudentRepo : I
    {
        #region Không phải tất cả method triển khai trong Interface
        /// <summary>
        /// Sometimes it calls methods that perform student-related tasks or sometimes calls course-related methods. 
        /// Không tuân theo nguyên tắc SRP:
        /// </summary>
        /// <param name="cs"></param>
        public void AddCourse(Course cs)
        {
            //implementation code removed for better clarity
        }

        public void AddStudent(Student std)
        {
            //implementation code removed for better clarity
        }

        public void DeleteCourse(Course cs)
        {
            //implementation code removed for better clarity
        }

        public void DeleteStudent(Student std)
        {
            //implementation code removed for better clarity
        }

        public void EditCourse(Course cs)
        {
            //implementation code removed for better clarity
        }

        public void EditStudent(Student std)
        {
            //implementation code removed for better clarity
        }

        public IList<Course> GetAllCourse()
        {
            //implementation code removed for better clarity
            return new List<Course>();
        }

        public IList<Course> GetAllCourses(Student std)
        {
            //implementation code removed for better clarity
            return new List<Course>();
        }

        public IList<Student> GetAllStudents()
        {
            //implementation code removed for better clarity
            return new List<Student>();
        }

        public IList<Student> GetAllStudents(Course cs)
        {
            //implementation code removed for better clarity
            return new List<Student>();
        }

        public bool SubscribeCourse(Course cs)
        {
            //implementation code removed for better clarity
            return false;
        }

        public bool UnSubscribeCourse(Course cs)
        {
            //implementation code removed for better clarity
            return true;
        }
		#endregion
	}
}
