using Orc.Library.Enums;
using System.Runtime.Serialization;

namespace Orc.Library.Messages.Client
{
    /// <summary>
    /// The logout message is used to end a session with the Orc Protocol server.
    /// </summary>
    [DataContract(Name = "logout", Namespace = "")]
    public class LogoutMessage : ClientMessage
    {
        public LogoutMessage() : base(MessageType.LOGOUT)
        {

        }
    }
}