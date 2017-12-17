using System;
using Orc.Library.Enums;
using System.Runtime.Serialization;

namespace Orc.Library.Messages
{
    [DataContract(Name = "message_info", Namespace = "")]
    public class MessageInfo : IEquatable<MessageInfo>
    {
        [DataMember(Name = "message_type", IsRequired = true, Order = 1)]
        public MessageType MessageType { get; set; }

        [DataMember(Name = "private", Order = 2)]
        public Guid? Id { get; set; }

        public MessageInfo(MessageType messageType) : this(null, messageType)
        {
            
        }

        public MessageInfo(Guid? id, MessageType messageType)
        {
            Id = id;
            MessageType = messageType;
        }

        public bool Equals(MessageInfo other)
        {
            if (other == null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return MessageType == other.MessageType && Equals(Id, other.Id);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as MessageInfo);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}