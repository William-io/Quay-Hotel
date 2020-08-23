using System;
using System.Collections.Generic;
using System.Text;

namespace Quay_hotel.Domain.SaleContext.Entities
{
    public class Delivery
    {
        public DateTime CreateDate { get; set; }
        public DateTime EstimatedDeliveryDate { get; set; }
        public string Status { get; set; }
    }
}
