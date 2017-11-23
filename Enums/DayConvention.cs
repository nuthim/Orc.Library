using System.Runtime.Serialization;

namespace Orc.Library.Enums
{
    /// <summary>
    /// The day convention is given by Number of days in month/Number of days in a year.
    /// </summary>
    [DataContract(Name = "day_convention", Namespace = "")]
    public enum DayConvention
    {

        [EnumMember(Value = "Actual/Actual")]
        ActualActual,

        [EnumMember(Value = "Actual/365")]
        Actual365,

        /// <summary>
        /// 366 in leap year. In practice the same as Actual/Actual.
        /// </summary>
        [EnumMember(Value = "Actual/365-366")]
        Actual366,

        [EnumMember(Value = "Actual/360")]
        Actual360,

        [EnumMember(Value = "30/360")]
        Thirty360,

        [EnumMember(Value = "30E/360")]
        ThirtyE360,

        [EnumMember(Value = "Business/252")]
        Business252

    }
}