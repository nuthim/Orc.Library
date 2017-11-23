using System.Runtime.Serialization;


namespace Orc.Library.Messages.Server
{
    public class ReplyInfo : MessageInfo
    {
        [DataMember(Name = "more_replies")]
        public bool? MoreReplies { get; set; }
    }
}