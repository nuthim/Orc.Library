using System.Runtime.Serialization;


namespace Orc.Library.Enums
{
    [DataContract(Name = "volatility_time_mode", Namespace = "")]
    public enum VolatilityTimeMode
    {
        [EnumMember]
        None,

        [EnumMember(Value = "Quoting expiry")]
        QuotingExpiry,

        [EnumMember(Value = "Quoting always")]
        QuotingAlways,

        [EnumMember]
        Always
    }
}
