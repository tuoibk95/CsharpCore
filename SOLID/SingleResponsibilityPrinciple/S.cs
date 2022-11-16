using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleResponsibilityPrinciple
{
    /// <summary>
    /// Holds student's properties such as StudentId, FirstName, LastName, and DoB.
    /// Save a new student, or update an existing student to a database.
    /// Delete existing students from the database if not subscribed to any course.
    /// Apply business rules to subscribe to courses based on the course type.
    /// Process the payment for the course.
    /// Send confirmation email to a student upon successful registration.
    /// Logs each activity to the console.
    /// 
    /// high-level business logic should avoid dealing with low-level implementation.
    /// Student class (high-level class)
    /// </summary>
    public class S
    {
        #region what is responsibility? online e-commerce app có các tính năng như 
        /// displaying product lists (danh sách product)
        /// submiting an order (gửi đơn đặt hàng)
        /// displaying product ratings (hiển thị xếp hạng sản phẩm)
        /// managing customers: quản lý khách hàng
        /// shipping addresses: địa chỉ giao hàng
        /// managing payments: quản lý thanh toán
        /// 
        /// it also validates and persists products and customers' data: Xác nhận và duy trì các sản phẩm và dữ liệu của khách hàng
        /// logs activities for auditing and security purposes: ghi nhật kí các hoạt động cho mục đích kiểm toán và bảo mật
        /// applies business rules: Áp dụng các quy tắc kinh doanh
        /// 
        /// can think of these points as functionalities or features or responsibilities.: Có thể coi nhưng đặc điểm này là chức năng hoặc tính năng hoặc nhiệm vụ
        /// Thay đổi trong bất kì chức năng nào dẫn đến thay đổi trong lớp chịu trách nhiệm về chức năng đó
        #endregion
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        public string email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }

        #region 
        /// If anything in the above responsibility changes, then we will have to modify the Student class.
        /// if you need to add a new property then we need to change the Student class.
        /// if you need a change in the database, maybe moving from a local server to a cloud, then you need to change the code of the Student class.
        /// if you need to change the business rules (validation) before deleting a student or subscribing to a course, or change the logging medium from console to file, then in all these cases you need to change the code of the Student class.
        /// 
        /// SRP tells us to have only one reason to change a class. => Lớp Student chỉ giữ trách nhiệm cho lớp Student
        /// Loại bỏ các trách nhiệm (được ủy quyền) cho các lớp khác
        #endregion
        public void Save()
        {
            // We should move the underlying EF code to another class to do all DB operations
            // e.g. StudentRepository class should be created for all CRUD operations for the Student.
            // This way if any changes on the DB side then we may need to change only the StudentRepository class.
            Console.WriteLine("Starting Save()");
            //use EF to save student to DB

            Console.WriteLine("End Save()");
        }

        public void Delete()
        {
            Console.WriteLine("Starting Delete()");

            //check if already subscribed courses then don't delete

            Console.WriteLine("End Delete()");
        }

        // Except for the Subscribe() method, all the properties and methods are related to the student, so keep all the properties.
        // The Subscribe() method is more suitable for the Course class because a course can have different subscription rules based on the course type.
        public IList<Course> Subscribe(Course cs)
        {
            Console.WriteLine("Starting Subscribe()");

            //apply business rules based on the course type 
            if (cs.Type == "online")
            {
                //validate
            }
            else if (cs.Type == "live")
            {

            }

            //payment processing code

            //save course subscription to DB

            //send email confirmation code

            Console.WriteLine("End Subscribe()");
            return null;
        }
    }
}
