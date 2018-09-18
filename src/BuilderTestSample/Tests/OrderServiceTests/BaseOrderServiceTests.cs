using BuilderTestSample.Services;
using BuilderTestSample.Tests.TestBuilders;

namespace BuilderTestSample.Tests.OrderServiceTests
{
    public abstract class BaseOrderServiceTests
    {
        protected readonly OrderService _orderService = new OrderService();
        protected readonly OrderBuilder _orderBuilder = new OrderBuilder();
        protected readonly CustomerBuilder _customerBuilder = new CustomerBuilder();
    }
}