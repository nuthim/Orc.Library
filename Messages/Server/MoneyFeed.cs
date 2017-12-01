using System.Runtime.Serialization;
using Orc.Library.Dictionaries;


namespace Orc.Library.Messages.Server
{
    public class MoneyFeed : ServerMessage
    {
        [DataMember(Name = "money_reply")]
        public MoneyReply MoneyReply { get; set; }
    }

}