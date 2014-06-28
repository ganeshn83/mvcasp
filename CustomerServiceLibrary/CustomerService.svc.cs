using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Domain;

namespace CustomerServiceLibrary
{
    public class Service1 : ICustomerService
    {

        public List<Customer> ListCustomers()
        {
            throw new NotImplementedException();
        }

        public CustomerDetail GetCustomerDetails(string customerId)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges(string customerId, string companyName, string contactName)
        {
            throw new NotImplementedException();
        }
    }
}
