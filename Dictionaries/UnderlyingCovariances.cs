using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "underlying_covariances", ItemName = "underlying_covariance", Namespace = "")]
    public class UnderlyingCovariances : List<Underlying>
    {

    }

    [DataContract(Name = "underlying_covariance", Namespace = "")]
    public class UnderlyingCovariance
    {
        [DataMember(Name = "underlying1", Order = 1)]
        public string Underlying1 { get; set; }

        [DataMember(Name = "underlying2", Order = 2)]
        public string Underlying2 { get; set; }

        [DataMember(Name = "days", Order = 3)]
        public int? Days { get; set; }

        [DataMember(Name = "covariance", Order = 3)]
        public double? Covariance { get; set; }
    }
}