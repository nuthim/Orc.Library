using System.Runtime.Serialization;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Client
{
    /// <summary>
    /// The login message is the first message to be sent from the client to the Orc Protocol server.
    /// </summary>
    [DataContract(Name = nameof(MessageType.LOGIN), Namespace = "")]
    public class LoginMessage : ClientMessage
    {
        /// <summary>
        /// User identification for the Orc Protocol
        /// </summary>
        [DataMember(Name = "login_id", IsRequired = true, Order = 1)]
        public string LoginId { get; set; }

        /// <summary>
        /// A password to verify the user. Default: empty string.
        /// </summary>
        [DataMember(Name = "password", Order = 2)]
        public string Password { get; set; }

        /// <summary>
        /// Default: "false". If "true" the customer want to use the ping-protocol.
        /// </summary>
        [DataMember(Name = "allow_ping", Order = 3)]
        public bool? AllowPing { get; set; }

        /// <summary>
        /// Default value: 30 secs
        /// </summary>
        [DataMember(Name = "ping_interval", Order = 4)]
        public int? PingInterval { get; set; }

        /// <summary>
        /// Default value: 20.
        /// </summary>
        [DataMember(Name = "ping_timeout", Order = 5)]
        public int? PingTimeout { get; set; }

        public LoginMessage() : base(MessageType.LOGIN)
        {

        }
    }
}