using Orc.Library.Enums;
using System.Runtime.Serialization;

namespace Orc.Library.Messages.Client
{
    /// <summary>
    /// Get all possible values for an enumerator.
    /// </summary>
    [DataContract(Name = "ENUM_GET", Namespace = "")]
    public class EnumGetMessage : ClientMessage
    {
        [DataMember(Name = "enum", IsRequired = true)]
        public EnumType Type { get; set; }

        public EnumGetMessage() : base(MessageType.ENUM_GET)
        {

        }
    }
}