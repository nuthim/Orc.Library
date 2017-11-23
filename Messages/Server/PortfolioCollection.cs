using System.Runtime.Serialization;
using Orc.Library.Dictionaries;


namespace Orc.Library.Messages.Server
{
    public class PortfolioCollection : OrcMessage
    {

        [DataMember(Name = "portfolios")]
        public Portfolios Portfolios { get; set; }
    }
}