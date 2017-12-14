using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Orc.Library.Enums;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "trade_replies", ItemName = "trade_reply", Namespace = "")]
    public class TradeReplies : List<TradeReply>
    {

    }

    [DataContract(Name = "trade_reply", Namespace = "")]
    public class TradeReply
    {
        [DataMember(Name = "action")]
        public FeedAction? Action { get; set; }

        [DataMember(Name = "counterpart_trade")]
        public bool CounterpartTrade { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "deleted")]
        public bool Deleted { get; set; }

        [DataMember(Name = "trade")]
        public Trade Trade { get; set; }

        [DataMember(Name = "trade_tag")]
        public int TradeTag { get; set; }

        [DataMember(Name = "verified")]
        public bool Verified { get; set; }

        [DataMember(Name = "basket_order_tag")]
        public int? BasketOrderTag { get; set; }

        [DataMember(Name = "date_changed")]
        public DateTime? DateChanged { get; set; }

        [DataMember(Name = "date_created")]
        public DateTime? DateCreated { get; set; }

        [DataMember(Name = "order_tag")]
        public int? OrderTag { get; set; }

        [DataMember(Name = "patent_order_tag")]
        public int? ParentOrderTag { get; set; }

        [DataMember(Name = "time_changed")]
        public TimeSpan? TimeChanged { get; set; }

        [DataMember(Name = "time_created")]
        public TimeSpan? TimeCreated { get; set; }

    }
}
