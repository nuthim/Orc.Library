using System;

using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Client
{
    /// <summary>
    /// Requests all information about a given trade
    /// </summary>
    public class InstrumentGetMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", Order = 1)]
        public InstrumentId Instrument { get; set; }

        [DataMember(Name = "with_orc_description", Order = 2)]
        public bool RequestOrcDescription { get; set; }

        public InstrumentGetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.instrument_get);
        }
    }
}