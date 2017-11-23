using System;
using System.Runtime.Serialization;
using Orc.Library.Enums;


namespace Orc.Library.Messages.Client
{

    [DataContract(Name = "counterpart_add", Namespace = "")]
    public class CounterpartAddMessage : ClientMessage
    {
        [DataMember(Name = "counterpart", IsRequired = true)]
        public string Counterpart { get; set; }

        public CounterpartAddMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.COUNTERPART_ADD);
        }
    }


    [DataContract(Name = "counterpart_download", Namespace = "")]
    public class CounterpartDownloadMessage : ClientMessage
    {
        public CounterpartDownloadMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.COUNTERPART_DOWNLOAD);
        }
    }


    [DataContract(Name = "counterpart_remove", Namespace = "")]
    public class CounterpartRemoveMessage : ClientMessage
    {
        [DataMember(Name = "counterpart", IsRequired = true)]
        public string Counterpart { get; set; }

        public CounterpartRemoveMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.COUNTERPART_REMOVE);
        }
    }

}
