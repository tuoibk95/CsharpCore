using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleResponsibilityPrinciple
{
    /// <summary>
    /// We should move the underlying EF code to another class to do all DB operations e.g. 
    /// StudentRepository class should be created for all CRUD operations for the Student. 
    /// This way if any changes on the DB side then we may need to change only the StudentRepository class.
    /// </summary>
	internal class StudentRepository
	{
        public bool Save(Student std)
        {
            Logger.Log("Starting Save()");

            //use EF to add a new student or update existing student to db

            Logger.Log("Ending Saving()");
            return true;
        }

        public bool Delete(int studentId)
        {
            Logger.Log("Starting Delete()");

            //use EF to delete a student 

            Logger.Log("Ending Delete()");
            return true;
        }

        public bool SaveCourse(Student std, Course cs)
        {
            Logger.Log("Starting SaveCourse()");

            //use EF to save a course for a student

            Logger.Log("Ending SaveCourse()");
            return true;
        }
    }
}
