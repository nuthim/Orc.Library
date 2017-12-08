using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "underlying_ratecurve_entries", ItemName = "underlying_ratecurve_entry", Namespace = "")]
    public class UnderlyingRateCurveEntries : List<UnderlyingRateCurveEntry>
    {

    }

    [DataContract(Name = "underlying_ratecurve_entry", Namespace = "")]
    public class UnderlyingRateCurveEntry
    {
        [DataMember(Name = "date", Order = 1)]
        public DateTime? Date { get; set; }

        [DataMember(Name = "days", Order = 2)]
        public int? Days { get; set; }

        /// <summary>
        /// Default 0
        /// </summary>
        [DataMember(Name = "underlying_rate", Order = 3)]
        public double? UnderlyingRate { get; set; }

        /// <summary>
        /// Default 0
        /// </summary>
        [DataMember(Name = "total_underlying_rate", Order = 4)]
        public double? TotalUnderlyingRate { get; set; }
    }
}