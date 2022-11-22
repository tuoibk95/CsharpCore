using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCContainer.IoCSolve
{
    /// <summary>
    /// Để giải quyết các vấn đề IoCProblems và đạt được thiết kế lỏng lẻo => use IoC & DIP principles cùng nhau
    /// DIP, CustomerBusinessLogic (high-level module) should not depend on the concrete DataAccess class (low-level module).
    /// Both classes should depend on abstractions, meaning both classes should depend on an interface or an abstract class.
    /// </summary>
	public class CustomerBusinessLogic
	{
        public CustomerBusinessLogic()
        {
        }

        public string GetCustomerName(int id)
        {
            // use this DataAccessFactory class in the CustomerBusinessLogic class to get an object of DataAccess class.
            // the CustomerBusinessLogic class uses the DataAccessFactory.GetCustomerDataAccessObj() method to get an object of the DataAccess class instead of creating it using the new keyword
           DataAccess _dataAccess = DataAccessFactory.GetDataAccessObj();

            return _dataAccess.GetCustomerName(id);
        }
    }
}
