using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Encapsulation
{
    /// <summary>
    /// Hides data and complexities.
    /// Restrict unauthorized access of data by allowing authorization before data access.
    /// Allow validation before setting data.
    /// Only the author of the class needs to understand the implementation, not others.
    /// Makes applications easy to maintain.
    /// 
    /// we can implement encapsulation mostly using class, interface, abstract class, property, method, struct, enum, and access modifiers
    /// </summary>
    public class Student
    {
		#region Lưu trữ data một cách riêng tư để ẩn khỏi code bên ngoài, do đó k thể sửa đổi data & các giá trị k hợp lệ từ bên ngoài
		private string _firstName;
        private string _middleName;
        private string _lastName;
        #endregion

        #region proerties set & get giá trị cho các fields/ public để nó có thể truy cập đc từ bên ngoài
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

		public string FullName
        {
            get { return _firstName + " " + _lastName; }
        }
		#endregion

		#region methods
		public void Save()
        {
            //write code to save student 
        }

        public void Subscribe(Course cs)
        {
            Verify();

            //write code to subscribe to a course
        }

        private void Verify()
        {
            //write code to verify student before subscribing
        }

        public void GetSubscribedCourses()
        {
            //write code to return all subscribed courses
        }
		#endregion
	}
}
