using System;
using BuilderTestSample.Model;

namespace BuilderTestSample.Tests.TestBuilders
{
    public class CustomerBuilder
    {
        private Customer _customer;

        public CustomerBuilder Address(Address address)
        {
            _customer.HomeAddress = address;
            return this;
        }

        public Customer Build()
        {
            return _customer;
        }

        public CustomerBuilder WithTestValues(int id)
        {
            _customer = new Customer(id);
            return this;
        }
    }
}
