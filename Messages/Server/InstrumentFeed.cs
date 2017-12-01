using System.Runtime.Serialization;
using Orc.Library.Dictionaries;


namespace Orc.Library.Messages.Server
{

    public class InstrumentFeed : ServerMessage
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId Instrument { get; set; }

        [DataMember(Name = "instrument_attributes")]
        public InstrumentAttributes Attributes { get; set; }

        [DataMember(Name = "parameters")]
        public Parameters Parameters { get; set; }

        [DataMember(Name = "orc_description")]
        public string OrcDescription { get; set; }

        [DataMember(Name = "tick_rule")]
        public string TickRule { get; set; }
    }
}