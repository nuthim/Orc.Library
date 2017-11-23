using System;
using System.Runtime.Serialization;
using Orc.Library.Enums;
using Orc.Library.Dictionaries;

namespace Orc.Library.Messages.Client
{
    /// <summary>
    /// Delete a bookkeeping transaction in the ORC System.
    /// </summary>
    [DataContract(Name = "money_delete", Namespace = "")]
    public class MoneyDeleteMessage : ClientMessage
    {
        [DataMember(Name = "money_tag", IsRequired = true)]
        public int MoneyTag { get; set; }

        public MoneyDeleteMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.money_delete);
        }
    }

    /// <summary>
    /// Insert a bookkeeping transaction into the ORC System.
    /// </summary>
    [DataContract(Name = "money_insert", Namespace = "")]
    public class MoneyInsertMessage : ClientMessage
    {
        [DataMember(Name = "kind", IsRequired = true, Order = 1)]
        public MoneyKind Kind { get; set; }

        [DataMember(Name = "portfolio", IsRequired = true, Order = 2)]
        public string Portfolio { get; set; }

        [DataMember(Name = "underlying", Order = 3)]
        public string Underlying { get; set; }

        [DataMember(Name = "instrument_id", Order = 4)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "amount", IsRequired = true, Order = 5)]
        public double? Amount { get; set; }

        [DataMember(Name = "currency", IsRequired = true, Order = 6)]
        public string Currency { get; set; }

        [DataMember(Name = "comment", Order = 7)]
        public string Comment { get; set; }

        [DataMember(Name = "settlement_date", Order = 8)]
        public DateTime? SettlementDate { get; set; }

        [DataMember(Name = "customer_reference", Order = 9)]
        public string CustomerReference { get; set; }

        [DataMember(Name = "originator", Order = 10)]
        public string Originator { get; set; }

        [DataMember(Name = "owner", Order = 11)]
        public string Owner { get; set; }

        public MoneyInsertMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.money_insert);
        }
    }

    /// <summary>
    /// Get bookkeeping transactions for given date range.
    /// </summary>
    [DataContract(Name = "money_range_get", Namespace = "")]
    public class MoneyDownloadMessage : ClientMessage
    {
        [DataMember(Name = "startdate", IsRequired = true)]
        public DateTime StartDate { get; set; }

        [DataMember(Name = "enddate", IsRequired = true)]
        public DateTime EndDate { get; set; }

        [DataMember(Name = "date_changed_from")]
        public DateTime? DateChangedFrom { get; set; }

        [DataMember(Name = "date_changed_to")]
        public DateTime? DateChangedTo { get; set; }

        [DataMember(Name = "time_changed_from")]
        public TimeSpan? TimeChangedFrom { get; set; }

        [DataMember(Name = "time_changed_to")]
        public TimeSpan? TimeChangedTo { get; set; }

        public MoneyDownloadMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.money_range_get);
        }
    }
}
