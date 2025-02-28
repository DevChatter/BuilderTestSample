﻿using System.Collections.Generic;

namespace BuilderTestSample.Model
{
    public class Customer
    {
        public Customer(int id)
        {
            Id = id;
        }
        
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address HomeAddress { get; set; }
        public int CreditRating { get; set; }
        public decimal TotalPurchases { get; set; }

        public List<Order> OrderHistory { get; set; } = new List<Order>();

        public Customer WithId(int id)
        {
            return new Customer(id)
            {
                CreditRating = CreditRating,
                HomeAddress = HomeAddress,
                FirstName = FirstName,
                LastName = LastName,
                OrderHistory = OrderHistory,
                TotalPurchases = TotalPurchases
            };
        }
    }
}
