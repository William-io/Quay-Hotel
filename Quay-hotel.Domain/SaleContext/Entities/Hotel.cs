namespace Quay_hotel.Domain.SaleContext.Entities
{
    public class Hotel
    {
        public Hotel(
            string name, 
            int rating, 
            int rooms, 
            double bookings,
            string gym,
            string pool, 
            decimal price, 
            string image)
        {
            Name = name;
            Rating = rating;
            Rooms = rooms;
            Bookings = bookings;
            Gym = gym;
            Pool = pool;
            Price = price;
            Image = image;
        }

        public string Name { get; private set; }
        public int Rating { get; private set; }
        public int Rooms { get; private set; }
        public double Bookings { get; private set; }
        public string Gym { get; private set; }
        public string Pool { get; private set; }
        public decimal Price { get; private set; }
        public string Image { get; private set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
