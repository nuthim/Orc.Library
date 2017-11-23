using System.Runtime.Serialization;


namespace Orc.Library.Enums
{
    [DataContract(Name = "vwap_execution_type", Namespace = "")]
    public enum VwapExecutionType
    {
        [EnumMember(Value = "No execution")]
        NoExecution,

        [EnumMember]
        Agency,

        [EnumMember]
        Guaranteed
    }
}
