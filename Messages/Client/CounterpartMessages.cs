using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Orc.Library.Enums;


namespace Orc.Library.Messages.Client
{

    [DataContract(Name = nameof(MessageType.COUNTERPART_ADD), Namespace = "")]
    public class CounterpartAddMessage : ClientMessage
    {
        /// <summary>
        /// The name of the counterpart to add
        /// </summary>
        [DataMember(Name = "counterpart", IsRequired = true)]
        [StringLength(32)]
        public string Counterpart { get; set; }

        public CounterpartAddMessage() : base(MessageType.COUNTERPART_ADD)
        {

        }
    }


    [DataContract(Name = nameof(MessageType.COUNTERPART_DOWNLOAD), Namespace = "")]
    public class CounterpartDownloadMessage : ClientMessage
    {
        public CounterpartDownloadMessage() : base(MessageType.COUNTERPART_DOWNLOAD)
        {

        }
    }


    [DataContract(Name = nameof(MessageType.COUNTERPART_REMOVE), Namespace = "")]
    public class CounterpartRemoveMessage : ClientMessage
    {
        /// <summary>
        /// The name of the counterpart to be removed
        /// </summary>
        [DataMember(Name = "counterpart", IsRequired = true)]
        [StringLength(32)]
        public string Counterpart { get; set; }

        public CounterpartRemoveMessage() : base(MessageType.COUNTERPART_REMOVE)
        {

        }
    }

}
