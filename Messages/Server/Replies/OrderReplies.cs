using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Server.Replies
{
    [DataContract(Name = nameof(MessageType.ORDER_ACTIVATE), Namespace = "")]
    public class OrderActivateReply : ServerMessage
    {
        [DataMember(Name = "activate", Order = 1)]
        public Activate? Activate { get; set; }

        [DataMember(Name = "order_tag", Order = 2)]
        public int? OrcTag { get; set; }

        [DataMember(Name = "customer_reference", Order = 3)]
        public string CustomerReference { get; set; }
    }

    [DataContract(Name = nameof(MessageType.ORDER_DELETE), Namespace = "")]
    public class OrderDeleteReply : ServerMessage
    {
        [DataMember(Name = "order_tag", Order = 1)]
        public int? OrcTag { get; set; }

        [DataMember(Name = "customer_reference", Order = 2)]
        public string CustomerReference { get; set; }
    }

    [DataContract(Name = nameof(MessageType.ORDER_GET), Namespace = "")]
    public class OrderGetReply : ServerMessage
    {
        [DataMember(Name = "order_reply")]
        public OrderReply OrcReply { get; set; }
    }

    [DataContract(Name = nameof(MessageType.ORDER_HISTORY_GET), Namespace = "")]
    public class OrderHistoryGetReply : ServerMessage
    {
        [DataMember(Name = "history_entries")]
        public HistoryEntries HistoryEntries { get; set; }
    }

    [DataContract(Name = nameof(MessageType.ORDER_INSERT), Namespace = "")]
    public class OrderInsertReply : ServerMessage
    {
        [DataMember(Name = "activate", Order = 1)]
        public Activate? Activate { get; set; }

        [DataMember(Name = "order_tag", Order = 2)]
        public int? OrcTag { get; set; }

        [DataMember(Name = "comment", Order = 3)]
        public string Comment { get; set; }

        [DataMember(Name = "customer_reference", Order = 4)]
        public string CustomerReference { get; set; }
    }

    [DataContract(Name = nameof(MessageType.ORDER_MODIFY), Namespace = "")]
    public class OrderModifyReply : ServerMessage
    {
        [DataMember(Name = "order_tag", Order = 1)]
        public int? OrcTag { get; set; }

        [DataMember(Name = "customer_reference", Order = 2)]
        public string CustomerReference { get; set; }
    }

    [DataContract(Name = nameof(MessageType.ORDER_RANGE_GET), Namespace = "")]
    public class OrderRangeGetReply : ServerMessage
    {
        [DataMember(Name = "order_replies", Order = 1)]
        public OrderReplies OrderReplies { get; set; }

        /// <summary>
        /// This is contained in the first reply message and corresponds to the total number of orders to be downloaded.
        /// </summary>
        [DataMember(Name = "total_items_count", Order = 2)]
        public int? TotalItemsCount { get; set; }

        /// <summary>
        /// If ItemsPerMessage is set to 100, the first reply will start at 1 and second at 101 and so on
        /// </summary>
        [DataMember(Name = "start_item_number", Order = 3)]
        public int? StartItemNumber { get; set; }
    }
}