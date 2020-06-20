using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rent_a_Bicycle_App
{
    public class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string telephone { get; set; }
        public string idNumber { get; set; }
        public string zipCode { get; set; }
        public string customerId { get; set; }

        //public string bookingId { get; set; }

        [XmlIgnoreAttribute]
        public string name { get{ return $"{firstName} {" "} {lastName }";}}       

    }
}
