namespace Quay_hotel.Domain.SaleContext.Entities
{
    public class OrderBooking
    {
        public OrderBooking(Hotel hotel, decimal quantity)
        {
            Hotel = hotel;
            Quantity = quantity;
            Price = hotel.Price;
        }

        public Hotel Hotel { get; private set; }
        public decimal Quantity { get; private set; }
        public decimal Price { get; private set; }
    }
}
