using System;
using Orc.Library.Enums;
using System.Runtime.Serialization;

namespace Orc.Library.Messages.Client
{
    [DataContract(Name = "logout", Namespace = "")]
    public class LogoutMessage : ClientMessage
    {
        public LogoutMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.logout);
        }
    }
}