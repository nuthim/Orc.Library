using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "kind_restrictions", ItemName = "kind_restriction", Namespace = "")]
    public class KindRestrictions : List<KindRestriction>
    {

    }

    public class KindRestriction
    {
        [DataMember(Name = "portfolio_name")]
        public string PortfolioName { get; set; }

        [DataMember(Name = "kind")]
        public string Kind { get; set; }
    }
}