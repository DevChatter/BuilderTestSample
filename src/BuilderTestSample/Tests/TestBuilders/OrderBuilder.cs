using BuilderTestSample.Model;

namespace BuilderTestSample.Tests.TestBuilders
{
    /// <summary>
    /// Reference: https://ardalis.com/improve-tests-with-the-builder-pattern-for-test-data
    /// </summary>
    public class OrderBuilder
    {
        private CustomerBuilder _customerBuilder = new CustomerBuilder();
        private Order _order = new Order();

        public OrderBuilder Id(int id)
        {
            _order.Id = id;
            return this;
        }

        public OrderBuilder OrderAmount(decimal amount)
        {
            _order.TotalAmount = amount;
            return this;
        }

        public OrderBuilder Customer(Customer customer)
        {
            _order.Customer = customer;
            return this;
        }

        public Order Build()
        {
            var builtOrder = _order;
            _order = new Order();
            return builtOrder;
        }

        public OrderBuilder WithTestValues()
        {
            _order.TotalAmount = 100m;

            _order.Customer = _customerBuilder.WithTestValues()
                .Address(new Address())
                .Build();

            return this;
        }
    }
}
