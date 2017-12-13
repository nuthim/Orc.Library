using Orc.Library.Enums;
using System.Runtime.Serialization;
using Orc.Library.Dictionaries;

namespace Orc.Library.Messages.Client
{
    /// <summary>
    /// Use this in order to receive a snapshot of market data. 
    /// </summary>
    [DataContract(Name = nameof(MessageType.PRICE_GET), Namespace = "")]
    public class PriceGetMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true)]
        public InstrumentId InstrumentId { get; set; }

        public PriceGetMessage() : base(MessageType.PRICE_GET)
        {

        }
    }
}