using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "yield_curve_downloads", ItemName = "yield_curve_download", Namespace = "")]
    public class YieldCurveDownloads : List<YieldCurveDownload>
    {

    }

    [DataContract(Name = "yield_curve_download", Namespace = "")]
    public class YieldCurveDownload
    {
        /// <summary>
        /// The ORC name of the yield curve.
        /// </summary>
        [DataMember(Name = "yield_name", IsRequired = true, Order = 1)]
        [StringLength(64)]
        public string YieldName { get; set; }

        /// <summary>
        /// A three letter currency identifier.
        /// </summary>
        [DataMember(Name = "currency", IsRequired = true, Order = 2)]
        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; }

        [DataMember(Name = "yield_curve", IsRequired = true, Order = 3)]
        public YieldCurve YieldCurve { get; set; }
    }
}