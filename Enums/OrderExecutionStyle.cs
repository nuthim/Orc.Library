using System.Runtime.Serialization;


namespace Orc.Library.Enums
{

    [DataContract(Name = "order_execution_style", Namespace = "")]
    public enum OrderExecutionStyle
    {
        [EnumMember(Value = "cross")]
        Cross,

        [EnumMember(Value = "custom")]
        Custom,

        [EnumMember(Value = "interbank")]
        Interbank,

        [EnumMember(Value = "normal")]
        Normal,

        [EnumMember(Value = "stop")]
        Stop
    }

}