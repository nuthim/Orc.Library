using System.Runtime.Serialization;

namespace Orc.Library.Enums
{
    [DataContract(Name = "assettype", Namespace = "")]
    public enum AssetType
    {
        [EnumMember]
        Equities,

        [EnumMember(Value = "Interest Rate")]
        InterestRate,

        [EnumMember]
        Commodities,

        /// <summary>
        /// FX contracts
        /// </summary>
        [EnumMember]
        Currencies
    }
}