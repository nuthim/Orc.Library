using System.Runtime.Serialization;


namespace Orc.Library.Messages.Server
{
    public class SubscriptionReply : OrcMessage
    {
        [DataMember(Name = "toggle", IsRequired = true)]
        public bool Subscribed { get; set; }
    }
}