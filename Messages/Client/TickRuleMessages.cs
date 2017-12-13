using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Client
{
    /// <summary>
    /// Only custom tick rules can be deleted (i.e. for market [none]).
    /// </summary>
    [DataContract(Name = nameof(MessageType.TICK_RULE_DELETE), Namespace = "")]
    public class TickRuleDeleteMessage : ClientMessage
    {
        /// <summary>
        /// The name of a tick rule.
        /// </summary>
        [DataMember(Name = "tick_rule", IsRequired = true, Order = 1)]
        public string TickRule { get; set; }

        /// <summary>
        /// The lowest price for a tick value. If this key is not specified, all tick levels for the specified tick rule will be deleted.
        /// </summary>
        [DataMember(Name = "minimum_level", Order = 2)]
        public double? MinimumLevel { get; set; }

        public TickRuleDeleteMessage() : base(MessageType.TICK_RULE_DELETE)
        {
            
        }
    }

    /// <summary>
    /// Get all tick.
    /// </summary>
    [DataContract(Name = nameof(MessageType.TICK_RULE_DOWNLOAD), Namespace = "")]
    public class TickRuleDownloadMessage : ClientMessage
    {
        [DataMember(Name = "market", Order = 1)]
        public string Market { get; set; }

        /// <summary>
        /// The name of a tick rule.
        /// </summary>
        [DataMember(Name = "tick_rule", Order = 2)]
        public string TickRule { get; set; }

        /// <summary>
        /// The lowest price for a tick value.
        /// </summary>
        [DataMember(Name = "minimum_level", Order = 3)]
        public double? MinimumLevel { get; set; }

        /// <summary>
        /// "true" if the rule is the default for its market.
        /// </summary>
        [DataMember(Name = "is_default", Order = 4)]
        public bool? IsDefault { get; set; }

        public TickRuleDownloadMessage() : base(MessageType.TICK_RULE_DOWNLOAD)
        {

        }
    }

    /// <summary>
    /// Update an existing rule. If the specified tick rule does not exist, a new tick rule will be created with that name.
    /// </summary>
    [DataContract(Name = nameof(MessageType.TICK_RULE_UPDATE), Namespace = "")]
    public class TickRuleUpdateMessage : ClientMessage
    {
        /// <summary>
        /// The name of the tick rule.
        /// </summary>
        [DataMember(Name = "tick_rule", IsRequired = true, Order = 1)]
        public string TickRule { get; set; }

        /// <summary>
        /// "true" if the rule is the default for its market.
        /// </summary>
        [DataMember(Name = "is_default", Order = 2)]
        public bool? IsDefault { get; set; }

        [DataMember(Name = "tick_rule_entries", Order = 3)]
        public TickRuleEntries TickRuleEntries { get; set; }

        public TickRuleUpdateMessage() : base(MessageType.TICK_RULE_UPDATE)
        {

        }
    }

}
