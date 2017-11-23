using System.Runtime.Serialization;


namespace Orc.Library.Enums
{

    [DataContract(Name = "ratetype", Namespace = "")]
    public enum RateType
    {
        /// <summary>
        /// Continuous compounded interest rate
        /// </summary>
        [EnumMember]
        Continuous,

        /// <summary>
        /// Yearly compounded interest rate
        /// </summary>
        [EnumMember]
        Annual,

        /// <summary>
        /// Semi-Annual compounded interest rate
        /// </summary>
        [EnumMember(Value = "Semi-Annual")]
        SemiAnnual,

        /// <summary>
        /// Quarterly compounded interest rate
        /// </summary>
        [EnumMember]
        Quarterly,

        /// <summary>
        /// Monthly compounded interest rate
        /// </summary>
        [EnumMember]
        Monthly,

        /// <summary>
        /// Straight interest rate
        /// </summary>
        [EnumMember]
        Simple,

        /// <summary>
        /// Discount rate. (Used in Treasury bill markets.)
        /// </summary>
        [EnumMember]
        Discount,

        [EnumMember(Value = "Present value factor")]
        PresentValueFactor

    }
}
