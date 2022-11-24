namespace IoCContainer.IoCDI
{
	// Implement ICustomerDataAccess trong class CustomerDataAccess
	public class CustomerDataAccess : ICustomerDataAccess
	{
        public CustomerDataAccess()
        {
        }

        public string GetCustomerName(int id)
        {
            return "Dummy Customer Name";
        }
    }
}
