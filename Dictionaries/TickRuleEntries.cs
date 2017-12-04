using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "tick_rule_entries", ItemName = "tick_rule_entry", Namespace = "")]
    public class TickRuleEntries : List<TickRuleEntry>
    {

    }

    [DataContract(Name = "tick_rule_entry", Namespace = "")]
    public class TickRuleEntry
    {
        /// <summary>
        /// The lowest price where tick is equal to 'tick value'.
        /// </summary>
        [DataMember(Name = "minimum_level", Order = 1)]
        public double? MinimulLevel { get; set; }

        /// <summary>
        /// The tick size for prices greater than or equal to 'minimum_level'.
        /// </summary>
        [DataMember(Name = "tick_value", Order = 2)]
        public double? TickValue { get; set; }
    }
}