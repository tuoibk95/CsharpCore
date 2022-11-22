using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCContainer.IoCProblems
{
    /// <summary>
    ///  Trong OOD: các class nên được thiết kế theo cách kết hợp lỏng lẻo.
    ///  Loosely coupled means changes in one class should not force other classes to change: những thay đổi trong 1 lớp sẽ k buộc các lớp khác thay đổi.
    ///  n-tier architecture: UI <=> Service <=> Bussiness logic <=> DataAccess
    ///  UI sử dụng tầng service để thao tác với data. 
    ///  Tầng Service sử dụng BL class để áp dụng business rules on the data
    ///  BL class phụ thuộc vào Data Access để thao tác với DB
    ///  
    /// Problems:
    /// 1 - CustomerBusinessLogic and DataAccess classes are tightly coupled classes.
    /// Changes in the DataAccess class will lead to changes in the CustomerBusinessLogic class.
    /// Example: if we add, remove or rename any method in the DataAccess class then we need to change the CustomerBusinessLogic class accordingly(phù hợp).
    /// 2 - Suppose the customer data comes from different databases or web services and, 
    /// in the future, we may need to create different classes, so this will lead to changes in the CustomerBusinessLogic class.
    /// 3 - The CustomerBusinessLogic class creates an object of the DataAccess class using the new keyword
    /// There may be multiple classes which use the DataAccess class and create its objects.
    /// So, if you change the name of the class, then you need to find all the places in your source code where you created objects of DataAccess and make the changes throughout the code.
    /// Đây là việc lặp lại code tạo đối tượng của cùng 1 lớp và duy trì các phụ thuộc của chúng
    /// </summary>
	public class CustomerBusinessLogic
	{
        /// <summary>
        /// CustomerBusinessLogic class includes the reference of the concrete DataAccess class.
        /// </summary>
        DataAccess _dataAccess;

        public CustomerBusinessLogic()
        {
            // creates an object of DataAccess class and manages the lifetime of the object
            _dataAccess = new DataAccess();
        }

        public string GetCustomerName(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }
    }
}
