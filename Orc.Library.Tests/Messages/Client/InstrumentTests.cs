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
                CustomerUniqueIdPattern = "CustomerUniqueId",
                EnforcedCustomerUniqueIdPattern = "EnforcedCustomerUniqueId",
                ExpiryDateStart = new DateTime(2017, 12, 24),
                ExpiryDateEnd = new DateTime(2018, 12, 24),
                IsinCodePattern = "AU12345",
                IgnoreCase = true,
                FeedCodePattern = "FEED",
                IsCleanQuoted = true,
                Kind = "Barrier down and in Call",
                Symbol = "SYMBL",
                Market = "ASX",
                Exchange = "ASX",
                SubMarket = "ASX",
                Issuer = "Issuer",
                DownloadMode = DownloadMode.FullWithDynamicParameters,
                ItemsPerMessage = 250,
                StrikePriceMax = 26,
                StrikePriceMin = 6,
                SuggestVolumeLogic = SuggestVolumeLogic.NotFilled,
                TickRule = "tick tock",
                UnderlyingPattern = "BHP",
                DateChangedFrom = new DateTime(2000, 1, 1),
                DateChangedTo = new DateTime(2015, 1, 1),
                TimeChangedFrom = new TimeSpan(0, 0, 0),
                TimeChangedTo = new TimeSpan(11, 59, 59)
            };

            var expected = new ClientMessageSerializer().Deserialize<InstrumentDownloadMessage>();
            Assert.IsTrue(expected.Match(actual));
        }


        [TestMethod]
        public void TestInstrumentDynamicParameterDeleteMessage()
        {
            var actual = new InstrumentDynamicParameterDeleteMessage
            {
                InstrumentId = new InstrumentId { Feedcode = "BHP", Market = "ASX", Submarket = "Sub" },
                Name = "dynamo"
            };

            var expected = new ClientMessageSerializer().Deserialize<InstrumentDynamicParameterDeleteMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestInstrumentDynamicParameterSetMessage()
        {
            var actual = new InstrumentDynamicParametersSetMessage
            {
                InstrumentId = new InstrumentId { Feedcode = "BHP", Market = "ASX", Submarket = "Sub" },
                DynamicParameters = new DynamicParameters { new DynamicParameter { Name = "dynamic", Value = "value"} }
            };

            var expected = new ClientMessageSerializer().Deserialize<InstrumentDynamicParametersSetMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestInstrumentGetMessage()
        {
            var actual = new InstrumentGetMessage
            {
                InstrumentId = new InstrumentId { Feedcode = "BHP", Market = "ASX", Submarket = "Sub" },
                WithOrcDescription = true
            };

            var expected = new ClientMessageSerializer().Deserialize<InstrumentGetMessage>();
            Assert.IsTrue(expected.Match(actual));
        }


        [TestMethod]
        public void TestInstrumentGroupParametersGetMessage()
        {
            var actual = new InstrumentGroupParametersGetMessage
            {
                AdditionalData = false,
                BaseContract = 101,
                AssetType = AssetType.Equities,
                Currency = "USD",
                CustomerUniqueIdPattern = "CustomerUniqueId",
                EnforcedCustomerUniqueIdPattern = "EnforcedCustomerUniqueId",
                ExpiryDateStart = new DateTime(2017, 12, 24),
                ExpiryDateEnd = new DateTime(2018, 12, 24),
                IsinCodePattern = "AU12345",
                Symbol = "SYMBL",
                Exchange = "ASX",
                Issuer = "Issuer",
                Kind = "Barrier down and in Call",
                Market = "ASX",
                StrikePriceMax = 26,
                StrikePriceMin = 6,
                UnderlyingPattern = "BHP",
            };

            var expected = new ClientMessageSerializer().Deserialize<InstrumentGroupParametersGetMessage>();
            Assert.IsTrue(expected.Match(actual));
        }


        [TestMethod]
        public void TestInstrumentGroupParametersSetMessage()
        {
            var actual = new InstrumentGroupParametersSetMessage
            {
                Parameters = new Parameters { CustomMinVolume = 1000, IsConsolidatedContract = true },
                AdditionalData = false,
                BaseContract = 101,
                AssetType = AssetType.Equities,
                Currency = "USD",
                CustomerUniqueIdPattern = "CustomerUniqueId",
                EnforcedCustomerUniqueIdPattern = "EnforcedCustomerUniqueId",
                ExpiryDateStart = new DateTime(2017, 12, 24),
                ExpiryDateEnd = new DateTime(2018, 12, 24),
                IsinCodePattern = "AU12345",
                Symbol = "SYMBL",
                Exchange = "ASX",
                Issuer = "Issuer",
                Kind = "Barrier down and in Call",
                Market = "ASX",
                StrikePriceMax = 26,
                StrikePriceMin = 6,
                UnderlyingPattern = "BHP",
                DateChangedFrom = new DateTime(2000,1,1),
                DateChangedTo = new DateTime(2015,1,1),
                TimeChangedFrom = new TimeSpan(0,0,0),
                TimeChangedTo = new TimeSpan(11,59,59)
            };

            var expected = new ClientMessageSerializer().Deserialize<InstrumentGroupParametersSetMessage>();
            Assert.IsTrue(expected.Match(actual));
        }


        [TestMethod]
        public void TestInstrumentMultipleFlagSetMessage()
        {
            var actual = new InstrumentMultipleFlagSetMessage
            {
                InstrumentList = new InstrumentList
                {
                    new InstrumentId { Feedcode = "BHP", Market = "ASX", Submarket = "Sub1" },
                    new InstrumentId { Feedcode = "WOW", Market = "ASX", Submarket = "Sub2" },
                },
                Flag = Flag.AutoQuoteFlag,
                Value = true
            };

            var expected = new ClientMessageSerializer().Deserialize<InstrumentMultipleFlagSetMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestInstrumentMultipleParameterSetMessage()
        {
            var actual = new InstrumentMultipleParameterSetMessage
            {
                InstrumentList = new InstrumentList
                {
                    new InstrumentId { Feedcode = "BHP", Market = "ASX", Submarket = "Sub1" },
                    new InstrumentId { Feedcode = "WOW", Market = "ASX", Submarket = "Sub2" },
                },
                Parameter = Parameter.QuoteAskBaseOffset,
                Value = 101.5,
                UpdateType = ParameterUpdateType.Multiplicative
            };

            var expected = new ClientMessageSerializer().Deserialize<InstrumentMultipleParameterSetMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestInstrumentParametersSetMessage()
        {
            var actual = new InstrumentParametersSetMessage
            {
                InstrumentId = new InstrumentId { Feedcode = "BHP", Market = "ASX", Submarket = "Sub1" },
                Parameters = new Parameters { CustomMinVolume = 1000, IsConsolidatedContract = true, AutoDimingAskFlag = false}
            };

            var expected = new ClientMessageSerializer().Deserialize<InstrumentParametersSetMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestInstrumentSetAsPreferredMessage()
        {
            var actual = new InstrumentSetAsPreferredMessage
            {
                InstrumentId = new InstrumentId { Feedcode = "BHP", Market = "ASX", Submarket = "Sub1" }
            };

            var expected = new ClientMessageSerializer().Deserialize<InstrumentSetAsPreferredMessage>();
            Assert.IsTrue(expected.Match(actual));
        }
    }
}
