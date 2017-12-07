using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "volatility_curve_parameters", ItemName = "volatility_curve_parameter", Namespace = "")]
    public class VolatilityCurveParameters : List<VolatilityCurveParameter>
    {

    }

    [DataContract(Name = "volatility_curve_parameter", Namespace = "")]
    public class VolatilityCurveParameter
    {
        [DataMember(Name = "index", IsRequired = true, Order = 1)]
        public int? Index { get; set; }

        [DataMember(Name = "value", IsRequired = true, Order = 2)]
        public double? Value { get; set; }
    }
}