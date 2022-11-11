using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP.ClassRelations.Aggregation
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public IList Topics { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
