using System.Runtime.Serialization;
using Orc.Library.Enums;


namespace Orc.Library.Messages.Server
{
    [DataContract(Name = nameof(MessageType.CURRENCY_CREATE), Namespace = "")]
    public class CurrencyCreateReply : ServerMessage
    {
        [DataMember(Name = "currency")]
        public string Currency { get; set; }
    }
}
