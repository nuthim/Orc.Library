using System.Runtime.Serialization;
using Orc.Library.Dictionaries;


namespace Orc.Library.Messages.Server
{
    public class MoneyFeed : OrcMessage
    {
        [DataMember(Name = "money_reply")]
        public MoneyReply MoneyReply { get; set; }
    }

}