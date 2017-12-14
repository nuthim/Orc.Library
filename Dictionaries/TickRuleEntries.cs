using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "tick_rules", ItemName = "tick_rule", Namespace = "")]
    public class TickRules : List<TickRule>
    {

    }

    [DataContract(Name = "tick_rule", Namespace = "")]
    public class TickRule
    {
        [DataMember(Name = "market", IsRequired = true, Order = 1)]
        public string Market { get; set; }

        [DataMember(Name = "tick_rule", IsRequired = true, Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The lowest price where tick is equal to TickValue
        /// </summary>
        [DataMember(Name = "minimum_level", Order = 3)]
        public double? MinimulLevel { get; set; }

        /// <summary>
        /// The tick size for prices greater than or equal to MinimulLevel.
        /// </summary>
        [DataMember(Name = "tick_value", IsRequired = true, Order = 4)]
        public double? TickValue { get; set; }

        /// <summary>
        /// True if the rule is the default for its market.
        /// </summary>
        [DataMember(Name = "is_default", Order = 5)]
        public bool? IsDefault { get; set; }
    }
}