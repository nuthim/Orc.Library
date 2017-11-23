using System.Runtime.Serialization;

namespace Orc.Library.Enums
{
    [DataContract(Name = "buy_or_sell", Namespace = "")]
    public enum BuySell
    {
        [EnumMember(Value = "buy")]
        Buy,

        [EnumMember(Value = "sell")]
        Sell,

        [EnumMember(Value = "both")]
        Both
    }
}