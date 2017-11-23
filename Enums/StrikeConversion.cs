using System.Runtime.Serialization;


namespace Orc.Library.Enums
{
    [DataContract(Name = "strike_conversion", Namespace = "")]
    public enum StrikeConversion
    {
        [EnumMember(Value = "None")]
        None,

        [EnumMember(Value = "Euro Future")]
        EuroFuture
    }
}
