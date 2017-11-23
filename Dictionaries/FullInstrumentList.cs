using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "full_instrument_list", ItemName = "instrument", Namespace = "")]
    public class FullInstrumentList : List<Instrument>
    {

    }

    [DataContract(Name = "instrument", Namespace = "")]
    public class Instrument
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "parameters")]
        public Parameters Parameters { get; set; }

        [DataMember(Name = "orc_description")]
        public string OrcDescription { get; set; }

        [DataMember(Name = "tick_rule")]
        public string TickRule { get; set; }
    }
}