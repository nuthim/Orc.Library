using System.Runtime.Serialization;
using Orc.Library.Enums;
using Orc.Library.Dictionaries;

namespace Orc.Library.Messages.Server
{
    [DataContract(Name = nameof(MessageType.MONEY_DELETE), Namespace = "")]
    public class MoneyDeleteReply : ServerMessage
    {
        [DataMember(Name = "money_tag")]
        public int MoneyTag { get; set; }
    }

    [DataContract(Name = nameof(MessageType.MONEY_INSERT), Namespace = "")]
    public class MoneyInsertReply : ServerMessage
    {
        [DataMember(Name = "money_tag")]
        public int MoneyTag { get; set; }
    }

    [DataContract(Name = nameof(MessageType.MONEY_RANGE_GET), Namespace = "")]
    public class MoneyRangeGetReply : ServerMessage
    {
        [DataMember(Name = "money_replies")]
        public MoneyReplies MoneyReplies { get; set; }
    }
}
