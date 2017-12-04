using System.Runtime.Serialization;
using Orc.Library.Dictionaries;


namespace Orc.Library.Messages.Server
{
    public class InstrumentReply : ServerMessage
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }
    }
}
