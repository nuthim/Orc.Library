using Microsoft.VisualStudio.TestTools.UnitTesting;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;
using Orc.Library.Messages.Client;

namespace Orc.Library.Tests.Messages.Client
{

    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void TestCustomerDeleteMessage()
        {
            var actual = new CustomerDeleteMessage { CustomerId = "280781" };
            var expected = new ClientMessageSerializer().Deserialize<CustomerDeleteMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCustomerFieldDeleteMessage()
        {
            var actual = new CustomerFieldDeleteMessage { FieldName = "CustomerAddress" };
            var expected = new ClientMessageSerializer().Deserialize<CustomerFieldDeleteMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCustomerFieldGetMessage()
        {
            var actual = new CustomerFieldGetMessage();
            var expected = new ClientMessageSerializer().Deserialize<CustomerFieldGetMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCustomerFieldInsertMessage()
        {
            var actual = new CustomerFieldInsertMessage {FieldName = "CustomerAddress", Locked = true, Order = 1};
            var expected = new ClientMessageSerializer().Deserialize<CustomerFieldInsertMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCustomerFieldUpdateMessage()
        {
            var actual = new CustomerFieldUpdateMessage { FieldName = "OldName", NewFieldName = "NewName", Order = 1 };
            var expected = new ClientMessageSerializer().Deserialize<CustomerFieldUpdateMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCustomerGetMessage()
        {
            var actual = new CustomerGetMessage {CustomerIdPattern = "280781", IgnoreCase = false };
            var expected = new ClientMessageSerializer().Deserialize<CustomerGetMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCustomerInsertMessage()
        {
            var actual = new CustomerInsertMessage {CustomerId = "280781" };
            var expected = new ClientMessageSerializer().Deserialize<CustomerInsertMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCustomerPortfolioDeleteMessage()
        {
            var actual = new CustomerPortfolioDeleteMessage { CustomerId = "280781", PortfolioName = "Port1" };
            var expected = new ClientMessageSerializer().Deserialize<CustomerPortfolioDeleteMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCustomerPortfolioGetMessage()
        {
            var actual = new CustomerPortfolioGetMessage { CustomerId = "280781", PortfolioName = "Port1" };
            var expected = new ClientMessageSerializer().Deserialize<CustomerPortfolioGetMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCustomerPortfolioInsertMessage()
        {
            var actual = new CustomerPortfolioInsertMessage { CustomerId = "280781", PortfolioName = "Port1" };
            var expected = new ClientMessageSerializer().Deserialize<CustomerPortfolioInsertMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCustomerUpdateMessage()
        {
            var actual = new CustomerUpdateMessage { CustomerId = "280781", NewCustomerId = "280782" };
            var expected = new ClientMessageSerializer().Deserialize<CustomerUpdateMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCustomerValueDeleteMessage()
        {
            var actual = new CustomerValueDeleteMessage { CustomerId = "280781", FieldName = "CustomerAddress" };
            var expected = new ClientMessageSerializer().Deserialize<CustomerValueDeleteMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCustomerValueGetMessage()
        {
            var actual = new CustomerValueGetMessage { CustomerId = "280781", FieldName = "CustomerAddress" };
            var expected = new ClientMessageSerializer().Deserialize<CustomerValueGetMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCustomerValueSearchMessage()
        {
            var actual = new CustomerValueSearchMessage { CustomerId = "280781", FieldName = "CustomerAddress", Value = "Sydney", SearchMode = SearchMode.Equal };
            var expected = new ClientMessageSerializer().Deserialize<CustomerValueSearchMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCustomerValueUpdateMessage()
        {
            var actual = new CustomerValueUpdateMessage { CustomerId = "280781", FieldNameValues = new FieldNameValues
            {
                new FieldNameValue { FieldName = "Name", Value = "Mithun" },
                new FieldNameValue { FieldName = "City", Value = "Sydney" }
            } };
            var expected = new ClientMessageSerializer().Deserialize<CustomerValueUpdateMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

    }
}
