using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Client
{

    /// <summary>
    /// Requests all information about a given order.
    /// <para>The Internal state of an order can via Orc Protocol only be reached when the order is inserted.
    /// Thus message can only be used to toggle between the Inactive and Exchange states.
    /// </para>
    /// </summary>
    [DataContract(Name = "ORDER_ACTIVATE", Namespace = "")]
    public class OrderActivateMessage : ClientMessage
    {
        /// <summary>
        /// Unique order identifier. Only defined for trades done from the Orc client.
        /// </summary>
        [DataMember(Name = "order_tag", IsRequired = true, Order = 1)]
        public int? OrcTag { get; set; }

        [DataMember(Name = "activate", IsRequired = true, Order = 2)]
        public Activate? Activate { get; set; }

        /// <summary>
        /// If set to "true", this message will be handled asynchronously. Default is "false".
        /// </summary>
        [DataMember(Name = "asynch", Order = 3)]
        public bool? asynch { get; set; }

        public OrderActivateMessage() : base(MessageType.ORDER_ACTIVATE)
        {

        }
    }

    /// <summary>
    /// Send a message to delete an order in the Orc System.
    /// </summary>
    [DataContract(Name = "ORDER_DELETE", Namespace = "")]
    public class OrderDeleteMessage : ClientMessage
    {
        /// <summary>
        /// Unique order identifier. Only defined for trades done from the Orc client.
        /// </summary>
        [DataMember(Name = "order_tag", IsRequired = true, Order = 1)]
        public int? OrcTag { get; set; }

        [DataMember(Name = "auto_delete", Order = 2)]
        [Obsolete("Do not use")]
        public bool? AutoDelete { get; set; }

        [DataMember(Name = "additional_data", Order = 3)]
        public AdditionalData AdditionalData { get; set; }

        public OrderDeleteMessage() : base(MessageType.ORDER_DELETE)
        {
            
        }
    }

    /// <summary>
    /// Requests all information about a given order
    /// </summary>
    [DataContract(Name = "ORDER_GET", Namespace = "")]
    public class OrderGetMessage : ClientMessage
    {
        /// <summary>
        /// Unique order identifier. Only defined for trades done from the Orc client.
        /// </summary>
        [DataMember(Name = "order_tag", IsRequired = true)]
        public int? OrcTag { get; set; }

        public OrderGetMessage() : base(MessageType.ORDER_GET)
        {

        }
    }

    /// <summary>
    /// Retrieve the order history.
    /// </summary>
    [DataContract(Name = "ORDER_HISTORY_GET", Namespace = "")]
    public class OrderHistoryGetMessage : ClientMessage
    {
        /// <summary>
        /// Unique order identifier. Only defined for trades done from the Orc client.
        /// </summary>
        [DataMember(Name = "order_tag", IsRequired = true)]
        public int? OrcTag { get; set; }

        public OrderHistoryGetMessage() : base(MessageType.ORDER_HISTORY_GET)
        {

        }
    }


    /// <summary>
    /// Send an order into the Orc system.
    /// <para>The ORDER_FEED and ORDER_RANGE_GET messages will inform you whether the order was rejected or accepted by the 
    /// market place.This information is provided in the error key. Note that a successful insertion only means that the order was
    /// successfully inserted into the Orc client.
    /// </para>
    /// </summary>
    [DataContract(Name = "ORDER_INSERT", Namespace = "")]
    public class OrderInsertMessage : ClientMessage
    {
        [DataMember(Name = "activate", Order = 1)]
        public Activate? Activate { get; set; }

        [DataMember(Name = "order", IsRequired = true, Order = 2)]
        public Order Order { get; set; }

        /// <summary>
        /// If set to "true", this message will be handled asynchronously. Default is "false". 
        /// <para>Note about synchronous/asynchronous mode for exchange orders :
        /// Synchronous: status ok(error 0) means that the order was successfully activated.
        /// Asynchronous: status ok(error 0) means that the order was successfully sent to the Orc system.
        /// </para>
        /// </summary>
        [DataMember(Name = "asynch", Order = 3)]
        public bool? asynch { get; set; }

        /// <summary>
        /// Additional market data for cross orders. Note that for cross orders, the key additional_data 
        /// will be ignored and you need to specify buy_additional_data and sell_additional_data respectively. 
        /// The OP does not set any default additional data keys for cross orders (e.g.TI/TY).
        /// </summary>
        [DataMember(Name = "buy_additional_data", Order = 4)]
        public AdditionalData BuyAdditionalData { get; set; }

        /// <summary>
        /// Used for cross orders
        /// </summary>
        [DataMember(Name = "buy_portfolio", Order = 5)]
        [StringLength(64)]
        public string BuyPortfolio { get; set; }

        /// <summary>
        /// Additional market data for cross orders. Note that for cross orders, the key additional_data 
        /// will be ignored and you need to specify buy_additional_data and sell_additional_data respectively. 
        /// The OP does not set any default additional data keys for cross orders (e.g.TI/TY).
        /// </summary>
        [DataMember(Name = "sell_additional_data", Order = 6)]
        public AdditionalData SellAdditionalData { get; set; }

        /// <summary>
        /// Used for cross orders
        /// </summary>
        [DataMember(Name = "sell_portfolio", Order = 7)]
        [StringLength(64)]
        public string SellPortfolio { get; set; }


        public OrderInsertMessage() : base(MessageType.ORDER_INSERT)
        {

        }
    }

    /// <summary>
    /// Modify an order in the Orc system. 
    /// <para>If the reply is OK, this means that the modify has not been rejected by the Orc system. In order to know that the market has not rejected 
    /// the order, you need to subscribe to the ORDER_FEED as well.
    /// </para>
    /// </summary>
    [DataContract(Name = "ORDER_MODIFY", Namespace = "")]
    public class OrderModifyMessage : ClientMessage
    {
        [DataMember(Name = "order", IsRequired = true, Order = 1)]
        public Order Order { get; set; }

        /// <summary>
        /// Unique order identifier. Only defined for trades done from the Orc client.
        /// </summary>
        [DataMember(Name = "order_tag", IsRequired = true, Order = 2)]
        public int? OrcTag { get; set; }

        public OrderModifyMessage() : base(MessageType.ORDER_MODIFY)
        {

        }
    }

    /// <summary>
    /// This message retrieves all orders that matches the specified filter criterion.
    /// <para>Date and time of the trade are assigned by the market and coincide with the Orc System creation time unless the Orc server system clock 
    /// or the timezone is different from the market time or timezone. The filter keys can be combined in any way to limit the size of the reply of 
    /// this message. Note that filters are combined with logic AND.
    /// </para>
    /// </summary>
    [DataContract(Name = "ORDER_RANGE_GET", Namespace = "")]
    public class OrderRangeGetMessage : ClientMessage
    {
        /// <summary>
        /// Last order date. The date refers to the creation date of the order. 
        /// Default is today's date, if date_change_to is not specified. If date_change_to is specified, enddate will default to that value.
        /// </summary>
        [DataMember(Name = "enddate", Order = 1)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Default is 23:59:59. The time refers to the creation time of the transaction. The end time for the "enddate"
        /// </summary>
        [DataMember(Name = "endtime", Order = 2)]
        public TimeSpan? EndTime { get; set; }

        /// <summary>
        /// The first day to fetch orders from. The date refers to the creation date of the order. 
        /// Default is today's date, if date_change_from is not specified. If date_change_from is specified, startdate will default to that value.
        /// </summary>
        [DataMember(Name = "startdate", Order = 3)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Default is 00:00:00. The time refers to the creation time of the transaction. The start time for the "startdate".
        /// </summary>
        [DataMember(Name = "starttime", Order = 4)]
        public TimeSpan? StartTime { get; set; }

        [DataMember(Name = "date_changed_from", Order = 5)]
        public DateTime? DateChangedFrom { get; set; }

        [DataMember(Name = "date_changed_to", Order = 6)]
        public DateTime? DateChangedTo { get; set; }

        [DataMember(Name = "time_changed_from", Order = 7)]
        public TimeSpan? TimeChangedFrom { get; set; }

        [DataMember(Name = "time_changed_to", Order = 8)]
        public TimeSpan? TimeChangedTo { get; set; }

        /// <summary>
        /// If set to false, no active orders will be retrieved. If set to true, only active orders will be retrieved. 
        /// If not set, active and inactive orders will be retrieved.
        /// </summary>
        [DataMember(Name = "active", Order = 9)]
        public bool? Active { get; set; }

        /// <summary>
        /// Specifies to which customer the order belongs.
        /// </summary>
        [DataMember(Name = "customer_id", Order = 10)]
        [StringLength(64)]
        public string CustomerId { get; set; }

        /// <summary>
        /// If set to false, no deleted orders will be retrieved. If set to true, only deleted order will be retrieved. 
        /// If not set, deleted and not deleted orders will be retrieved.
        /// </summary>
        [DataMember(Name = "deleted", Order = 11)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Set this key in order to receive replies in several messages. Default behaviour is that the Orc Protocol sends all replies 
        /// in one message. The recommended value for this key is 1000. If the reply is split up, this will also be indicated by the boolean 
        /// flag more_replies in the reply_to dictionary.
        /// </summary>
        [DataMember(Name = "items_per_message", Order = 12)]
        public int? ItemsPerMessage { get; set; }

        [DataMember(Name = "market", Order = 13)]
        public string Market { get; set; }

        /// <summary>
        /// If set to false, no onmarket orders will be retrieved. If set to true, only onmarket orders will be retrieved.
        /// If not set, onmarket and offmarket orders will be retrieved.
        /// </summary>
        [DataMember(Name = "onmarket", Order = 14)]
        public bool? OnMarket { get; set; }

        /// <summary>
        /// Default is all users.
        /// </summary>
        [DataMember(Name = "originator", Order = 15)]
        [StringLength(64)]
        public string Originator { get; set; }

        [DataMember(Name = "origin", Order = 16)]
        public Origin? Origin { get; set; }

        /// <summary>
        /// When specified, only order for that owner will be received.
        /// </summary>
        [DataMember(Name = "owner", Order = 17)]
        public string Owner { get; set; }

        /// <summary>
        /// Get orders for the given portfolio.
        /// </summary>
        [DataMember(Name = "portfolio", Order = 18)]
        [StringLength(64)]
        public string Portfolio { get; set; }

        public OrderRangeGetMessage() : base(MessageType.ORDER_RANGE_GET)
        {

        }
    }
}