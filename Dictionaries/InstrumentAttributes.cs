using System;
using System.Runtime.Serialization;
using Orc.Library.Enums;

namespace Orc.Library.Dictionaries
{
    [DataContract(Name = "instrument_attributes", Namespace = "")]
    public class InstrumentAttributes
    {
        [DataMember(Name = "assettype")]
        public AssetType? AssetType { get; set; }

        [DataMember(Name = "kind")]
        public string Kind { get; set; }

        [DataMember(Name = "underlying")]
        public string Underlying { get; set; }

        [DataMember(Name = "expirydate")]
        public DateTime? ExpiryDate { get; set; }

        [DataMember(Name = "strikeprice")]
        public double? StrikePrice { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "expirytype")]
        public ExpiryType? ExpiryType { get; set; }

        [DataMember(Name = "maturitydate")]
        public DateTime? MaturityDate { get; set; }

        [DataMember(Name = "multiplier")]
        public double? Multiplier { get; set; }

        [DataMember(Name = "username")]
        public string Username { get; set; }
    }
}