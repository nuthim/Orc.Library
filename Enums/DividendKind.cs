using System.Runtime.Serialization;

namespace Orc.Library.Enums
{
    [DataContract(Name = "dividendkind", Namespace = "")]
    public enum DividendKind
    {
        /// <summary>
        /// Normal spot dividend (default for most instruments)
        /// </summary>
        [EnumMember]
        Absolute,

        /// <summary>
        /// Amount is in % instead of currency (eg bond coupons)
        /// </summary>
        [EnumMember]
        Relative,

        /// <summary>
        /// The nominal amount of a bond paid at maturity
        /// </summary>
        [EnumMember]
        Maturity,

        /// <summary>
        /// FRN date
        /// </summary>
        [EnumMember]
        Floating,

        /// <summary>
        /// Equity reset date. Only for Asian ARO, Asian forward start, Asian ARO quanto.
        /// For Asian ARO contracts, the reset date and amount corresponds to exdividend and dividend, respectively (dividend dictionary).
        /// Note also that the Resets should not have a currency
        /// </summary>
        [EnumMember]
        Reset,

        /// <summary>
        /// FRN date for short leg
        /// </summary>
        [EnumMember(Value = "Floating negative")]
        FloatingNegative,

        /// <summary>
        /// Short leg relative
        /// </summary>
        [EnumMember(Value = "Relative negative")]
        RelativeNegative,

        /// <summary>
        /// Short leg maturity
        /// </summary>
        [EnumMember(Value = "Maturity negative")]
        MaturityNegative,

        /// <summary>
        /// Date for callability for convertibles
        /// </summary>
        [EnumMember(Value = "Convertible call date")]
        ConvertibleCallDate,

        /// <summary>
        /// Date for soft callability for convertibles
        /// </summary>
        [EnumMember(Value = "Convertible soft call date")]
        ConvertibleSoftCallDate,

        /// <summary>
        /// Date for putability for convertibles
        /// </summary>
        [EnumMember(Value = "Convertible put date")]
        ConvertiblePutDate,

        [EnumMember(Value = "Spot relative")]
        SpotRelative,

        [EnumMember]
        Yield,

        [EnumMember(Value = "Closing price")]
        ClosingPrice
    }
}