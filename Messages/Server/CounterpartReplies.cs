using System.Runtime.Serialization;
using Orc.Library.Dictionaries;


namespace Orc.Library.Messages.Server
{

    [DataContract(Name = "COUNTERPART_ADD", Namespace = "")]
    public class CounterpartAddReply : ServerMessage
    {
        /// <summary>
        /// The name of the added counterpart.
        /// </summary>
        [DataMember(Name = "counterpart")]
        public string Counterpart { get; set; }

    }


    [DataContract(Name = "COUNTERPART_DOWNLOAD", Namespace = "")]
    public class CounterpartDownloadReply : ServerMessage
    {
        [DataMember(Name = "counterparts")]
        public Counterparts Counterparts { get; set; }
    }


    [DataContract(Name = "COUNTERPART_REMOVE", Namespace = "")]
    public class CounterpartRemoveReply : ServerMessage
    {
        /// <summary>
        /// The name of the removed counterpart.
        /// </summary>
        [DataMember(Name = "counterpart")]
        public string Counterpart { get; set; }
    }

}
