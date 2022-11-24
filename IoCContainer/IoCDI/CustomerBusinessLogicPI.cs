namespace IoCContainer.IoCDI
{
    public class CustomerBusinessLogicPI
    {
        public CustomerBusinessLogicPI()
        {
        }

        public string GetCustomerName(int id)
        {
            return DataAccess.GetCustomerName(id);
        }
        // the CustomerBusinessLogic class includes the public property named DataAccess, where you can set an instance of a class that implements ICustomerDataAccess
        public ICustomerDataAccess DataAccess { get; set; }
    }

    public class CustomerServicePI
    {
        CustomerBusinessLogicPI _customerBL;

        public CustomerServicePI()
        {
            _customerBL = new CustomerBusinessLogicPI();
            // CustomerService class creates and sets CustomerDataAccess class using this public property.
            _customerBL.DataAccess = new CustomerDataAccess();
        }

        public string GetCustomerName(int id)
        {
            return _customerBL.GetCustomerName(id);
        }
    }
}
