using Orc.Library.Enums;
using System.Runtime.Serialization;

namespace Orc.Library.Messages.Client
{
    [DataContract(Name = "ping", Namespace = "")]
    public class PingMessage : ClientMessage
    {
        public PingMessage() : base(MessageType.PING)
        {

        }
    }
}