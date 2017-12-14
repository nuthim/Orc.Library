using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Server.Replies
{

    [DataContract(Name = nameof(MessageType.COUNTERPART_ADD), Namespace = "")]
    public class CounterpartAddReply : ServerMessage
    {
        /// <summary>
        /// The name of the added counterpart.
        /// </summary>
        [DataMember(Name = "counterpart")]
        public string Counterpart { get; set; }

    }


    [DataContract(Name = nameof(MessageType.COUNTERPART_DOWNLOAD), Namespace = "")]
    public class CounterpartDownloadReply : ServerMessage
    {
        [DataMember(Name = "counterparts")]
        public Counterparts Counterparts { get; set; }
    }


    [DataContract(Name = nameof(MessageType.COUNTERPART_REMOVE), Namespace = "")]
    public class CounterpartRemoveReply : ServerMessage
    {
        /// <summary>
        /// The name of the removed counterpart.
        /// </summary>
        [DataMember(Name = "counterpart")]
        public string Counterpart { get; set; }
    }

}
