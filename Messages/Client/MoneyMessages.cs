using System;
using System.ComponentModel.DataAnnotations;
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
        /// <summary>
        /// Unique money transaction identifier.
        /// </summary>
        [DataMember(Name = "money_tag", IsRequired = true)]
        public int MoneyTag { get; set; }

        public MoneyDeleteMessage() : base(MessageType.MONEY_DELETE)
        {

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

        /// <summary>
        /// The name of a portfolio.
        /// </summary>
        [DataMember(Name = "portfolio", IsRequired = true, Order = 2)]
        [StringLength(51)]
        public string Portfolio { get; set; }

        /// <summary>
        /// Have to be set if kind is "Carry", "Balance", "Dividend", "Lending" or "Coupon".
        /// </summary>
        [DataMember(Name = "underlying", Order = 3)]
        [StringLength(32)]
        public string Underlying { get; set; }

        /// <summary>
        /// This can be specified if you do not specify kind. In that case, currency and underlying will be that of the specified instrument.
        /// </summary>
        [DataMember(Name = "instrument_id", Order = 4)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "amount", IsRequired = true, Order = 5)]
        public double? Amount { get; set; }

        /// <summary>
        /// A three letter currency identifier.
        /// </summary>
        [DataMember(Name = "currency", IsRequired = true, Order = 6)]
        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; }

        [DataMember(Name = "comment", Order = 7)]
        [StringLength(64)]
        public string Comment { get; set; }

        /// <summary>
        /// The settlement date.
        /// </summary>
        [DataMember(Name = "settlement_date", Order = 8)]
        public DateTime? SettlementDate { get; set; }

        /// <summary>
        /// Customer reference.
        /// </summary>
        [DataMember(Name = "customer_reference", Order = 9)]
        public string CustomerReference { get; set; }

        /// <summary>
        /// The owner of the order. Default: login_id
        /// </summary>
        [DataMember(Name = "originator", Order = 10)]
        public string Originator { get; set; }

        /// <summary>
        /// The Orc user who performed the trade. Default: login_id.
        /// </summary>
        [DataMember(Name = "owner", Order = 11)]
        public string Owner { get; set; }

        public MoneyInsertMessage() : base(MessageType.MONEY_INSERT)
        {

        }
    }

    /// <summary>
    /// Get bookkeeping transactions for given date range.
    /// </summary>
    [DataContract(Name = "money_range_get", Namespace = "")]
    public class MoneyRangeGetMessage : ClientMessage
    {
        /// <summary>
        /// The first day to fetch order status from.
        /// </summary>
        [DataMember(Name = "startdate", IsRequired = true)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The last day to fetch order status from.
        /// </summary>
        [DataMember(Name = "enddate", IsRequired = true)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// To only include instruments that have been created or modified within the specified time period. 
        /// _to defaults to now and _from defaults to include the first created instrument.
        /// </summary>
        [DataMember(Name = "date_changed_from")]
        public DateTime? DateChangedFrom { get; set; }

        [DataMember(Name = "date_changed_to")]
        public DateTime? DateChangedTo { get; set; }

        [DataMember(Name = "time_changed_from")]
        public TimeSpan? TimeChangedFrom { get; set; }

        [DataMember(Name = "time_changed_to")]
        public TimeSpan? TimeChangedTo { get; set; }

        public MoneyRangeGetMessage() : base(MessageType.MONEY_RANGE_GET)
        {

        }
    }
}
