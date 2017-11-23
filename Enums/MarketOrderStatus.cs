using System.Runtime.Serialization;


namespace Orc.Library.Enums
{
    [DataContract(Name = "market_order_status", Namespace = "")]
    public enum MarketOrderStatus
    {
        [EnumMember(Value = "active")]
        Active,

        [EnumMember(Value = "inactive")]
        Inactive
    }
}
