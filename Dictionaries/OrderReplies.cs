using System;
using Orc.Library.Enums;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "order_replies", ItemName = "order_reply", Namespace = "")]
    public class OrderReplies : List<OrderReply>
    {

    }


    public class OrderReply
    {
        [DataMember(Name = "action")]
        public FeedAction? Action { get; set; }

        [DataMember(Name = "order")]
        public Order Order { get; set; }

        [DataMember(Name = "order_tag")]
        public int? OrderTag { get; set; }

        [DataMember(Name = "origin")]
        public Origin? Origin { get; set; }

        [DataMember(Name = "active")]
        public bool? Active { get; set; }

        [DataMember(Name = "date_changed")]
        public DateTime? DateChanged { get; set; }

        [DataMember(Name = "date_created")]
        public DateTime? DateCreated { get; set; }

        [DataMember(Name = "deleted")]
        public bool? Deleted { get; set; }

        [DataMember(Name = "exchange_order_id")]
        public string ExchangeOrderId { get; set; }

        [DataMember(Name = "flags")]
        public string Flags { get; set; }

        [DataMember(Name = "market_error")]
        public string MarketError { get; set; }

        [DataMember(Name = "market_order_status")]
        public MarketOrderStatus? MarketOrderStatus { get; set; }

        [DataMember(Name = "onmarket")]
        public bool? OnMarket { get; set; }

        [DataMember(Name = "originator")]
        public string Originator { get; set; }

        [DataMember(Name = "owner")]
        public string Owner { get; set; }

        [DataMember(Name = "status")]
        public OrderStatus? OrderStatus { get; set; }

        [DataMember(Name = "time_changed")]
        public TimeSpan? TimeChanged { get; set; }

        [DataMember(Name = "time_created")]
        public TimeSpan? TimeCreated { get; set; }

        [DataMember(Name = "volume_filled")]
        public double? VolumeFilled { get; set; }
    }
}
