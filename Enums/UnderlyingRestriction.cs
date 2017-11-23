using System.Runtime.Serialization;


namespace Orc.Library.Enums
{
    [DataContract(Name = "underlying_restriction", Namespace = "")]
    public enum UnderlyingRestriction
    {
        /// <summary>
        /// Default value. No restriction on underlying
        /// </summary>
        [EnumMember]
        None,

        /// <summary>
        /// Restriction set on underlying. If an underlying is restricted, then Orc users cannot trade in contracts belonging to the underlying. 
        /// Some users may still trade the underlying's contracts if they set the underlying to restriction overridden status. Refer to Orc User Manual for more information
        /// </summary>
        [EnumMember]
        Black,

        /// <summary>
        /// Restricts buying only
        /// </summary>
        [EnumMember]
        Buy,

        /// <summary>
        /// Restricts selling only
        /// </summary>
        [EnumMember]
        Sell
    }
}
