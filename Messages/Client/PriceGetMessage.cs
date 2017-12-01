using System;
using Orc.Library.Enums;
using System.Runtime.Serialization;
using Orc.Library.Dictionaries;

namespace Orc.Library.Messages.Client
{
    [DataContract(Name = "price_get", Namespace = "")]
    public class PriceGetMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId Instrument { get; set; }

        public PriceGetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.PRICE_GET);
        }
    }
}