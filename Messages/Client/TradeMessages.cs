using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Client
{

    /// <summary>
    /// Move a trade in an atomic operation.
    /// </summary>
    [DataContract(Name = nameof(MessageType.TRADE_ALLOCATE), Namespace = "")]
    public class TradeAllocateMessage : ClientMessage
    {
        /// <summary>
        /// Unique trade identifier of the trade to allocate.
        /// </summary>
        [DataMember(Name = "trade_tag", IsRequired = true, Order = 1)]
        public int? TradeTag { get; set; }

        [DataMember(Name = "allocateItems", IsRequired = true, Order = 2)]
        public AllocateItems AllocateItems { get; set; }

        public TradeAllocateMessage() : base(MessageType.TRADE_ALLOCATE)
        {

        }
    }

    /// <summary>
    /// Delete a specified trade.
    /// </summary>
    [DataContract(Name = nameof(MessageType.TRADE_DELETE), Namespace = "")]
    public class TradeDeleteMessage : ClientMessage
    {
        /// <summary>
        /// Unique identifier. Note that it is possible to delete a trade specifying only market and unique_trade_id, thus without using the trade_tag.
        /// </summary>
        [DataMember(Name = "trade_tag", Order = 1)]
        public int? TradeTag { get; set; }

        /// <summary>
        /// This key should be used in combination with "market" to uniquely identify a trade.
        /// </summary>
        [DataMember(Name = "unique_trade_id", Order = 2)]
        public string UniqueTradeId { get; set; }

        [DataMember(Name = "market", Order = 3)]
        public string Market { get; set; }

        /// <summary>
        /// Default: "true". The key is automatically treated as set to 'true' if Trade Handling Service is used.
        /// </summary>
        [DataMember(Name = "update_portfolio", Order = 4)]
        public bool? UpdatePortfolio { get; set; }

        public TradeDeleteMessage() : base(MessageType.TRADE_DELETE)
        {

        }
    }

    /// <summary>
    /// Requests all information about a given trade
    /// </summary>
    [DataContract(Name = nameof(MessageType.TRADE_GET), Namespace = "")]
    public class TradeGetMessage : ClientMessage
    {
        /// <summary>
        /// Unique trade identifier. Only defined for trades done from the Orc client.
        /// </summary>
        [DataMember(Name = "trade_tag", Order = 1)]
        public int? TradeTag { get; set; }

        /// <summary>
        /// This key should be used in combination with "market" to uniquely identify a trade.
        /// </summary>
        [DataMember(Name = "unique_trade_id", Order = 2)]
        public string UniqueTradeId { get; set; }

        [DataMember(Name = "market", Order = 3)]
        public string Market { get; set; }

        public TradeGetMessage() : base(MessageType.TRADE_GET)
        {

        }
    }


    /// <summary>
    /// Retrieve the trade history.
    /// </summary>
    [DataContract(Name = nameof(MessageType.TRADE_HISTORY_GET), Namespace = "")]
    public class TradeHistoryGetMessage : ClientMessage
    {
        /// <summary>
        /// Unique trade identifier. Only defined for trades done from the Orc client.
        /// </summary>
        [DataMember(Name = "trade_tag", IsRequired = true)]
        public int? TradeTag { get; set; }

        public TradeHistoryGetMessage() : base(MessageType.TRADE_HISTORY_GET)
        {

        }
    }

    /// <summary>
    /// Insert a new trade.
    /// In order to make the Orc Trader calculate fees on inserted trades, select the Trade handling option in the Server Links panel for the OP interface.
    /// </summary>
    [DataContract(Name = nameof(MessageType.TRADE_INSERT), Namespace = "")]
    public class TradeInsertMessage : ClientMessage
    {
        [DataMember(Name = "trade", IsRequired = true, Order = 1)]
        public Trade Trade { get; set; }

        /// <summary>
        /// Default is true. The key is automatically treated as true if "Trade Handling" is used 
        /// (either enabled in OP server link panel in the Orc Trader, or trade_handling set to true for the CBLS component trading).
        /// </summary>
        [DataMember(Name = "update_portfolio", Order = 2)]
        public bool? UpdatePortfolio { get; set; }

        /// <summary>
        /// Default is false. Set it to true in order to make inserted trades appear in the Trade ticker in Orc Trader.
        /// </summary>
        [DataMember(Name = "update_ticker", Order = 3)]
        public bool? UpdateTicker { get; set; }

        /// <summary>
        /// Use this to be able to associate trades with orders.
        /// </summary>
        [DataMember(Name = "order_tag", Order = 4)]
        public int? OrderTag { get; set; }

        public TradeInsertMessage() : base(MessageType.TRADE_INSERT)
        {

        }
    }

    /// <summary>
    /// Modifies a trade.
    /// </summary>
    [DataContract(Name = nameof(MessageType.TRADE_MODIFY), Namespace = "")]
    public class TradeModifyMessage : ClientMessage
    {
        /// <summary>
        /// Unique identifier.
        /// </summary>
        [DataMember(Name = "trade_tag", IsRequired = true, Order = 1)]
        public int? TradeTag { get; set; }

        [DataMember(Name = "trade", IsRequired = true, Order = 2)]
        public Trade Trade { get; set; }

        /// <summary>
        /// Default is true. The key is automatically treated as true if "Trade Handling" is used 
        /// (either enabled in OP server link panel in the Orc Trader, or trade_handling set to true for the CBLS component trading).
        /// </summary>
        [DataMember(Name = "update_portfolio", Order = 3)]
        public bool? UpdatePortfolio { get; set; }

        /// <summary>
        /// Default is false. Verify/unverify the trade.
        /// </summary>
        [DataMember(Name = "verified", Order = 4)]
        public bool? Verified { get; set; }

        public TradeModifyMessage() : base(MessageType.TRADE_MODIFY)
        {

        }
    }


    /// <summary>
    /// Get all trades for a given range of days (startdate and enddate can be the same day). By default, the date and time considered correspond to the Orc System (CDS) 
    /// creation date and time. Normally, this coincides with the date and time of the trade as assigned by the market, unless the Orc server system clock or the timezone 
    /// is different from that of the market. It is possible to query upon market time and date instead if preferred.
    /// </summary>
    [DataContract(Name = nameof(MessageType.TRADE_RANGE_GET), Namespace = "")]
    public class TradeRangeGetMessage : ClientMessage
    {
        /// <summary>
        /// Last trade date. The date refers to the CDS creation date of the transaction. Default is today's date, 
        /// if date_change_to is not specified.If date_change_to is specified, enddate will default to that value.
        /// </summary>
        [DataMember(Name = "enddate", Order = 1)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Default is 23:59:59. The time refers to the CDS creation time of the transaction.
        /// </summary>
        [DataMember(Name = "endtime", Order = 2)]
        public TimeSpan? EndTime { get; set; }

        /// <summary>
        /// First trade date. The date refers to the CDS creation date of the transaction. Default is today's date, 
        /// if date_change_from is not specified.If date_change_from is specified, startdate will default to that value.
        /// </summary>
        [DataMember(Name = "startdate", Order = 3)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Default is 00:00:00. The time refers to the CDS creation time of the transaction.
        /// </summary>
        [DataMember(Name = "starttime", Order = 4)]
        public TimeSpan? StartTime { get; set; }

        [DataMember(Name = "date_changed_from", Order = 5)]
        public DateTime? DateChangedFrom { get; set; }

        [DataMember(Name = "date_changed_to", Order = 6)]
        public DateTime? DateChangedTo { get; set; }

        [DataMember(Name = "time_changed_from", Order = 7)]
        public TimeSpan? TimeChangedFrom { get; set; }

        [DataMember(Name = "time_changed_to", Order = 8)]
        public TimeSpan? TimeChangedTo { get; set; }

        /// <summary>
        /// First trade date. Refers to the date of the transaction as assigned by the market connection (note that FIX markets 
        /// always assign the trade date in GMT timezone). Default is today's date.
        /// </summary>
        [DataMember(Name = "market_date_from", Order = 9)]
        public DateTime? MarketDateFrom { get; set; }

        /// <summary>
        /// Last trade date. Refers to the date of the transaction as assigned by the market connection (note that FIX markets 
        /// always assign the trade date in GMT timezone). Default is today's date.
        /// </summary>
        [DataMember(Name = "market_date_to", Order = 10)]
        public DateTime? MarketDateTo { get; set; }

        /// <summary>
        /// Refers to the time as assigned by the market connection (note that FIX markets always assign the trade time in GMT timezone). Default is 00:00:00.
        /// </summary>
        [DataMember(Name = "market_time_from", Order = 11)]
        public TimeSpan? MarketTimeFrom { get; set; }

        /// <summary>
        /// Refers to the time of the transaction as assigned by the market connection (note that FIX markets always assign the trade time in GMT timezone). Default is 23:59:59.
        /// </summary>
        [DataMember(Name = "market_time_to", Order = 12)]
        public TimeSpan? MarketTimeTo { get; set; }

        [DataMember(Name = "customer_id", Order = 13)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Set this to true to only get deleted trades.
        /// </summary>
        [DataMember(Name = "deleted", Order = 14)]
        public bool? DeletedOnly { get; set; }

        [DataMember(Name = "instrument_id", Order = 15)]
        public InstrumentId InstrumentId { get; set; }

        /// <summary>
        /// Set this key in order to receive replies in several messages. Default behavior is that the Orc Protocol sends all replies in one message. 
        /// The recommended value for this key is 1000. If the reply is split up, this will also be indicated by the boolean flag more_replies in the reply_to
        /// dictionary.
        /// </summary>
        [DataMember(Name = "items_per_message", Order = 16)]
        public int? ItemsPerMessage { get; set; }

        [DataMember(Name = "market", Order = 17)]
        public string Market { get; set; }

        [DataMember(Name = "originator", Order = 18)]
        public string Originator { get; set; }

        [DataMember(Name = "origin", Order = 19)]
        public Origin? Origin { get; set; }

        /// <summary>
        /// If specified, only trades for that owner will be received.
        /// </summary>
        [DataMember(Name = "owner", Order = 20)]
        public string Owner { get; set; }

        [DataMember(Name = "portfolio", Order = 21)]
        [StringLength(64)]
        public string Portfolio { get; set; }

        [DataMember(Name = "underlying", Order = 22)]
        [StringLength(32)]
        public string Underlying { get; set; }

        /// <summary>
        /// Set this to true to only get verified trades.
        /// </summary>
        [DataMember(Name = "verified", Order = 23)]
        public bool? VerifiedOnly { get; set; }

        public TradeRangeGetMessage() : base(MessageType.TRADE_RANGE_GET)
        {

        }
    }

    /// <summary>
    /// Verify a specified trade. This message can also act on money transactions.
    /// </summary>
    [DataContract(Name = nameof(MessageType.TRADE_VERIFY), Namespace = "")]
    public class TradeVerifyMessage : ClientMessage
    {
        /// <summary>
        /// Unique identifier.
        /// </summary>
        [DataMember(Name = "trade_tag", IsRequired = true, Order = 1)]
        public int? TradeTag { get; set; }

        /// <summary>
        /// Default is true. Verify/unverify the trade.
        /// </summary>
        [DataMember(Name = "verified", Order = 2)]
        public bool? Verify { get; set; }

        public TradeVerifyMessage() : base(MessageType.TRADE_VERIFY)
        {

        }
    }

    /// <summary>
    /// Calculate the trading power for a portfolio with the possibility to check if an order will go through.
    /// </summary>
    [DataContract(Name = nameof(MessageType.TRADING_POWER), Namespace = "")]
    public class TradingPowerMessage : ClientMessage
    {
        [DataMember(Name = "portfolio", IsRequired = true, Order = 1)]
        [StringLength(64)]
        public bool? UpdatePortfolio { get; set; }

        [DataMember(Name = "instrument_id", Order = 2)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "buy_or_sell", IsRequired = true, Order = 3)]
        public BuySell? BuyOrSell { get; set; }

        [DataMember(Name = "order_volume", IsRequired = true, Order = 4)]
        public double? OrderVolume { get; set; }

        [DataMember(Name = "order_price", IsRequired = true, Order = 5)]
        public double? OrderPrice { get; set; }

        /// <summary>
        /// If specified, conversion is made to the specified currency.
        /// </summary>
        [DataMember(Name = "currency", Order = 6)]
        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; }

        public TradingPowerMessage() : base(MessageType.TRADING_POWER)
        {

        }
    }
}