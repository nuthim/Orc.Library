using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Orc.Library.Enums;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "money_replies", ItemName = "money_reply", Namespace = "")]
    public class MoneyReplies : List<MoneyReply>
    {

    }

    [DataContract(Name = "money_reply", Namespace = "")]
    public class MoneyReply
    {
        [DataMember(Name = "money_tag")]
        public int? MoneyTag { get; set; }

        [DataMember(Name = "kind")]
        public MoneyKind? Kind { get; set; }

        [DataMember(Name = "portfolio")]
        public string Portfolio { get; set; }

        [DataMember(Name = "underlying")]
        public string Underlying { get; set; }

        [DataMember(Name = "amount")]
        public double? Amount { get; set; }

        [DataMember(Name = "fx_rate")]
        public double? FxRate { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "deleted")]
        public bool? Deleted { get; set; }

        [DataMember(Name = "comment")]
        public string Comment { get; set; }

        [DataMember(Name = "customer_reference")]
        public string CustomerReference { get; set; }

        [DataMember(Name = "settlement_date")]
        public DateTime? SettlementDate { get; set; }

        [DataMember(Name = "buy_or_sell")]
        public BuySell? TradeSide { get; set; }

        [DataMember(Name = "trade_date")]
        public DateTime? TradeDate { get; set; }

        [DataMember(Name = "trade_time")]
        public TimeSpan? TradeTime { get; set; }

        [DataMember(Name = "originator")]
        public string Originator { get; set; }

        [DataMember(Name = "owner")]
        public string Owner { get; set; }

    }
}