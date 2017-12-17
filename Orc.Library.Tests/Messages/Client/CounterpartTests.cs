using Microsoft.VisualStudio.TestTools.UnitTesting;
using Orc.Library.Messages.Client;

namespace Orc.Library.Tests.Messages.Client
{

    [TestClass]
    public class CounterpartTests
    {
        [TestMethod]
        public void TestCounterpartAddMessage()
        {
            var actual = new CounterpartAddMessage { Counterpart = "J.P.Morgan" };
            var expected = new ClientMessageSerializer().Deserialize<CounterpartAddMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCounterpartDownloadMessage()
        {
            var actual = new CounterpartDownloadMessage();
            var expected = new ClientMessageSerializer().Deserialize<CounterpartDownloadMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCounterpartRemoveMessage()
        {
            var actual = new CounterpartRemoveMessage { Counterpart = "J.P.Morgan" };
            var expected = new ClientMessageSerializer().Deserialize<CounterpartRemoveMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

    }
}
