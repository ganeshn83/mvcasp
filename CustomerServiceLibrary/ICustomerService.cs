﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Domain;

namespace CustomerServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        List<Customer> ListCustomers();

        [OperationContract]
        CustomerDetail GetCustomerDetails(string customerId);

        [OperationContract]
        bool SaveChanges(string customerId, string companyName, string contactName);
    }


}
