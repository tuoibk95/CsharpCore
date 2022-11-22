using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCContainer.IoCProblems
{
	public class DataAccess
	{
        public DataAccess()
        {
        }

        public string GetCustomerName(int id)
        {
            return "Dummy Customer Name"; // get it from DB in real app
        }
    }
}
