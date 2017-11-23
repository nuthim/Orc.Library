using System.Runtime.Serialization;


namespace Orc.Library.Enums
{
    [DataContract(Name = "beta_logic", Namespace = "")]
    public enum BetaLogic
    {
        /// <summary>
        /// Risk values are adjusted both by the beta factor and by the beta base contract price factor.
        /// </summary>
        [EnumMember]
        Normal,

        /// <summary>
        /// Risk values connected to underlying movement (for example, delta of position) are adjusted by only the beta factor before being added to the beta base summary. 
        /// This is useful if you're trading interest rate instruments and want to adjust the risk values with the beta factor, but not with a beta base contract price factor.
        /// </summary>
        [EnumMember(Value = "Only Beta")]
        OnlyBeta

    }
}