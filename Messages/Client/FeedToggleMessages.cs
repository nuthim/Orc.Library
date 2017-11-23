using System;
using System.Runtime.Serialization;
using Orc.Library.Enums;


namespace Orc.Library.Messages.Client
{
    public abstract class SubscriptionMessage : ClientMessage
    {
        [DataMember(Name = "toggle", IsRequired = true)]
        public bool? Enable { get; set; }
    }

    public class DividendFeedToggleMessage : SubscriptionMessage
    {
        [DataMember(Name = "market")]
        public string Market { get; set; }

        public DividendFeedToggleMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.dividend_feed_toggle);
        }
    }

    public class MoneySubscriptionMessage : SubscriptionMessage
    {
        public MoneySubscriptionMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.money_feed_toggle);
        }
    }

    public class NewsSubscriptionMessage : SubscriptionMessage
    {
        public NewsSubscriptionMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.news_feed_toggle);
        }
    }

    public class TradeSubscriptionMessage : SubscriptionMessage
    {
        [DataMember(Name = "market")]
        public string Market { get; set; }

        [DataMember(Name = "originator")]
        public string Originator { get; set; }

        [DataMember(Name = "portfolio")]
        public string Portfolio { get; set; }

        [DataMember(Name = "customer_id")]
        public string CustomerId { get; set; }

        [DataMember(Name = "origin")]
        public string Origin { get; set; }

        public TradeSubscriptionMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.trade_feed_toggle);
        }
    }

    public class UnderlyingSubscriptionMessage : SubscriptionMessage
    {
        public UnderlyingSubscriptionMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.underlying_feed_toggle);
        }
    }
}
