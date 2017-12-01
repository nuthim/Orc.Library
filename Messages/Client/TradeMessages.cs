
using Orc.Library.Dictionaries;
using Orc.Library.Enums;
using System;
using System.Runtime.Serialization;

namespace Orc.Library.Messages.Client
{

    /// <summary>
    /// Move a trade in an atomic operation.
    /// </summary>
    [DataContract(Name = "trade_allocate", Namespace = "")]
    public class TradeAllocateMessage : ClientMessage
    {
        [DataMember(Name = "trade_tag", IsRequired = true, Order = 1)]
        public int? TradeTag { get; set; }

        [DataMember(Name = "allocateItems", IsRequired = true, Order = 2)]
        public AllocateItems AllocateItems { get; set; }

        public TradeAllocateMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.TRADE_ALLOCATE);
        }
    }

    /// <summary>
    /// Delete a specified trade.
    /// </summary>
    [DataContract(Name = "trade_delete", Namespace = "")]
    public class TradeDeleteMessage : ClientMessage
    {
        [DataMember(Name = "trade_tag", Order = 1)]
        public int? TradeTag { get; set; }

        [DataMember(Name = "unique_trade_id", Order = 2)]
        public string UniqueTradeId { get; set; }

        [DataMember(Name = "market", Order = 3)]
        public string Market { get; set; }

        [DataMember(Name = "update_portfolio", Order = 4)]
        public bool? UpdatePortfolio { get; set; }

        public TradeDeleteMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.TRADE_DELETE);
        }
    }

    /// <summary>
    /// Requests all information about a given trade
    /// </summary>
    [DataContract(Name = "trade_get", Namespace = "")]
    public class TradeGetMessage : ClientMessage
    {
        [DataMember(Name = "trade_tag", Order = 1)]
        public int? TradeTag { get; set; }

        [DataMember(Name = "unique_trade_id", Order = 2)]
        public string UniqueTradeId { get; set; }

        [DataMember(Name = "market", Order = 3)]
        public string Market { get; set; }

        public TradeGetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.TRADE_GET);
        }
    }


    /// <summary>
    /// Retrieve the trade history.
    /// </summary>
    [DataContract(Name = "trade_history_get", Namespace = "")]
    public class TradeHistoryGetMessage : ClientMessage
    {
        [DataMember(Name = "trade_tag", IsRequired = true)]
        public int? TradeTag { get; set; }

        public TradeHistoryGetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.TRADE_HISTORY_GET);
        }
    }

    /// <summary>
    /// Insert a new trade.
    /// </summary>
    [DataContract(Name = "trade_insert", Namespace = "")]
    public class TradeInsertMessage : ClientMessage
    {
        [DataMember(Name = "trade", IsRequired = true, Order = 1)]
        public Trade Trade { get; set; }

        [DataMember(Name = "update_portfolio", Order = 2)]
        public bool? UpdatePortfolio { get; set; }

        [DataMember(Name = "update_ticker", Order = 3)]
        public bool? UpdateTicker { get; set; }

        [DataMember(Name = "order_tag", Order = 4)]
        public int? OrderTag { get; set; }

        public TradeInsertMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.TRADE_INSERT);
        }
    }

    /// <summary>
    /// Modifies a trade.
    /// </summary>
    [DataContract(Name = "trade_modify", Namespace = "")]
    public class TradeModifyMessage : ClientMessage
    {
        [DataMember(Name = "trade_tag", IsRequired = true, Order = 1)]
        public int? TradeTag { get; set; }

        [DataMember(Name = "trade", IsRequired = true, Order = 2)]
        public Trade Trade { get; set; }

        [DataMember(Name = "update_portfolio", Order = 3)]
        public bool? UpdatePortfolio { get; set; }

        [DataMember(Name = "verified", Order = 4)]
        public bool? Verified { get; set; }

        public TradeModifyMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.TRADE_MODIFY);
        }
    }


    /// <summary>
    /// Get all trades for a given range of days (startdate and enddate can be the same day). By default, the date and time considered correspond to the Orc System(CDS) 
    /// creation date and time.Normally, this coincides with the date and time of the trade as assigned by the market, unless the Orc server system clock or the timezone 
    /// is different from that of the market. It is possible to query upon market time and date instead if preferred.
    /// </summary>
    [DataContract(Name = "trade_range_get", Namespace = "")]
    public class TradeRangeGetMessage : ClientMessage
    {

        [DataMember(Name = "enddate", Order = 1)]
        public DateTime? EndDate { get; set; }

        [DataMember(Name = "endtime", Order = 2)]
        public TimeSpan? EndTime { get; set; }

        [DataMember(Name = "startdate", Order = 3)]
        public DateTime? StartDate { get; set; }

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

        [DataMember(Name = "market_date_from", Order = 9)]
        public DateTime? MarketDateFrom { get; set; }

        [DataMember(Name = "market_date_to", Order = 10)]
        public DateTime? MarketDateTo { get; set; }

        [DataMember(Name = "market_time_from", Order = 11)]
        public TimeSpan? MarketTimeFrom { get; set; }

        [DataMember(Name = "market_time_to", Order = 12)]
        public TimeSpan? MarketTimeTo { get; set; }

        [DataMember(Name = "customer_id", Order = 13)]
        public string CustomerId { get; set; }

        [DataMember(Name = "deleted", Order = 14)]
        public bool? DeletedOnly { get; set; }

        [DataMember(Name = "instrument_id", Order = 15)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "items_per_message", Order = 16)]
        public int? ItemsPerMessage { get; set; }

        [DataMember(Name = "market", Order = 17)]
        public string Market { get; set; }

        [DataMember(Name = "originator", Order = 18)]
        public string Originator { get; set; }

        [DataMember(Name = "origin", Order = 19)]
        public Origin Origin { get; set; }

        [DataMember(Name = "owner", Order = 20)]
        public string Owner { get; set; }

        [DataMember(Name = "portfolio", Order = 21)]
        public string Portfolio { get; set; }

        [DataMember(Name = "underlying", Order = 22)]
        public string Underlying { get; set; }

        [DataMember(Name = "verified", Order = 23)]
        public bool? VerifiedOnly { get; set; }

        public TradeRangeGetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.TRADE_RANGE_GET);
        }
    }

    /// <summary>
    /// Verify a specified trade. This message can also act on money transactions.
    /// </summary>
    [DataContract(Name = "trade_verify", Namespace = "")]
    public class TradeVerifyMessage : ClientMessage
    {
        [DataMember(Name = "trade_tag", IsRequired = true, Order = 1)]
        public int? TradeTag { get; set; }

        [DataMember(Name = "verified", IsRequired = true, Order = 2)]
        public bool? Verify { get; set; }

        public TradeVerifyMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.TRADE_VERIFY);
        }
    }

    /// <summary>
    /// Calculate the trading power for a portfolio with the possibility to check if an order will go through.
    /// </summary>
    [DataContract(Name = "trading_power", Namespace = "")]
    public class TradingPowerMessage : ClientMessage
    {
        [DataMember(Name = "portfolio", IsRequired = true, Order = 1)]
        public bool? UpdatePortfolio { get; set; }

        [DataMember(Name = "instrument_id", Order = 2)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "buy_or_sell", IsRequired = true, Order = 3)]
        public BuySell? TradeSide { get; set; }

        [DataMember(Name = "order_volume", IsRequired = true, Order = 4)]
        public double? OrderVolume { get; set; }

        [DataMember(Name = "order_price", Order = 5)]
        public double? OrderPrice { get; set; }

        [DataMember(Name = "currency", Order = 6)]
        public string Currency { get; set; }

        public TradingPowerMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.TRADING_POWER);
        }
    }
}