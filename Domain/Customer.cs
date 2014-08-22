using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Domain
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string CompanyName { get; set; }

        [DataMember]
        public string CustomerId{ get; set; }
    }

    [DataContract]
    public class CustomerDetail
    {
        [DataMember]
        public string CustomerId { get; set; }

        [DataMember]
        public string CompanyName { get; set; }

        [DataMember]
        public string ContactName { get; set; }

        [DataMember]
        public string ContactTitle { get; set; }
    }
}
