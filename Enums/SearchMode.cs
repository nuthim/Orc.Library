using System.Runtime.Serialization;


namespace Orc.Library.Enums
{

    [DataContract(Name = "search_mode", Namespace = "")]
    public enum SearchMode
    {
        /// <summary>
        /// Search for strings beginning with the search string.
        /// </summary>
        [EnumMember]
        Beginning,

        /// <summary>
        /// Search for strings ending with the search string.
        /// </summary>
        [EnumMember]
        Ending,

        /// <summary>
        /// Search for strings containing the search string.
        /// </summary>
        [EnumMember]
        Containing,

        /// <summary>
        /// Search for strings equal to the search string.
        /// </summary>
        [EnumMember]
        Equal,
    }
}
