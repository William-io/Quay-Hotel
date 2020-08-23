using System;
using System.Collections.Generic;
using System.Text;

namespace Quay_hotel.Domain.SaleContext.Entities
{
    public class Order
    {
        public Customer Customer { get; set; }
        public string Number { get; set; }
        public DateTime CreateDate { get; set; }
        public string Status { get; set; }
        public IList<OrderBooking> Bookings { get; set; }

        //A reservation is made 
        public void MakeBooking() { }
    }
}
