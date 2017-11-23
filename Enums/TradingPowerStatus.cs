using System.Runtime.Serialization;


namespace Orc.Library.Enums
{
    [DataContract(Name = "tradingpower_status", Namespace = "")]
    public enum TradingPowerStatus
    {
        [EnumMember]
        OK,

        [EnumMember(Value = "Low trading power")]
        LowTradingPower,

        [EnumMember(Value = "Short sell not allowed")]
        ShortSellNotAllowed,

        [EnumMember(Value = "Unknown trading power")]
        UnknownTradingPower,

        [EnumMember(Value = "Order not allowed")]
        OrderNotAllowed,

        [EnumMember(Value = "Contract not allowed")]
        ContractNotAllowed
    }

}
