using System;
using Orc.Library.Enums;
using System.Runtime.Serialization;

namespace Orc.Library.Messages.Client
{
    [DataContract(Name = "ping", Namespace = "")]
    public class PingMessage : ClientMessage
    {
        public PingMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.PING);
        }
    }
}