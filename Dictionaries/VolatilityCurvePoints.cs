using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "volatility_curve_points", ItemName = "volatility_curve_point", Namespace = "")]
    public class VolatilityCurvePoints : List<VolatilityCurvePoint>
    {

    }

    [DataContract(Name = "volatility_curve_point", Namespace = "")]
    public class VolatilityCurvePoint
    {
        [DataMember(Name = "strikeprice", IsRequired = true, Order = 1)]
        public double? StrikePrice { get; set; }

        [DataMember(Name = "volatility", IsRequired = true, Order = 2)]
        public double? Volatility { get; set; }
    }
}