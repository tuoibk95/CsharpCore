namespace IoCContainer.IoCDIP
{
	// Sử dụng Factory Pattern triển khai IoC để đạt được thiết kế lỏng lẻo
	// we have inverted the control of creating an object of a dependent class from the CustomerBusinessLogic class to the DataAccessFactory class.
	public class DataAccessFactory
	{
		// change our factory class which returns ICustomerDataAccess instead of the concrete DataAccess class
		public static ICustomerDataAccess GetCustomerDataAccessObj()
		{
			// returns an object of the DataAccess class
			return new CustomerDataAccess();
		}
	}
}
