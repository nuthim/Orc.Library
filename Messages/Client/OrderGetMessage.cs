
using Orc.Library.Enums;
using System;
using System.Runtime.Serialization;

namespace Orc.Library.Messages.Client
{
    /// <summary>
    /// Requests all information about a given order
    /// </summary>
    public class OrderGetMessage : ClientMessage
    {
        [DataMember(Name = "order_tag")]
        public int OrcTag { get; set; }

        public OrderGetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.order_get);
        }
    }
}