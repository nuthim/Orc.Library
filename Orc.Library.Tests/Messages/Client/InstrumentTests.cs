using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;
using Orc.Library.Messages.Client;

namespace Orc.Library.Tests.Messages.Client
{
    [TestClass]
    public class InstrumentTests
    {
        [TestMethod]
        public void TestInstrumentAttributesSetMessage()
        {
            var actual = new InstrumentAttributesSetMessage
            {
                InstrumentId = new InstrumentId {Feedcode = "BHP", Market = "ASX", Submarket = "Sub"},
                InstrumentAttributes = new InstrumentAttributes { AssetType = AssetType.Equities, ExpiryType = ExpiryType.American, Multiplier = 100, MaturityDate = new DateTime(2000, 11, 16)}
            };
            
            var expected = new ClientMessageSerializer().Deserialize<InstrumentAttributesSetMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestInstrumentCleanupExpiredMessage()
        {
            var actual = new InstrumentCleanupExpiredMessage {ExpiryDate = new DateTime(2015, 12, 25)};
            var expected = new ClientMessageSerializer().Deserialize<InstrumentCleanupExpiredMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestInstrumentCreateMessage()
        {
            var actual = new InstrumentCreateMessage
            {
                InstrumentAttributes = new InstrumentAttributes { AssetType = AssetType.InterestRate, ExpiryType = ExpiryType.American, Multiplier = 100, MaturityDate = new DateTime(2000, 11, 16) },
                Parameters = new Parameters { CustomMinVolume = 1000, IsConsolidatedContract = true }
            };

            var expected = new ClientMessageSerializer().Deserialize<InstrumentCreateMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestInstrumentDeleteMessage()
        {
            var actual = new InstrumentDeleteMessage
            {
                InstrumentId = new InstrumentId { Feedcode = "BHP", Market = "ASX", Submarket = "Sub" },
                ErrorIfBaseContract = false
            };

            var expected = new ClientMessageSerializer().Deserialize<InstrumentDeleteMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestInstrumentDownloadMessage()
        {
            var actual = new InstrumentDownloadMessage
            {
                BaseContract = 101,
                AssetType = AssetType.Equities,
                Currency = "USD",
                CustomerUniqueIdPattern = "Morgan",
                DownloadMode = DownloadMode.FullWithDynamicParameters,
                ItemsPerMessage = 250,
                ExpiryDateEnd = new DateTime(2018, 12, 24),
                StrikePriceMax = 26,
                StrikePriceMin = 6,
                SuggestVolumeLogic = SuggestVolumeLogic.NotFilled,
                TickRule = "tick tock",
                UnderlyingPattern = "BHP"
            };

            var expected = new ClientMessageSerializer().Deserialize<InstrumentDownloadMessage>();
            Assert.IsTrue(expected.Match(actual));
        }
    }
}
