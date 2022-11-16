using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleResponsibilityPrinciple
{
	/// <summary>
	/// Mỗi software module nên có 1 và chỉ 1 lý do để thay đổi (1 class nên có 1 và chỉ 1 responsibility(nhiệm vụ/trách nhiệm) => chỉ nên có 1 lý do để thay đổi)
    /// Student class nên chứa tất cả properties and method dành riêng cho lớp student
	/// </summary>
    public class Student
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

        #region fields
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
        #endregion

        #region Save a new student, or update an existing student to a database.
        public void Save()
        {
            Console.WriteLine("Starting Save()");
            //use EF to save student to DB

            Console.WriteLine("End Save()");
        }
        #endregion

        #region Delete existing students from the database if not subscribed to any course.
        public void Delete()
        {
            Console.WriteLine("Starting Delete()");

            //check if already subscribed courses then don't delete

            Console.WriteLine("End Delete()");
        }
        #endregion
    }
}
