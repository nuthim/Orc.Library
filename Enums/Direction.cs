using System.Runtime.Serialization;


namespace Orc.Library.Enums
{
    [DataContract(Name = "direction", Namespace = "")]
    public enum Direction
    {
        [EnumMember]
        In,

        [EnumMember]
        Out
    }
}
