using System;
using System.Runtime.Serialization;
using Orc.Library.Enums;

namespace Orc.Library.Messages
{
    [DataContract(Name = "reply_to", Namespace = "")]
    public class ReplyInfo : MessageInfo
    {
        [DataMember(Name = "more_replies")]
        public bool? MoreReplies { get; set; }

        public ReplyInfo(MessageType messageType) : base(null, messageType)
        {

        }

        public ReplyInfo(Guid? id, MessageType messageType) : base(id, messageType)
        {

        }
    }
}