using System.Runtime.Serialization;
using Orc.Library.Dictionaries;


namespace Orc.Library.Messages.Server
{
    public class TradeFeed : ServerMessage
    {
        [DataMember(Name = "trade_reply")]
        public TradeReply TradeReply { get; set; }
    }


    public class TradeHistoryCollection : ServerMessage
    {
        [DataMember(Name = "history_entries")]
        public HistoryEntries List { get; set; }
    }
}