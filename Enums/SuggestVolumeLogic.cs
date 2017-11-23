using System.Runtime.Serialization;


namespace Orc.Library.Enums
{

    [DataContract(Name = "suggest_volume_logic ", Namespace = "")]
    public enum SuggestVolumeLogic
    {
        /// <summary>
        /// Suggest default volume until filled.
        /// </summary>
        [EnumMember(Value = "Default not filled")]
        Default,

        /// <summary>
        /// Always suggest default volume.
        /// </summary>
        [EnumMember]
        Always,

        /// <summary>
        /// Don't suggest new volume if filled.
        /// </summary>
        [EnumMember(Value = "Not filled")]
        NotFilled,

        /// <summary>
        /// Suggest new volume when volume too low.
        /// </summary>
        [EnumMember]
        Low,

        /// <summary>
        /// Suggest volume without lot multiplier.
        /// </summary>
        [EnumMember]
        Lowest
    }
}
