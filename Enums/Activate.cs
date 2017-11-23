using System.Runtime.Serialization;

namespace Orc.Library.Enums
{
    [DataContract(Name = "activate", Namespace = "")]
    public enum Activate
    {
        /// <summary>
        /// Exchange order
        /// </summary>
        [EnumMember]
        Exchange,

        /// <summary>
        /// Internal order
        /// </summary>
        [EnumMember]
        Internal,

        /// <summary>
        /// Inactive order
        /// </summary>
        [EnumMember]
        No
    }
}