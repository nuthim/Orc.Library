using System;
using System.Runtime.Serialization;
using Orc.Library.Enums;


namespace Orc.Library.Dictionaries
{
    [DataContract(Name = "instrument_id", Namespace = "")]
    public class InstrumentId
    {
        [DataMember(Name = "assettype")]
        public AssetType? AssetType { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "customer_unique_id")]
        public string CustomerUniqueId { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "enforced_customer_unique_id")]
        public string EnforcedCustomerUniqueId { get; set; }

        [DataMember(Name = "exchange")]
        public string Exchange { get; set; }

        [DataMember(Name = "expirydate")]
        public DateTime? ExpiryDate { get; set; }

        [DataMember(Name = "expirytype")]
        public ExpiryType? ExpiryType { get; set; }

        [DataMember(Name = "feedcode")]
        public string Feedcode { get; set; }

        [DataMember(Name = "instrument_tag")]
        public int? InstrumentTag { get; set; }

        [DataMember(Name = "isincode")]
        public string IsinCode { get; set; }

        [DataMember(Name = "kind")]
        public string Kind { get; set; }

        [DataMember(Name = "market")]
        public string Market { get; set; }

        [DataMember(Name = "multiplier")]
        public double? Multiplier { get; set; }

        [DataMember(Name = "sedol")]
        public string Sedol { get; set; }

        [DataMember(Name = "strikeprice")]
        public double? StrikePrice { get; set; }

        [DataMember(Name = "submarket")]
        public string Submarket { get; set; }

        [DataMember(Name = "symbol")]
        public string Symbol { get; set; }

        [DataMember(Name = "underlying")]
        public string Underlying { get; set; }

        [DataMember(Name = "valoren")]
        public int? Valoren { get; set; }
    }
}
