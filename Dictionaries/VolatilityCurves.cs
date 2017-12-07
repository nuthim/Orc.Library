using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "volatility_curves", ItemName = "volatility_curve", Namespace = "")]
    public class VolatilityCurves : List<VolatilityCurve>
    {

    }

    [DataContract(Name = "volatility_curve", Namespace = "")]
    public class VolatilityCurve
    {
        /// <summary>
        /// One of date or days needs to be specified. If date is specified, the volatility curve will be fixed to that date and if days is specified, 
        /// the volatility curve will be fixed to that number of days (and hence be valid for different dates when time passes). 
        /// Note that the rate is not expressed in percent, i.e. to specify 27%, 0.27 should be entered. Numbers in the interval[0, 1] supported.
        /// </summary>
        [DataMember(Name = "date", Order = 1)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// One of date or days needs to be specified. If date is specified, the volatility curve will be fixed to that date and if days is specified, 
        /// the volatility curve will be fixed to that number of days (and hence be valid for different dates when time passes). 
        /// Note that the rate is not expressed in percent, i.e. to specify 27%, 0.27 should be entered. Numbers in the interval[0, 1] supported.
        /// </summary>
        [DataMember(Name = "days", Order = 2)]
        public int? Days { get; set; }

        [DataMember(Name = "volatility_curve_parameters", Order = 3)]
        public VolatilityCurveParameters VolatilityCurveParameters { get; set; }

        [DataMember(Name = "volatility_curve_points", Order = 4)]
        public VolatilityCurvePoints VolatilityCurvePoints { get; set; }
    }

}