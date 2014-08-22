using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Domain;
using System.Linq.Expressions;
using DataAccess;
using System.Data.Linq;
namespace CustomerServiceLibrary
{
    public class Service1 : ICustomerService
    {
        public List<Domain.Customer> ListCustomers()
        {
            var cust = new List<Domain.Customer>();
            var ctx = new CustomerDataDataContext();
            var listofcustomers = (from c in ctx.Customers
                                   where c.City.Equals("London")
                                   select c).ToList<DataAccess.Customer>();


            foreach (var c in listofcustomers)
            { 
                cust.Add(new Domain.Customer{Name = c.ContactName, CustomerId = c.CustomerID, CompanyName = c.CompanyName});
            }

            return cust;
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
