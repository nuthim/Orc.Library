using Orc.Library.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "monitor_order_conditions", ItemName = "monitor_order_condition", Namespace = "")]
    public class MonitorOrderConditions : List<MoneyReply>
    {

    }

    [DataContract(Name = "monitor_order_condition", Namespace = "")]
    public class MonitorOrderCondition
    {
        [DataMember(Name = "monitor_condition")]
        public MonitorCondition? MonitorCondition { get; set; }

        [DataMember(Name = "monitor_type")]
        public MonitorType? MonitorType { get; set; }

        [DataMember(Name = "price")]
        public double? Price { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "time")]
        public TimeSpan? Time { get; set; }

        [DataMember(Name = "volume")]
        public double? Volume { get; set; }

        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }
    }
}