using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "portfolio_components", ItemName = "portfolio_component", Namespace = "")]
    public class PortfolioComponents : List<PortfolioComponent>
    {

    }

    [DataContract(Name = "portfolio_component", Namespace = "")]
    public class PortfolioComponent
    {
        [DataMember(Name = "portfolio_name")]
        public string PortfolioName { get; set; }

        /// <summary>
        /// True if it is a summation portfolio. Otherwise false.
        /// </summary>
        [DataMember(Name = "summation_type")]
        public bool? IsSummationType { get; set; }
    }
}
