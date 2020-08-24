using Quay_hotel.Domain.SaleContext.Enums;
using System.Runtime.InteropServices;

namespace Quay_hotel.Domain.SaleContext.ValueObjects
{
    public class Address
    {
        public Address(
            string stress, 
            string number,
            string complement,
            string district, 
            string city,
            string state,
            string country, 
            string zipCode,
            EAddressType eAddressType)
        {
            Stress = stress;
            Number = number;
            Complement = complement;
            District = district;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
            Type = eAddressType;
        }

        public string Stress { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public EAddressType Type { get; set; }

        public override string ToString()
        {
            return $"{Stress}, {Number} - {City}/{State}";
        }
    }
}
