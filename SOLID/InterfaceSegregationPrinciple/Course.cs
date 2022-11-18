using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregationPrinciple
{
    /// <summary>
    /// The Course class has course-related responsibilities.
    /// </summary>
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }

        #region Apply business rules to subscribe to courses based on the course type.
        //public void Subscribe(Student std)
        //{
        //    Logger.Log("Starting Subscribe()");

        //    //apply business rules based on the course type live, online, offline, if any 
        //    if (this.Type == "online")
        //    {
        //        //subscribe to online course 
        //    }
        //    else if (this.Type == "live")
        //    {
        //        //subscribe to offline course 
        //    }

        //    // payment processing
        //    PaymentManager.ProcessPayment();

        //    //create CourseRepository class to save student and course into StudentCourse table  

        //    // send confirmation email
        //    EmailManager.SendEmail();

        //    Logger.Log("End Subscribe()");
        //}
        #endregion
    }
}