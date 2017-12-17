using System.Runtime.Serialization;
using Orc.Library.Enums;

namespace Orc.Library.Messages
{
    [DataContract(Namespace = "")]
    public abstract class ClientMessage
    {
        [DataMember(Name = "message_info", IsRequired = true, Order = 1)]
        public MessageInfo Info { get; set; }

        [DataMember(Name = "debug", Order = 2)]
        public bool? Debug { get; set; }

        [DataMember(Name = "log", Order = 3)]
        public string Log { get; set; }

        [DataMember(Name = "suppress_reply", Order = 4)]
        public SuppressReply? SuppressReply { get; set; }

        protected ClientMessage()
        {

        }

        protected ClientMessage(MessageType messageType)
        {
            Info = new MessageInfo(messageType);
        }

    }
}
