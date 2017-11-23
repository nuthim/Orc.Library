using System.Runtime.Serialization;
using Orc.Library.Dictionaries;


namespace Orc.Library.Messages.Server
{
    public class TradeFeed : OrcMessage
    {
        [DataMember(Name = "trade_reply")]
        public TradeReply TradeReply { get; set; }
    }


    public class TradeHistoryCollection : OrcMessage
    {
        [DataMember(Name = "history_entries")]
        public HistoryEntries List { get; set; }
    }
}