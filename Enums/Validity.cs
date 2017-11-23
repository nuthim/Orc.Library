using System.Runtime.Serialization;


namespace Orc.Library.Enums
{
    [DataContract(Name = "validity", Namespace = "")]
    public enum Validity
    {
        [EnumMember(Value = "immediate")]
        Immediate,

        [EnumMember(Value = "today")]
        Today,

        [EnumMember(Value = "until cancelled")]
        UntilCancelled
    }
}
