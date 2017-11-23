using System.Runtime.Serialization;


namespace Orc.Library.Enums
{

    [DataContract(Name = "volume_condition", Namespace = "")]
    public enum VolumeCondition
    {
        [EnumMember(Value = "normal")]
        Normal,

        [EnumMember(Value = "all or nothing")]
        AllOrNothing,

        [EnumMember(Value = "ignore")]
        Ignore
    }

}
