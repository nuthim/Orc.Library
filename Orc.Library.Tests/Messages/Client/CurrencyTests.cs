using Microsoft.VisualStudio.TestTools.UnitTesting;
using Orc.Library.Messages.Client;

namespace Orc.Library.Tests.Messages.Client
{

    [TestClass]
    public class CurrencyTests
    {
        [TestMethod]
        public void TestCurrencyCreateMessage()
        {
            var actual = new CurrencyCreateMessage { Currency = "USD" };
            var expected = new ClientMessageSerializer().Deserialize<CurrencyCreateMessage>();
            Assert.IsTrue(expected.Match(actual));
        }
    }
}
