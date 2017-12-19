using Microsoft.VisualStudio.TestTools.UnitTesting;
using Orc.Library.Enums;
using Orc.Library.Messages.Client;

namespace Orc.Library.Tests.Messages.Client
{

    [TestClass]
    public class LoginLogoutTests
    {
        [TestMethod]
        public void TestLoginMessage()
        {
            var actual = new LoginMessage { LoginId = "mithun", Password = "passw0rd", AllowPing = true, PingInterval = 30, PingTimeout = 30 };
            var expected = new ClientMessageSerializer().Deserialize<LoginMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestLogoutMessage()
        {
            var actual = new LogoutMessage { SuppressReply = SuppressReply.All };
            var expected = new ClientMessageSerializer().Deserialize<LogoutMessage>();
            Assert.IsTrue(expected.Match(actual));
        }
    }
}
