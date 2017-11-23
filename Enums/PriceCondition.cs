using System.Runtime.Serialization;


namespace Orc.Library.Enums
{
    [DataContract(Name = "price_condition", Namespace = "")]
    public enum PriceCondition
    {
        [EnumMember]
        Normal,

        [EnumMember(Value = "At Market")]
        AtMarket,

        [EnumMember]
        Ignore,

        [EnumMember]
        Bid,

        [EnumMember]
        Ask,

        [EnumMember]
        Last,

        [EnumMember(Value = "Combo Depth")]
        ComboDepth,

        [EnumMember]
        Bait,
    }
}
