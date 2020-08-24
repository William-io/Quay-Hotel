using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quay_hotel.Domain.SaleContext.Entities;

namespace Quay_hotel.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Customer(
                "William", 
                "Vilela", 
                "701231", 
                "Capuletos@live.com",
                "8598898989",
                "Prof.Teodorico");

            var order = new Order(c);
            


        }
    }
}
//Bookings é a reserva, como o item de produto
