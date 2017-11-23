using System.Runtime.Serialization;

namespace Orc.Library.Enums
{
    [DataContract(Name = "feed_action", Namespace = "")]
    public enum FeedAction
    {
        [EnumMember]
        Insert,

        [EnumMember]
        Update,

        [EnumMember]
        Delete
    }
}