using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversionPrinciple
{
    /// <summary>
    /// DIP states that “High-level modules should not depend on low-level modules. Both should depend on abstraction”.
    /// what are high-level and low-level modules
    /// A high-level module is a module (class) that uses other modules (classes) to perform a task
    /// A low-level module contains a detailed implementation of some specific task that can be used by other modules
    /// The high-level modules are generally the core business logic of an application
    /// the low-level modules are input/output, database, file system, web API, or other external modules that interact with users, hardware, or other systems.
    /// 
    /// what is an abstraction? Trừu tượng là một cái gì đó k cụ thể
    /// Abstraction should not depend on detail but details should depend on abstraction
    /// an abstract class or interface contains methods declarations that need to be implemented in concrete classes.
    /// Those concrete classes depend on the abstract class or interface but not vice-versa.
    /// 
    /// how do we know a class depends on another class?
    /// You can identify a class is depends on another class if it creates an object of another class.
    /// </summary>
    public class D
    {
        // Student as D
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }

        // tight coupling: liên kết chặt chẽ
        // Student class creates an object of the StudentRepository class for CRUD operation to a database.
        // The Student class is the high-level module and the StudentRepository class is the low-level module.
        private StudentRepository _stdRepo = new StudentRepository();
        // Vấn đề: 
        /// <summary>
        /// Creating objects using the new keyword at all places is repeated code.
        /// The object creation is not in one place.
        /// Violation of the Do Not Repeat Yourself (DRY) principle.
        /// If there is some change in the constructor of the StudentRepository class then we need to make the changes in all the places.
        /// If object creation is in one place then it would be easy to maintain the code.
        /// 
        /// Creating an object using new also make unit testing impossible.
        /// cannot unit test the Student class separately.
        /// 
        /// The StudentRepository class is a concrete class, so any changes in the class will require changing the Student class too.
        /// </summary>
        public D()
        {

        }
        public void Save()
        {
            _stdRepo.AddStudent(this);
        }

    }

    public class StudentRepository
    {


        public void AddStudent(D std)
        {
            //EF code removed for clarity
        }

        public void DeleteStudent(D std)
        {
            //EF code removed for clarity
        }

        public void EditStudent(D std)
        {
            //EF code removed for clarity
        }


        public IList GetAllStudents()
        {
            //EF code removed for clarity
            return null;
        }

    }
}
