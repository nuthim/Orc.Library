using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Server.Replies
{
    [DataContract(Name = nameof(MessageType.TICK_RULE_DELETE), Namespace = "")]
    public class TickRuleDeleteReply : ServerMessage
    {
        [DataMember(Name = "tick_rule", Order = 1)]
        public string TickRule { get; set; }

        [DataMember(Name = "minimum_level", Order = 2)]
        public double? MinimumLevel { get; set; }
    }


    [DataContract(Name = nameof(MessageType.TICK_RULE_DOWNLOAD), Namespace = "")]
    public class TickRuleDownloadReply : ServerMessage
    {
        [DataMember(Name = "tick_rules")]
        public TickRules TickRules { get; set; }
    }

    [DataContract(Name = nameof(MessageType.TICK_RULE_UPDATE), Namespace = "")]
    public class TickRuleUpdateReply : ServerMessage
    {
        [DataMember(Name = "tick_rule")]
        public string TickRule { get; set; }
    }
}
