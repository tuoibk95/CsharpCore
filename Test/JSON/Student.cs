using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.JSON
{
    public class Student
    {
        #region fields
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Course Courses { get; set; }
        public List<Teacher> Teachers { get; set; }
        #endregion
    }
}
