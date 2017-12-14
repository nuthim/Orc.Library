using System.Runtime.Serialization;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Server.Replies
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