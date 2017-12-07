using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "volatility_entries", ItemName = "volatility_entry", Namespace = "")]
    public class VolatilityEntries : List<VolatilityEntry>
    {

    }

    /// <summary>
    /// Only one volatility entry can refer to each expiry date.
    /// </summary>
    [DataContract(Name = "volatility_entry", Namespace = "")]
    public class VolatilityEntry
    {
        /// <summary>
        /// This can be specified either as date or days. If date is used, then the curve will be of fixed date type 
        /// and if days is specified, the curve will be of fixed days type.
        /// </summary>
        [DataMember(Name = "days", Order = 1)]
        public int? Days { get; set; }

        [DataMember(Name = "date", Order = 2)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// ATM Forward. This is ignored if SSR = 0.
        /// </summary>
        [DataMember(Name = "atm_price", Order = 3)]
        public double? AtmPrice { get; set; }

        [DataMember(Name = "strike_volatilities", Order = 4)]
        public StrikeVolatilities StrikeVolatilities { get; set; }

        [DataMember(Name = "volatility_change_rate", Order = 5)]
        public double? VolatilityChangeRate { get; set; }

        [DataMember(Name = "slope_change_rate", Order = 6)]
        public double? SlopeChangeRate { get; set; }

        [DataMember(Name = "skew_swimmingness_rate", Order = 7)]
        public double? SkewSwimmingnessRate { get; set; }

    }
}