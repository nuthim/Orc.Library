using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Client
{
    [DataContract(Name = nameof(MessageType.CURRENCY_CREATE), Namespace = "")]
    public class CurrencyCreateMessage : ClientMessage
    {
        /// <summary>
        /// A three letter currency identifier.
        /// </summary>
        [DataMember(Name = "currency", IsRequired = true)]
        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; }

        public CurrencyCreateMessage() : base(MessageType.CURRENCY_CREATE)
        {
            
        }
    }
}
