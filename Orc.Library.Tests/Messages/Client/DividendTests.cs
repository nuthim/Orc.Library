using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;
using Orc.Library.Messages.Client;

namespace Orc.Library.Tests.Messages.Client
{

    [TestClass]
    public class DividendTests
    {
        [TestMethod]
        public void TestDividendDeleteMessage()
        {
            var actual = new DividendDeleteMessage { InstrumentId = new InstrumentId {Feedcode = "BHP", Market = "ASX" } };
            var expected = new ClientMessageSerializer().Deserialize<DividendDeleteMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestDividendGetMessage()
        {
            var actual = new DividendGetMessage
            {
                InstrumentId = new InstrumentId { Feedcode = "BHP", Market = "ASX", Submarket = "Sub"},
                DividendKinds = new DividendKinds { DividendKind.SpotRelative, DividendKind.ConvertibleCallDate, DividendKind.FloatingNegative }
            };
            var expected = new ClientMessageSerializer().Deserialize<DividendGetMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestDividendInsertMessage()
        {
            var actual = new DividendInsertMessage
            {
                InstrumentId = new InstrumentId { Feedcode = "BHP", Market = "ASX", Submarket = "Sub" },
                Dividend = new Dividend { Amount = 1500, DividendDate = new DateTime(1981, 7, 28), ExDividendDate = new DateTime(1981, 7, 17) }
            };
            var expected = new ClientMessageSerializer().Deserialize<DividendInsertMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestDividendUpdateMessage()
        {
            var actual = new DividendUpdateMessage
            {
                InstrumentId = new InstrumentId { Feedcode = "BHP", Market = "ASX", Submarket = "Sub" },
                Dividends = new Dividends
                {
                    new Dividend { Amount = 1500, DividendDate = new DateTime(1981, 7, 28), ExDividendDate = new DateTime(1981, 7, 17) },
                    new Dividend { Amount = 2500, DividendDate = new DateTime(1985, 7, 28), ExDividendDate = new DateTime(1985, 7, 17) }
                },
                UpdateAllKinds = true
            };
            var expected = new ClientMessageSerializer().Deserialize<DividendUpdateMessage>();
            Assert.IsTrue(expected.Match(actual));
        }
    }
}
