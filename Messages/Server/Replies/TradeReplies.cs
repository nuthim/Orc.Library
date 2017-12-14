using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Server.Replies
{
    [DataContract(Name = nameof(MessageType.TRADE_ALLOCATE), Namespace = "")]
    public class TradeAllocateReply : ServerMessage
    {
        [DataMember(Name = "deleted_trade_tag", Order = 1)]
        public int? DeletedTradeTag { get; set; }

        [DataMember(Name = "inserted_trades", Order = 2)]
        public InsertedTrades InsertedTrades { get; set; }
    }


    [DataContract(Name = nameof(MessageType.TRADE_DELETE), Namespace = "")]
    public class TradeDeleteReply : ServerMessage
    {
        [DataMember(Name = "trade_tag", Order = 1)]
        public int? TradeTag { get; set; }

        [DataMember(Name = "update_portfolio", Order = 2)]
        public bool? UpdatePortfolio { get; set; }
    }

    [DataContract(Name = nameof(MessageType.TRADE_GET), Namespace = "")]
    public class TradeGetReply : ServerMessage
    {
        [DataMember(Name = "trade_reply")]
        public TradeReply TradeReply { get; set; }
    }

    [DataContract(Name = nameof(MessageType.TRADE_HISTORY_GET), Namespace = "")]
    public class TradeHistoryGetReply : ServerMessage
    {
        [DataMember(Name = "history_entries")]
        public HistoryEntries HistoryEntries { get; set; }
    }

    [DataContract(Name = nameof(MessageType.TRADE_INSERT), Namespace = "")]
    public class TradeInsertReply : ServerMessage
    {
        [DataMember(Name = "trade_tag", Order = 1)]
        public int? TradeTag { get; set; }

        [DataMember(Name = "update_portfolio", Order = 2)]
        public bool? UpdatePortfolio { get; set; }
    }

    [DataContract(Name = nameof(MessageType.TRADE_MODIFY), Namespace = "")]
    public class TradeModifyReply : ServerMessage
    {
        [DataMember(Name = "trade_tag", Order = 1)]
        public int? TradeTag { get; set; }

        [DataMember(Name = "update_portfolio", Order = 2)]
        public bool? UpdatePortfolio { get; set; }
    }

    [DataContract(Name = nameof(MessageType.TRADE_RANGE_GET), Namespace = "")]
    public class TradeRangeGetReply : ServerMessage
    {
        [DataMember(Name = "trade_replies", Order = 1)]
        public TradeReplies TradeReplies { get; set; }

        /// <summary>
        /// This is contained in the first reply message and corresponds to the total number of trades to be downloaded.
        /// </summary>
        [DataMember(Name = "total_items_count", Order = 2)]
        public int? TotalItemsCount { get; set; }

        /// <summary>
        /// If ItemsPerMessage is set to 100, the first reply will start at 1 and second at 101 and so on
        /// </summary>
        [DataMember(Name = "start_item_number", Order = 3)]
        public int? StartItemNumber { get; set; }
    }

    [DataContract(Name = nameof(MessageType.TRADE_VERIFY), Namespace = "")]
    public class TradeVerifyReply : ServerMessage
    {
        [DataMember(Name = "trade_tag", Order = 1)]
        public int? TradeTag { get; set; }

        [DataMember(Name = "verified", Order = 2)]
        public bool? Verified { get; set; }
    }


    [DataContract(Name = nameof(MessageType.TRADING_POWER), Namespace = "")]
    public class TradingPowerReply : ServerMessage
    {
        [DataMember(Name = "portfolio", Order = 1)]
        public string Portfolio { get; set; }

        [DataMember(Name = "instrument_id", Order = 2)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "buy_or_sell", Order = 3)]
        public BuySell? BuyOrSell { get; set; }

        [DataMember(Name = "order_volume", Order = 4)]
        public double? OrderVolume { get; set; }

        [DataMember(Name = "order_price", Order = 5)]
        public double? OrderPrice { get; set; }

        [DataMember(Name = "trading_power", Order = 6)]
        public double? TradingPower { get; set; }

        [DataMember(Name = "status", Order = 7)]
        public TradingPowerStatus? Status { get; set; }

        [DataMember(Name = "currency", Order = 8)]
        public string Currency { get; set; }
    }
}