using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;


namespace Orc.Library.Messages.Server
{
    public class InstrumentReply : OrcMessage
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId Instrument { get; set; }
    }
}
