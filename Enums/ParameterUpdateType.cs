using System.Runtime.Serialization;


namespace Orc.Library.Enums
{

    [DataContract(Name = "parameter_update_type", Namespace = "")]
    public enum ParameterUpdateType
    {
        [EnumMember(Value = "absolute")]
        Absolute,

        [EnumMember(Value = "relative")]
        Relative,

        [EnumMember(Value = "multiplicative")]
        Multiplicative
    }
}
