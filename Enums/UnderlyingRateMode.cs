using System.Runtime.Serialization;


namespace Orc.Library.Enums
{
    [DataContract(Name = "underlying_rate_mode", Namespace = "")]
    public enum UnderlyingRateMode
    {
        [EnumMember]
        Contract,

        [EnumMember]
        Curve,

        [EnumMember(Value = "Curve with no dividends")]
        CurveWithNoDividends
    }
}
