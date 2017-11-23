using System;
using System.Runtime.Serialization;
using Orc.Library.Enums;


namespace Orc.Library.Dictionaries
{
    [DataContract(Name = "order", Namespace = "")]
    public class Order
    {
        [DataMember(Name = "buy_or_sell")]
        public BuySell? TradeSide { get; set; }

        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "volume")]
        public double? Volume { get; set; }

        [DataMember(Name = "additional_data")]
        public AdditionalData AdditionalData { get; set; }

        [DataMember(Name = "basket_order_tag")]
        public int? BasketOrderTag { get; set; }

        [DataMember(Name = "comment")]
        public string Comment { get; set; }

        [DataMember(Name = "commission")]
        public double? Commission { get; set; }

        /// <summary>
        /// Set this to true for monitor orders. Default is false.
        /// </summary>
        [DataMember(Name = "conditional")]
        public bool? Conditional { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "customer_id")]
        public string CustomerId { get; set; }

        [DataMember(Name = "customer_reference")]
        public string CustomerReference { get; set; }

        [DataMember(Name = "fee")]
        public double? Fee { get; set; }

        [DataMember(Name = "market")]
        public string Market { get; set; }

        [DataMember(Name = "mic")]
        public string Mic { get; set; }

        [DataMember(Name = "monitor_order_conditions")]
        public MonitorOrderConditions MonitorConditions { get; set; }

        [DataMember(Name = "open_volume")]
        public double? OpenVolume { get; set; }

        [DataMember(Name = "order_execution_style")]
        public OrderExecutionStyle? ExecutionStyle { get; set; }

        [DataMember(Name = "order_kind")]
        public OrderKind? OrderKind { get; set; }

        [DataMember(Name = "order_request")]
        public OrderRequest? OrderRequest { get; set; }

        [DataMember(Name = "parent_order_tag")]
        public int? ParentOrderTag { get; set; }

        [DataMember(Name = "portfolio")]
        public string Portfolio { get; set; }

        [DataMember(Name = "price")]
        public double? Price { get; set; }

        [DataMember(Name = "price_condition")]
        public PriceCondition? PriceCondition { get; set; }

        [DataMember(Name = "priority")]
        public int? Priority { get; set; }

        [DataMember(Name = "pull_monitor_order")]
        public bool? PullMonitorOrder { get; set; }

        [DataMember(Name = "monitor_order_validity")]
        public string MonitorOrderValidity { get; set; }

        [DataMember(Name = "settlement_date")]
        public DateTime? SettlementDate { get; set; }

        [DataMember(Name = "submarket")]
        public string Submarket { get; set; }

        /// <summary>
        /// Only valid for monitor orders. Set this key to true if one or more conditions should be true before the order is activated. 
        /// If set to false, all conditions need to be true before the order is activated.
        /// </summary>
        [DataMember(Name = "use_monitor_order_condition_or")]
        public bool? OrCondition { get; set; }

        [DataMember(Name = "validity")]
        public Validity? Validity { get; set; }

        [DataMember(Name = "valid_date")]
        public DateTime? ValidDate { get; set; }

        [DataMember(Name = "valid_time")]
        public TimeSpan? ValidTime { get; set; }

        [DataMember(Name = "volume_condition")]
        public VolumeCondition? VolumeCondition { get; set; }

        [DataMember(Name = "vwap_execution_type")]
        public VwapExecutionType? VwapExecutionType { get; set; }

        [DataMember(Name = "vwap_start_date")]
        public DateTime? VwapStartDate { get; set; }

        [DataMember(Name = "vwap_start_time")]
        public TimeSpan? VwapStartTime { get; set; }

        [DataMember(Name = "vwap_stop_date")]
        public DateTime? VwapStopDate { get; set; }

        [DataMember(Name = "vwap_stop_time")]
        public TimeSpan? VwapStopTime { get; set; }

        [DataMember(Name = "vwap_volume")]
        public double? vwap_volume { get; set; }

        [DataMember(Name = "ytm")]
        public double? Ytm { get; set; }
    }
}
