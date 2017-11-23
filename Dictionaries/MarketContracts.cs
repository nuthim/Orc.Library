using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "marketcontracts", ItemName = "marketcontract", Namespace = "")]
    public class MarketContracts : List<MarketContract>
    {

    }

    [DataContract(Name = "marketcontract", Namespace = "")]
    public class MarketContract
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "trading_capability")]
        public bool? TradingCapability { get; set; }

        [DataMember(Name = "feed_capability")]
        public bool? FeedCapability { get; set; }

        [DataMember(Name = "ranking")]
        public int? Ranking { get; set; }
    }
}