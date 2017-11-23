using System.Runtime.Serialization;

namespace Orc.Library.Enums
{

    [DataContract(Name = "money_kind", Namespace = "")]
    public enum MoneyKind
    {
        [EnumMember]
        Balance,

        [EnumMember]
        Carry,

        [EnumMember]
        Cash,

        [EnumMember]
        Correction,

        [EnumMember]
        Coupon,

        [EnumMember(Value = "Credit limit")]
        CreditLimit,

        [EnumMember]
        Dividend,

        [EnumMember]
        Fee,

        [EnumMember]
        Financing,

        [EnumMember(Value = "Futures limit")]
        FuturesLimit,

        [EnumMember(Value = "Lending")]
        Lending,

        [EnumMember(Value = "Margins")]
        Margins,

        [EnumMember(Value = "Short spot limit")]
        ShortSpotLimit,

        [EnumMember(Value = "Short options limit")]
        ShortOptionsLimit
    }
   
}