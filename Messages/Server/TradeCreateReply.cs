using System.Runtime.Serialization;


namespace Orc.Library.Messages.Server
{
    public class TradeCreateReply : ServerMessage
    {
        [DataMember(Name = "trade_tag")]
        public int TradeTag { get; set; }

        [DataMember(Name = "update_portfolio")]
        public bool? UpdatePortfolio { get; set; }
    }
}