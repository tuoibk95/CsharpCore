namespace IoCContainer.IoCDI
{
	/// <summary>
	/// Để giải quyết các vấn đề IoCProblems và đạt được thiết kế lỏng lẻo => use IoC & DIP principles cùng nhau
	/// DIP, CustomerBusinessLogic (high-level module) should not depend on the concrete DataAccess class (low-level module).
	/// Both classes should depend on abstractions, meaning both classes should depend on an interface or an abstract class.
	/// 
	/// we have implemented DIP where a high-level module (CustomerBusinessLogic) and low-level module (CustomerDataAccess) are dependent on an abstraction (ICustomerDataAccess)
	/// the abstraction (ICustomerDataAccess) does not depend on details (CustomerDataAccess), but the details depend on the abstraction.
	/// </summary>
	public class CustomerBusinessLogic
	{
        /// <summary>
        /// The advantages of implementing DIP is that the CustomerBusinessLogic and CustomerDataAccess classes are loosely coupled classes
        /// because CustomerBusinessLogic does not depend on the concrete DataAccess class,
        /// instead it includes a reference of the ICustomerDataAccess interface.
        /// 
        /// So now, we can easily use another class which implements ICustomerDataAccess with a different implementation.
        /// 
        /// Still, we have not achieved fully loosely coupled classes because the CustomerBusinessLogic class includes a factory class to get the reference of ICustomerDataAccess.
        /// This is where the Dependency Injection pattern helps us
        /// </summary>
        ICustomerDataAccess _dataAccess;
        public CustomerBusinessLogic(ICustomerDataAccess customerDataAccess)
        {
            _dataAccess = customerDataAccess;
        }
        public CustomerBusinessLogic()
        {
            _dataAccess = new CustomerDataAccess();
        }

        public string ProcessCustomerData(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }
    }
}
