using Microsoft.VisualStudio.TestTools.UnitTesting;
using Orc.Library.Enums;
using Orc.Library.Messages.Client;

namespace Orc.Library.Tests.Messages.Client
{
    [TestClass]
    public class EnumTests
    {
        [TestMethod]
        public void TestEnumMessage()
        {
            var actual = new EnumGetMessage { Type = EnumType.Market };
            var expected = new ClientMessageSerializer().Deserialize<EnumGetMessage>();
            Assert.IsTrue(expected.Match(actual));
        }
    }

}
