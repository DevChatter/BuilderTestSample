using System.Collections.Generic;
using BuilderTestSample.Model;

namespace BuilderTestSample.Tests.TestBuilders
{
    public class CustomerBuilder
    {
        private Customer _internalCustomer = new Customer(0);
        private int _id;

        public CustomerBuilder Address(Address address)
        {
            _internalCustomer.HomeAddress = address;
            return this;
        }

        public CustomerBuilder FirstName(string firstName)
        {
            _internalCustomer.FirstName = firstName;
            return this;
        }

        public CustomerBuilder LastName(string lastName)
        {
            _internalCustomer.LastName = lastName;
            return this;
        }

        public CustomerBuilder Id(int id)
        {
            _id = id;
            return this;
        }

        public Customer Build()
        {
            Customer builtCustomer = _internalCustomer.WithId(_id);
            _internalCustomer = new Customer(0);
            return builtCustomer;
        }

        public CustomerBuilder WithTestValues()
        {
            _internalCustomer = new Customer(100)
            {
                HomeAddress = new Address(),
                FirstName = "Bob",
                LastName = "Smith",
                CreditRating = 650,
                OrderHistory = new List<Order>(),
                TotalPurchases = 13.37m
            };
            return this;
        }
    }
}
