using System.Collections.Generic;
using System.Runtime.Serialization;
using Orc.Library.Enums;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "yield_curve", ItemName = "yield_curve_entry", Namespace = "")]
    public class YieldCurve : List<YieldCurveEntry>
    {

    }

    [DataContract(Name = "yield_curve_entry", Namespace = "")]
    public class YieldCurveEntry
    {
        /// <summary>
        /// Number of days
        /// </summary>
        [DataMember(Name = "days", IsRequired = true, Order = 1)]
        public int? Days { get; set; }

        /// <summary>
        /// The rate for a specified number of days. 
        /// Note that the rate is not expressed in percent, i.e.to specify 27%, 0.27 should be entered.Numbers in the interval[0, 1] supported.
        /// </summary>
        [DataMember(Name = "rate", IsRequired = true, Order = 2)]
        public double? Rate { get; set; }

        [DataMember(Name = "ratetype", IsRequired = true, Order = 3)]
        public RateType? RateType { get; set; }

        [DataMember(Name = "ratedays", IsRequired = true, Order = 4)]
        public DayConvention? RateDays { get; set; }

        [DataMember(Name = "market", IsRequired = true, Order = 5)]
        public string Market { get; set; }

        [DataMember(Name = "feedcode", IsRequired = true, Order = 6)]
        public string FeedCode { get; set; }
    }


}
