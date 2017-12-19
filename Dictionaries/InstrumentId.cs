using System;
using System.Runtime.Serialization;
using Orc.Library.Enums;


namespace Orc.Library.Dictionaries
{
    [DataContract(Name = "instrument_id", Namespace = "")]
    public class InstrumentId
    {
        [DataMember(Name = "assettype", Order = 1)]
        public AssetType? AssetType { get; set; }

        [DataMember(Name = "currency", Order = 2)]
        public string Currency { get; set; }

        [DataMember(Name = "customer_unique_id", Order = 3)]
        public string CustomerUniqueId { get; set; }

        [DataMember(Name = "description", Order = 4)]
        public string Description { get; set; }

        [DataMember(Name = "enforced_customer_unique_id", Order = 5)]
        public string EnforcedCustomerUniqueId { get; set; }

        [DataMember(Name = "exchange", Order = 6)]
        public string Exchange { get; set; }

        [DataMember(Name = "expirydate", Order = 7)]
        public DateTime? ExpiryDate { get; set; }

        [DataMember(Name = "expirytype", Order = 8)]
        public ExpiryType? ExpiryType { get; set; }

        [DataMember(Name = "feedcode", Order = 9)]
        public string Feedcode { get; set; }

        [DataMember(Name = "instrument_tag", Order = 10)]
        public int? InstrumentTag { get; set; }

        [DataMember(Name = "isincode", Order = 11)]
        public string IsinCode { get; set; }

        [DataMember(Name = "kind", Order = 12)]
        public string Kind { get; set; }

        [DataMember(Name = "market", Order = 13)]
        public string Market { get; set; }

        [DataMember(Name = "multiplier", Order = 14)]
        public double? Multiplier { get; set; }

        [DataMember(Name = "sedol", Order = 15)]
        public string Sedol { get; set; }

        [DataMember(Name = "strikeprice", Order = 16)]
        public double? StrikePrice { get; set; }

        [DataMember(Name = "submarket", Order = 17)]
        public string Submarket { get; set; }

        [DataMember(Name = "symbol", Order = 18)]
        public string Symbol { get; set; }

        [DataMember(Name = "underlying", Order = 19)]
        public string Underlying { get; set; }

        [DataMember(Name = "valoren", Order = 20)]
        public int? Valoren { get; set; }
    }
}
