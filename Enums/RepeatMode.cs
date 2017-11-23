using System.Runtime.Serialization;

namespace Orc.Library.Enums
{
    [DataContract(Name = "repeat_mode", Namespace = "")]
    public enum RepeatMode
    {
        [EnumMember]
        Sundays,

        [EnumMember]
        Mondays,

        [EnumMember]
        Tuesdays,

        [EnumMember]
        Wednesdays,

        [EnumMember]
        Thursdays,

        [EnumMember]
        Fridays,

        [EnumMember]
        Saturdays,

        [EnumMember]
        Date,

        [EnumMember]
        Yearly
    }
}