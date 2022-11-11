using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.ClassRelations.Aggregation
{
    /// <summary>
    /// Aggregation: Là một phạm trù khác của mối quan hệ "has a" 
    /// Một lớp có thể chứa các lớp khác dưới dạng thuộc tính nhưng các lớp đó có thể tồn tại độc lập
    /// </summary>
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        /// <summary>
        /// Student lass chứa Course class instance như một thuộc tính để tạo thành Composition Relationship
        /// Tuy nhiên cả 2 lớp có thể tồn tại độc lập => Aggregation relationship
        /// Khi Student bị xóa thì Course sẽ vẫn tồn tại
        /// </summary>
        public Course EnrolledCourse { get; set; }
        // Student class cũng có thể chứa thuộc tính CourseId thay vì Course instance
        public int CourseId { get; set; }
    }
}
