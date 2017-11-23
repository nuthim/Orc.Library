using System;
using Orc.Library.Enums;
using System.Runtime.Serialization;

namespace Orc.Library.Messages
{
    public class MessageInfo
    {
        [DataMember(Name = "message_type", IsRequired = true)]
        public MessageType MessageType { get; set; }

        [DataMember(Name = "private", IsRequired = true)]
        public Guid Id { get; set; }

        public MessageInfo()
        {
            
        }

        public MessageInfo(Guid id, MessageType messageType)
        {
            Id = id;
            MessageType = messageType;
        }
    }
}