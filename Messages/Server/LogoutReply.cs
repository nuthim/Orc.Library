using Orc.Library.Enums;
using System.Runtime.Serialization;

namespace Orc.Library.Messages.Server
{
    /// <summary>
    /// The logout message is used to end a session with the Orc Protocol server.
    /// </summary>
    [DataContract(Name = nameof(MessageType.LOGOUT), Namespace = "")]
    public class LogoutMessage : ClientMessage
    {
        [DataMember(Name = "login_id")]
        public string LoginId { get; set; }
    }
}