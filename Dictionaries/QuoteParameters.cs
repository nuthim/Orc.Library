using System.Runtime.Serialization;


namespace Orc.Library.Dictionaries
{
    [DataContract(Name = "quote_parameters", Namespace = "")]
    public class QuoteParameters
    {
        [DataMember(Name = "quote_bid_volume")]
        public double? QuoteBidVolume { get; set; }

        [DataMember(Name = "quote_ask_volume")]
        public double? QuoteAskVolume { get; set; }

        [DataMember(Name = "quote_bid")]
        public double? QuoteBid { get; set; }

        [DataMember(Name = "quote_ask")]
        public double? QuoteAsk { get; set; }
    }
}
