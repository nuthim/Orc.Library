using System;
using System.Runtime.Serialization;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Client
{
    [DataContract(Name = "currency_create", Namespace = "")]
    public class CurrencyCreateMessage : ClientMessage
    {
        [DataMember(Name = "currency", IsRequired = true)]
        public string Currency { get; set; }

        public CurrencyCreateMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.currency_create);
        }
    }
}
