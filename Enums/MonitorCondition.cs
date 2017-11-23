using System.Runtime.Serialization;


namespace Orc.Library.Enums
{
    [DataContract(Name = "monitor_condition", Namespace = "")]
    public enum MonitorCondition
    {
        [EnumMember(Value = "Lower or Equal")]
        LowerOrEqual,

        [EnumMember(Value = "Larger or Equal")]
        LargerOrEqual
    }
}
