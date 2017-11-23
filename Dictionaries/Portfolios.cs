using Orc.Library.Enums;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "portfolios", ItemName = "portfolio", Namespace = "")]
    public class Portfolios : List<Portfolio>
    {

    }

    [DataContract(Name = "portfolio", Namespace = "")]
    public class Portfolio
    {
        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "portfolio_name")]
        public string Name { get; set; }

        [DataMember(Name = "ordervalidate")]
        public OrderValidate? OrderValidate { get; set; }
    }
}
