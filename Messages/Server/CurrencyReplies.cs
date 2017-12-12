using System.Runtime.Serialization;


namespace Orc.Library.Messages.Server
{
    [DataContract(Name = "CURRENCY_CREATE", Namespace = "")]
    public class CurrencyCreateReply : ServerMessage
    {
        [DataMember(Name = "currency")]
        public string Currency { get; set; }
    }
}
