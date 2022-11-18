using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.ClassRelations.Composition
{
    /// <summary>
    /// Mối quan hệ thành phần (Composition relationship) được hình thành khi 1 class có tham chiếu đến 1 class khác như 1 thuộc tính thể hiện (instance).
    /// The child class doesn't exist without the parent class.
    /// Deleting the parent class will also delete the child class
    /// </summary>
    public class Student
    {
		#region Fields
		public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        // Một lớp có chứa tham chiếu đến 1 lớp khác là parent (owner) của child class.
        // Mối quan hệ one-to-one giữa 2 lớp, vì mỗi Student sẽ có chỉ 1 Address
        public Address HomeAddress { get; set; }
        // Lớp Student chứa AddressId peoperty của lớp Address thay vì 1 Instance để tạo thành Composition relationship
        public int AddressId { get; set; }
		#endregion
	}
}
