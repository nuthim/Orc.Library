using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Server.Replies
{
    [DataContract(Name = nameof(MessageType.PRICE_GET), Namespace = "")]
    public class PriceGetReply : ServerMessage
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }
    }
}
