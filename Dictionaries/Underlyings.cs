using System.Collections.Generic;
using System.Runtime.Serialization;
using Orc.Library.Enums;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "underlyings", ItemName = "underlying", Namespace = "")]
    public class Underlyings : List<Underlying>
    {

    }

    [DataContract(Name = "underlying", Namespace = "")]
    public class Underlying
    {
        [DataMember(Name = "underlying_name", Order = 1)]
        public string UnderlyingName { get; set; }

        [DataMember(Name = "currency", Order = 2)]
        public string Currency { get; set; }

        [DataMember(Name = "assettype", Order = 3)]
        public AssetType? AssetType { get; set; }

        [DataMember(Name = "beta", Order = 4)]
        public double? Beta { get; set; }

        [DataMember(Name = "betabase", Order = 5)]
        public InstrumentId BetaBase { get; set; }

        [DataMember(Name = "marketinfo", Order = 6)]
        public string MarketInfo { get; set; }

        [DataMember(Name = "strike_conversion", Order = 7)]
        public StrikeConversion? StrikeConversion { get; set; }

        [DataMember(Name = "beta_logic", Order = 8)]
        public BetaLogic? BetaLogic { get; set; }

        [DataMember(Name = "riskunderlying", Order = 9)]
        public string RiskUnderlying { get; set; }

        [DataMember(Name = "restriction", Order = 10)]
        public UnderlyingRestriction? Restriction { get; set; }

        [DataMember(Name = "preferredspot", Order = 11)]
        public InstrumentId PreferredSpot { get; set; }

        [DataMember(Name = "quote_volatility_surface", Order = 12)]
        public string QuoteVolatilitySurface { get; set; }

        [DataMember(Name = "risk_volatility_surface", Order = 13)]
        public string RiskVolatilitySurface { get; set; }

    }

}