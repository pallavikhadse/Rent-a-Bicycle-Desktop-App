using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_a_Bicycle_App
{
   public class Booking
    {
        public string bookingId { get; set; }

        public string bicycleId { get; set; }

        public string customerId { get; set; }

        public DateTime hiringDate { get; set; }

        public string startTime { get; set; }

        public DateTime returnTime { get; set; }

        public string status { get; set; }

        public int depositPaidAmount { get; set; }


    }
}
