using System;
using BuilderTestSample.Model;

namespace BuilderTestSample.Tests.TestBuilders
{
    public class CustomerBuilder
    {
        private Customer _customer;

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
