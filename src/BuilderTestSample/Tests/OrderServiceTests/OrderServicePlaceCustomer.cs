using BuilderTestSample.Exceptions;
using BuilderTestSample.Model;
using BuilderTestSample.Tests.OrderServiceTests;
using Xunit;

namespace BuilderTestSample.Tests
{
    public class PlaceOrderThrowsInvalidCustomer : BaseOrderServiceTests
    {
        [Fact]
        public void ThrowsException_GivenCustomerWithIdZero()
        {
            var order = _orderBuilder
                .WithTestValues()
                .Customer(_customerBuilder.WithTestValues().Id(0).Build())
                .Build();

            Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        }

        [Fact]
        public void ThrowsException_GivenCustomerWithoutAddress()
        {
            Customer customer = _customerBuilder
                .WithTestValues()
                .Address(null)
                .Build();
            var order = _orderBuilder.WithTestValues().Customer(customer).Build();

            Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        }

        [Fact]
        public void ThrowsException_GivenCustomerWithoutFullName()
        {
            Customer customer = _customerBuilder
                .WithTestValues()
                .FirstName(null).LastName(null)
                .Build();
            var order = _orderBuilder.WithTestValues().Customer(customer).Build();

            Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        }

        //[Fact]
        //public void ThrowsException_GivenCustomerWithTotalZero()
        //{
        //    Customer customer = _customerBuilder
        //        .WithTestValues()
        //        .Total(0)
        //        .Build();
        //    var order = _orderBuilder.WithTestValues().Customer(customer).Build();

        //    Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        //}
    }
}
