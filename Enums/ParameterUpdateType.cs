using System.Runtime.Serialization;


namespace Orc.Library.Enums
{

    [DataContract(Name = "parameter_update_type", Namespace = "")]
    public enum ParameterUpdateType
    {
        /// <summary>
        /// new value = value
        /// </summary>
        [EnumMember(Value = "absolute")]
        Absolute,

        /// <summary>
        /// new value = current value + value
        /// </summary>
        [EnumMember(Value = "relative")]
        Relative,

        /// <summary>
        /// new value = current value * value
        /// </summary>
        [EnumMember(Value = "multiplicative")]
        Multiplicative
    }
}
