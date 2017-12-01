using System.Runtime.Serialization;
using Orc.Library.Dictionaries;


namespace Orc.Library.Messages.Server
{
    public class PortfolioCollection : ServerMessage
    {

        [DataMember(Name = "portfolios")]
        public Portfolios Portfolios { get; set; }
    }
}