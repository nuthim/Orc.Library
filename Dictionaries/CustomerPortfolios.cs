using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "customer_portfolios", ItemName = "customer_portfolio", Namespace = "")]
    public class CustomerPortfolios : List<CustomerPortfolio>
    {

    }

    [DataContract(Name = "customer_portfolio", Namespace = "")]
    public class CustomerPortfolio
    {
        [DataMember(Name = "customer_id")]
        public string CustomerId { get; set; }

        [DataMember(Name = "portfolio_name")]
        public string PortfolioName { get; set; }
    }
}