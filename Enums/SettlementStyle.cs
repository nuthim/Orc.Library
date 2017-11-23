using System.Runtime.Serialization;


namespace Orc.Library.Enums
{

    [DataContract(Name = "settlement_style", Namespace = "")]
    public enum SettlementStyle
    {
        [EnumMember]
        Delivery,

        [EnumMember]
        Cash,

        [EnumMember]
        Future
    }
}
