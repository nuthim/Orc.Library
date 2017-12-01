using System.Runtime.Serialization;

namespace Orc.Library.Enums
{
    [DataContract(Namespace = "")]
    public enum EnumType
    {
        [EnumMember(Value = "market")]
        Market,

        [EnumMember(Value = "model")]
        Model,

        [EnumMember(Value = "order_validate")]
        OrderValidate,

        [EnumMember(Value = "kind")]
        Kind,

        [EnumMember(Value = "money_kind")]
        MoneyKind,

        [EnumMember(Value = "dividend_kind")]
        DividendKind,

        /// <summary>
        /// Corresponds to the Orc Trader name of the market.
        /// </summary>
        [EnumMember(Value = "short_market_name")]
        ShortMarketName
    }

}