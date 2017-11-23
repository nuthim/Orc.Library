using System.Runtime.Serialization;


namespace Orc.Library.Enums
{
    [DataContract(Name = "suggest_logic ", Namespace = "")]
    public enum SuggestLogic
    {
        [EnumMember]
        Theoretical,

        [EnumMember(Value = "Market limited by theoretical")]
        MarketLimitedByTheoretical,

        [EnumMember(Value = "Market unlimited")]
        MarketUnlimited,

        [EnumMember(Value = "Theoretical quote")]
        TheoreticalQuote,

        [EnumMember]
        Disabled
    }
}
