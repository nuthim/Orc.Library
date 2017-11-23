using System.Runtime.Serialization;


namespace Orc.Library.Enums
{
    [DataContract(Name = "suppress_reply", Namespace = "")]
    public enum SuppressReply
    {
        /// <summary>
        /// //No replies are suppressed
        /// </summary>
        [EnumMember(Value = "none")]
        None,

        /// <summary>
        /// Replies to failed operations are suppressed
        /// </summary>
        [EnumMember(Value = "error")]
        Error,

        /// <summary>
        /// Replies to successful operations are suppressed
        /// </summary>
        [EnumMember(Value = "successfull")]
        Successfull,

        /// <summary>
        /// Replies to all operations are suppressed
        /// </summary>
        [EnumMember(Value = "all")]
        All 
    }
}