using Quay_hotel.Domain.SaleContext.Enums;
using System;
using System.Collections.Generic;

namespace Quay_hotel.Domain.SaleContext.Entities
{
    public class Order
    {

        public Order(Customer customer)
        {
            Customer = customer;
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();
            CreateDate = DateTime.Now;
            Status = EOrderStatus.Created;
            Bookings = new List<OrderBooking>();
            Deliveries = new List<Delivery>();
        }

        public Customer Customer { get; set; }
        public string Number { get; set; }
        public DateTime CreateDate { get; set; }
        public EOrderStatus Status { get; set; }
        public IReadOnlyCollection<OrderBooking> Bookings { get; set; }
        public IReadOnlyCollection<Delivery> Deliveries { get; private set; }


        //Adicionar uma reserva
        public void MakeBooking(OrderBooking booking)
        {
            //Validar 
            //aumentar o valor da propriedade
        }

        //A reservation is made 
        public void MakeBooking() { }
    }
}
