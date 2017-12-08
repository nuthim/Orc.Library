using System.Runtime.Serialization;

namespace Orc.Library.Enums
{
    [DataContract(Name = "date_or_days", Namespace = "")]
    public enum DateOrDays
    {
        [EnumMember(Value = "date")]
        Date,

        [EnumMember(Value = "days")]
        Days
    }
}