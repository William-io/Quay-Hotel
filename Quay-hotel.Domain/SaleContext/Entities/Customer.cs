﻿using Quay_hotel.Domain.SaleContext.ValueObjects;
using System.Collections;
using System.Collections.Generic;

namespace Quay_hotel.Domain.SaleContext.Entities
{
    public class Customer
    {
        public Customer(
            Name name,
            Document document,
            Email email, 
            string phone)
        {
            Name = name;           
            Document = document;
            Email = email;
            Phone = phone;
            Addresses = new List<Address>();
        }

        public Name Name { get; set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public string Phone { get; private set; }
        public IReadOnlyCollection<Address> Addresses { get; private set; }  //endereço de entrega
       

        public override string ToString()
        {
            return Name.ToString();
        }

    }
}
