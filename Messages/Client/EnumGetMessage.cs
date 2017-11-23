using System;
using Orc.Library.Enums;
using System.Runtime.Serialization;

namespace Orc.Library.Messages.Client
{
    /// <summary>
    /// Get all possible values for an enumerator.
    /// </summary>
    [DataContract(Name = "enum_get", Namespace = "")]
    public class EnumGetMessage : ClientMessage
    {
        [DataMember(Name = "enum", IsRequired = true)]
        public EnumType Type { get; set; }

        public EnumGetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.enum_get);
        }
    }
}