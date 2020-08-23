using System;
using System.Collections.Generic;
using System.Text;

namespace Quay_hotel.Domain.SaleContext.Entities
{
    public class OrderBooking
    {
        public Hotel Hotel { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
    }
}
