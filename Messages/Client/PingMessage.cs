using Orc.Library.Enums;
using System.Runtime.Serialization;

namespace Orc.Library.Messages.Client
{
    [DataContract(Name = nameof(MessageType.PING), Namespace = "")]
    public class PingMessage : ClientMessage
    {
        public PingMessage() : base(MessageType.PING)
        {

        }
    }
}