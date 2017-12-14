using System.Runtime.Serialization;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Server
{
    [DataContract(Name = nameof(MessageType.PING), Namespace = "")]
    public class PingMessage : ServerMessage
    {

    }
}