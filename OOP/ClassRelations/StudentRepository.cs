using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.ClassRelations
{
    /// <summary>
    ///  Association Relationship: Mối quan hệ kết hợp được gọi là mối quan hệ sử dụng một "uses a" trong đó 1 lớp sử dụng 1 lớp khác để thực hiện 1 số hành động
    ///  Cả 2 lớp có thể tồn tại độc lập khi k lớp nào là chủ sở hữu của lớp khác
    ///  collaboration or delegation.: Cộng tác hoặc ủy quyền
    ///  * Sự liên kết xảy ra giữa các lớp trong đó 1 lớp cung cấp service cho một lớp khác
    ///  * class delegates một số loại hành vi (behaviors) cho một lớp khác
    /// Association được triển khai với: pointer / reference variable/ method argument.
    /// </summary>
    public class StudentRepository
    {
        /// <summary>
        /// Sử dụng Student như 1 tham số của phương thức
        /// Cả 2 lớp đều có thời gian tồn tại độc lập : nghĩa là việc loại bỏ cái này sẽ k loại bỏ cái khác
        /// Lớp Student ủy thác(delegates) trách nhiệm thực hiện lưu hoặc truy xuất data liên quan đến sinh viên cho lớp StudentRepository
        /// </summary>
        /// <param name="Student"></param>
        #region Lớp StudentRepository cung cấp các service cho bất kỳ lớp nào quan tâm đến việc truy xuất và lưu dữ liệu Student
        public Student GetStudent(int StudentId)
        {
            // get student by id from db here

            return new Student();
        }
        public bool Save(Student student)
        {
            // save student to db here
            Console.WriteLine("Student saved successfully");

            return true;
        }
        public bool Validate(Student student)
        {
            // get student from db to check whether the data is already exist
            Console.WriteLine("Student does not exist.");

            return true;
        }
		#endregion
	}
}
