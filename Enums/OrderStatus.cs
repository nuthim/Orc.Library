using System.Runtime.Serialization;


namespace Orc.Library.Enums
{

    [DataContract(Name = "order_status", Namespace = "")]
    public enum OrderStatus
    {
        [EnumMember]
        Ok,

        [EnumMember(Value = "Market Error")]
        MarketError,

        [EnumMember(Value = "No Market Access")]
        NoMarketAccess,

        /// <summary>
        /// Order is sent to the exchange but not yet accepted and/or amended via delete or insert.
        /// </summary>
        [EnumMember(Value = "Internal Add")]
        InternalAdd,

        [EnumMember(Value = "Internal Delete")]
        InternalDelete,

        [EnumMember(Value = "Internal Error")]
        InternalError,

        /// <summary>
        /// For one of the following:
        /// a) When overtrading a parent order (the accumulated volume for the child orders are larger then the parent order).
        /// b) When the market link does not support combo orders.
        /// c) When market orders are not allowed.
        /// </summary>
        [EnumMember(Value = "Safety Limits Exceeded")]
        SafetyLimitsExceeded,

        /// <summary>
        /// This is the default order status for erroneous orders
        /// </summary>
        [EnumMember(Value = "Order Validation Failed")]
        OrderValidationFailed,

        /// <summary>
        /// This is set when the requested combinations of price/volume conditions and other order properties are not supported by the target market
        /// </summary>
        [EnumMember(Value = "Not Supported")]
        NotSupported

    }
}