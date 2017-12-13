using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Server
{
    /// <summary>
    /// Get all possible values for an enumerator.
    /// </summary>
    [DataContract(Name = nameof(MessageType.ENUM_GET), Namespace = "")]
    public class EnumGetReply : ServerMessage
    {
        [DataMember(Name = "requested_enum")]
        public EnumType RequestedEnum { get; set; }

        [DataMember(Name = "enumerated_values")]
        public EnumeratedValues EnumeratedValues { get; set; }
    }

}
