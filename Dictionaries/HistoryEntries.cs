using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Orc.Library.Enums;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "history_entries", ItemName = "history_entry", Namespace = "")]
    public class HistoryEntries : List<HistoryEntry>
    {

    }

    [DataContract(Name = "history_entry", Namespace = "")]
    public class HistoryEntry
    {
        [DataMember(Name = "action")]
        public HistoryAction? Action { get; set; }

        [DataMember(Name = "entry_comment")]
        public string EntryComment { get; set; }

        [DataMember(Name = "entry_date")]
        public DateTime? EntryDate { get; set; }

        [DataMember(Name = "entry_time")]
        public TimeSpan? EntryTime { get; set; }

        [DataMember(Name = "user")]
        public string User { get; set; }

        [DataMember(Name = "buy_or_sell")]
        public BuySell? BuyOrSell { get; set; }

        [DataMember(Name = "price")]
        public double? Price { get; set; }

        [DataMember(Name = "volume")]
        public double? Volume { get; set; }

        [DataMember(Name = "portfolio")]
        public string Portfolio { get; set; }

        [DataMember(Name = "customer_id")]
        public string CustomerId { get; set; }

        [DataMember(Name = "invested")]
        public double? Invested { get; set; }

        [DataMember(Name = "parent_order_tag")]
        public int? ParentOrderTag { get; set; }

        [DataMember(Name = "basket_order_tag")]
        public int? BasketOrderTag { get; set; }

        [DataMember(Name = "deleted")]
        public bool? Deleted { get; set; }

        [DataMember(Name = "market")]
        public string Market { get; set; }

        [DataMember(Name = "submarket")]
        public string SubMarket { get; set; }

        [DataMember(Name = "origin")]
        public Origin? Origin { get; set; }

        [DataMember(Name = "originator")]
        public string Originator { get; set; }

        [DataMember(Name = "owner")]
        public string Owner { get; set; }

        [DataMember(Name = "contract_tag")]
        public int? ContractTag { get; set; }

        [DataMember(Name = "ytm")]
        public double? Ytm { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "commission")]
        public double? Commission { get; set; }

        [DataMember(Name = "fee")]
        public double? Fee { get; set; }

        [DataMember(Name = "settlement_date")]
        public DateTime? SettlementDate { get; set; }

        [DataMember(Name = "customer_reference")]
        public string CustomerReference { get; set; }

        [DataMember(Name = "comment")]
        public string Comment { get; set; }

        [DataMember(Name = "exchange_order_id")]
        public string ExchangeOrderId { get; set; }
    }

    [DataContract(Namespace = "")]
    public class TradeHistory : HistoryEntry
    {
        [DataMember(Name = "fx_rate")]
        public double? FxRate { get; set; }

        [DataMember(Name = "accrued")]
        public double? Accrued { get; set; }

        [DataMember(Name = "trade_time")]
        public TimeSpan? TradeTime { get; set; }

        [DataMember(Name = "accrued")]
        public bool? Verified { get; set; }

        [DataMember(Name = "buyer")]
        public string Buyer { get; set; }

        [DataMember(Name = "seller")]
        public string Seller { get; set; }

        [DataMember(Name = "exchange_timestamp")]
        public string ExchangeTimestamp { get; set; }

        [DataMember(Name = "trade_date")]
        public DateTime? TradeDate { get; set; }

        [DataMember(Name = "exchange_trade_id")]
        public string ExchangeTradeId { get; set; }
    }

    [DataContract(Namespace = "")]
    public class OrderHistory : HistoryEntry
    {
        [DataMember(Name = "open_volume")]
        public double? OpenVolume { get; set; }

        [DataMember(Name = "volume_filled")]
        public double? VolumeFilled { get; set; }

        [DataMember(Name = "order_kind")]
        public OrderKind? OrderKind { get; set; }

        [DataMember(Name = "order_request")]
        public OrderRequest? OrderRequest { get; set; }

        [DataMember(Name = "status")]
        public OrderStatus? OrderStatus { get; set; }

        [DataMember(Name = "conditional")]
        public bool? Conditional { get; set; }

        [DataMember(Name = "active")]
        public bool? Active { get; set; }

        [DataMember(Name = "onmarket")]
        public bool? OnMarket { get; set; }

        [DataMember(Name = "order_execution_style")]
        public OrderExecutionStyle? ExecutionStyle { get; set; }

        [DataMember(Name = "price_condition")]
        public PriceCondition? PriceCondition { get; set; }

        [DataMember(Name = "volume_condition")]
        public VolumeCondition? VolumeCondition { get; set; }

        [DataMember(Name = "validity")]
        public Validity? Validity { get; set; }

        [DataMember(Name = "valid_date")]
        public DateTime? ValidDate { get; set; }

        [DataMember(Name = "market_order_status")]
        public MarketOrderStatus? MarketOrderStatus { get; set; }

        [DataMember(Name = "market_error")]
        public string MarketError { get; set; }

    }
}
