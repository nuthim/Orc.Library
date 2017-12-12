using System;
using System.Runtime.Serialization;


namespace Orc.Library.Messages
{
    [DataContract(Namespace = "")]
    public class ServerMessage
    {
        public Guid Id => ReplyInfo?.Id ?? MessageInfo?.Id ?? Guid.Empty;

        [DataMember(Name = "reply_to")]
        public ReplyInfo ReplyInfo { get; set; }

        [DataMember(Name = "message_info")]
        public MessageInfo MessageInfo { get; set; }

        [DataMember(Name = "error")]
        public int ErrorCode { get; set; }

        [DataMember(Name = "error_description")]
        public string ErrorDescription { get; set; }
    }
}
