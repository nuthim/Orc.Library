using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Server.Replies
{
    [DataContract(Name = nameof(MessageType.PRICEFEED_BROADCAST), Namespace = "")]
    public class PriceFeedBroadcastReply : ServerMessage
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }
    }
}