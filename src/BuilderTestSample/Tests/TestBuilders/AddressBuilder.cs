﻿using System.Reflection.Metadata.Ecma335;
using BuilderTestSample.Model;

namespace BuilderTestSample.Tests.TestBuilders
{
    public class AddressBuilder
    {
        private Address _internalAddress = new Address();

        public Address Build()
        {
            var builtAddress = _internalAddress;
            _internalAddress = new Address();
            return builtAddress;
        }

        public AddressBuilder WithTestValues()
        {
            _internalAddress.Street1 = "123 Fake St.";
            return this;
        }

        public AddressBuilder Street1(string street1)
        {
            _internalAddress.Street1 = street1;
            return this;
        }
    }
}