using System.Runtime.Serialization;


namespace Orc.Library.Enums
{
    /// <summary>
    /// This corresponds to the Orc parameter "volatility day count".
    /// </summary>
    [DataContract(Name = "volatility_day_convention", Namespace = "")]
    public enum VolatilityDayConvention
    {
        [EnumMember]
        Actual,

        [EnumMember(Value = "Trading days")]
        TradingDays,

        [EnumMember(Value = "Trading days/245")]
        TradingDays245,

        [EnumMember(Value = "Trading days/246")]
        TradingDays246,


        [EnumMember(Value = "Trading days/247")]
        TradingDays247,


        [EnumMember(Value = "Trading days/248")]
        TradingDays248,


        [EnumMember(Value = "Trading days/249")]
        TradingDays249,


        [EnumMember(Value = "Trading days/250")]
        TradingDays250,


        [EnumMember(Value = "Trading days/251")]
        TradingDays251,


        [EnumMember(Value = "Trading days/252")]
        TradingDays252,


        [EnumMember(Value = "Trading days/253")]
        TradingDays253,


        [EnumMember(Value = "Trading days/254")]
        TradingDays254,


        [EnumMember(Value = "Trading days/255")]
        TradingDays255,


        [EnumMember(Value = "Trading days/256")]
        TradingDays256,


        [EnumMember(Value = "Trading days/257")]
        TradingDays257

    }
}
