using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Orc.Library.Enums;

namespace Orc.Library.Dictionaries
{
    [DataContract(Name = "instrument_attributes", Namespace = "")]
    public class InstrumentAttributes
    {
        [DataMember(Name = "assettype", Order = 1)]
        public AssetType? AssetType { get; set; }

        [DataMember(Name = "kind", Order = 2)]
        public string Kind { get; set; }

        [DataMember(Name = "underlying", Order = 3)]
        [StringLength(32)]
        public string Underlying { get; set; }

        /// <summary>
        /// The expiration date. Default: Today.
        /// </summary>
        [DataMember(Name = "expirydate", Order = 4)]
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// The strike price. Only non-negative numbers are accepted. Default is 0.0.
        /// </summary>
        [DataMember(Name = "strikeprice", Order = 5)]
        [Range(0.0, double.MaxValue)]
        public double? StrikePrice { get; set; }


        [DataMember(Name = "currency", Order = 6)]
        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; }

        /// <summary>
        /// "European" or "American". Default: "American".
        /// </summary>
        [DataMember(Name = "expirytype", Order = 7)]
        public ExpiryType? ExpiryType { get; set; }

        /// <summary>
        /// The maturity date of the contract.
        /// </summary>
        [DataMember(Name = "maturitydate", Order = 8)]
        public DateTime? MaturityDate { get; set; }

        /// <summary>
        /// Default: 1.0.
        /// </summary>
        [DataMember(Name = "multiplier", Order = 9)]
        public double? Multiplier { get; set; }

        /// <summary>
        /// Only for information. Should not be set when doing inserts or updates.
        /// </summary>
        [DataMember(Name = "username", Order = 10)]
        [StringLength(64)]
        public string Username { get; set; }
    }
}