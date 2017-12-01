using System;
using System.Runtime.Serialization;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Client
{

    [DataContract(Name = "LOGIN", Namespace = "")]
    public class LoginMessage : ClientMessage
    {
        [DataMember(Name = "login_id", IsRequired = true, Order = 1)]
        public string UserName { get; set; }

        [DataMember(Name = "password", Order = 2)]
        public string Password { get; set; }

        [DataMember(Name = "allow_ping", Order = 3)]
        public bool? AllowPing { get; set; }

        [DataMember(Name = "ping_interval", Order = 4)]
        public int? PingInterval { get; set; }

        [DataMember(Name = "ping_timeout", Order = 5)]
        public int? PingTimeout { get; set; }

        public LoginMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.LOGIN);
        }
    }
}