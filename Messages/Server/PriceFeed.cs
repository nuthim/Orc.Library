﻿using System.Runtime.Serialization;
using Orc.Library.Dictionaries;


namespace Orc.Library.Messages.Server
{
    public class PriceGetReply : ServerMessage
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId Instrument { get; set; }
    }
}
