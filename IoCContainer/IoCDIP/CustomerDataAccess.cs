using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCContainer.IoCDIP
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
