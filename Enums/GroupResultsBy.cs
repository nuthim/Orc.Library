using System.Runtime.Serialization;


namespace Orc.Library.Enums
{
    [DataContract(Name = "group_results_by", Namespace = "")]
    public enum GroupResultsBy
    {
        [EnumMember]
        Underlying,

        [EnumMember(Value = "Underlying and expiry")]
        UnderlyingExpiry,

        [EnumMember]
        Position
    }
}