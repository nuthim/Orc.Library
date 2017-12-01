using System;
using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;


namespace Orc.Library.Messages.Client
{
    /// <summary>
    /// Broadcast price feed to all connected Orc Traders that have accepted price feed from the Orc Protocol
    /// </summary>
    [DataContract(Name = "price_get", Namespace = "")]
    public class PriceFeedBroadcastMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId Instrument { get; set; }

        [DataMember(Name = "bid_volume", Order = 2)]
        public int? BidVolume { get; set; }

        [DataMember(Name = "bid", Order = 3)]
        public double? Bid { get; set; }

        [DataMember(Name = "ask_volume", Order = 4)]
        public int? AskVolume { get; set; }

        [DataMember(Name = "ask", Order = 5)]
        public double? Ask { get; set; }

        [DataMember(Name = "bid_ytm", Order = 6)]
        public double? BidYtm { get; set; }

        [DataMember(Name = "ask_ytm", Order = 7)]
        public double? AskYtm { get; set; }

        [DataMember(Name = "last_volume", Order = 8)]
        public int? LastVolume { get; set; }

        [DataMember(Name = "last", Order = 9)]
        public double? Last { get; set; }

        [DataMember(Name = "high", Order = 10)]
        public double? High { get; set; }

        [DataMember(Name = "low", Order = 11)]
        public double? Low { get; set; }

        [DataMember(Name = "close", Order = 12)]
        public double? Close { get; set; }

        [DataMember(Name = "open", Order = 13)]
        public double? Open { get; set; }

        [DataMember(Name = "turnover_volume", Order = 14)]
        public int? TurnoverVolume { get; set; }

        [DataMember(Name = "turnover", Order = 15)]
        public double? Turnover { get; set; }

        [DataMember(Name = "bid_valuation", Order = 16)]
        public double? BidValuation { get; set; }

        [DataMember(Name = "ask_valuation", Order = 17)]
        public double? AskValuation { get; set; }

        [DataMember(Name = "ask_highlight", Order = 18)]
        public bool? AskHighlight { get; set; }

        [DataMember(Name = "bid_highlight", Order = 19)]
        public bool? BidHighlight { get; set; }

        [DataMember(Name = "settlement_price", Order = 20)]
        public double? SettlementPrice { get; set; }

        public PriceFeedBroadcastMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.PRICE_GET);
        }
    }
}
