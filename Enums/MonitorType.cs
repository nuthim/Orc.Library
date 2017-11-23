using System.Runtime.Serialization;


namespace Orc.Library.Enums
{
    [DataContract(Name = "monitor_type", Namespace = "")]
    public enum MonitorType
    {
        [EnumMember]
        Bid,

        [EnumMember]
        Offer,

        [EnumMember]
        Last,

        [EnumMember]
        Theoretical,

        [EnumMember]
        Edge
    }

}
