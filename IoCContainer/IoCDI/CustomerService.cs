namespace IoCContainer.IoCDI
{
    /// <summary>
    /// the CustomerService class creates and injects the CustomerDataAccess object into the CustomerBusinessLogic class.
    /// the CustomerBusinessLogic class doesn't need to create an object of CustomerDataAccess using the new keyword or using factory class.
    /// The calling class (CustomerService) creates and sets the appropriate DataAccess class to the CustomerBusinessLogic class.
    /// the CustomerBusinessLogic and CustomerDataAccess classes become "more" loosely coupled classes.
    /// </summary>
	public class CustomerService
	{
        CustomerBusinessLogic _customerBL;

        public CustomerService()
        {
            _customerBL = new CustomerBusinessLogic(new CustomerDataAccess());
        }

        public string GetCustomerName(int id)
        {
            return _customerBL.ProcessCustomerData(id);
        }
    }
}
