using System;
using System.Runtime.Serialization;
using Orc.Library.Enums;

namespace Orc.Library.Dictionaries
{
    public class Trade
    {
        [DataMember(Name = "buy_or_sell")]
        public BuySell TradeSide { get; set; }

        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "volume")]
        public double Volume { get; set; }

        [DataMember(Name = "accrued")]
        public double? Accrued { get; set; }

        [DataMember(Name = "additional_data")]
        public AdditionalData AdditionalKeys { get; set; }

        [DataMember(Name = "buyer")]
        public string Buyer { get; set; }

        [DataMember(Name = "comment")]
        public string Comment { get; set; }

        [DataMember(Name = "commission")]
        public double? Commission { get; set; }

        [DataMember(Name = "counterpart")]
        public string Counterpart { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "customer_id")]
        public string CustomerId { get; set; }

        [DataMember(Name = "customer_reference")]
        public string CustomerReference { get; set; }

        [DataMember(Name = "date_created")]
        public DateTime DateCreated { get; set; }

        [DataMember(Name = "exchange_order_id")]
        public string ExchangeOrderId { get; set; }

        [DataMember(Name = "exchange_timestamp")]
        public string ExchangeTimestamp { get; set; }

        [DataMember(Name = "exchange_trade_id")]
        public string ExchangeTradeId { get; set; }

        [DataMember(Name = "fee")]
        public double? Fee { get; set; }

        [DataMember(Name = "fx_rate")]
        public double? FxRate { get; set; }

        [DataMember(Name = "invested")]
        public double? Invested { get; set; }

        [DataMember(Name = "market")]
        public string Market { get; set; }

        [DataMember(Name = "mic")]
        public string Mic { get; set; }

        [DataMember(Name = "bic")]
        public string Bic { get; set; }

        [DataMember(Name = "origin")]
        public string Origin { get; set; }

        [DataMember(Name = "originator")]
        public string Originator { get; set; }

        [DataMember(Name = "owner")]
        public string Owner { get; set; }

        [DataMember(Name = "portfolio")]
        public string Portfolio { get; set; }

        [DataMember(Name = "price")]
        public double? Price { get; set; }

        [DataMember(Name = "priority")]
        public int? Priority { get; set; }

        [DataMember(Name = "seller")]
        public string Seller { get; set; }

        [DataMember(Name = "settlement_date")]
        public DateTime? SettlementDate { get; set; }

        [DataMember(Name = "settlement_days")]
        public int? SettlementDays { get; set; }

        [DataMember(Name = "submarket")]
        public string Submarket { get; set; }

        [DataMember(Name = "trade_date")]
        public DateTime? TradeDate { get; set; }

        [DataMember(Name = "trade_time")]
        public TimeSpan? TradeTime { get; set; }

        [DataMember(Name = "unique_trade_id")]
        public string UniqueTradeId { get; set; }

        [DataMember(Name = "ytm")]
        public double? Ytm { get; set; }
    }
}
