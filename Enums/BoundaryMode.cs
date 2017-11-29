using System.Runtime.Serialization;


namespace Orc.Library.Enums
{
    [DataContract(Name = "boundarymode", Namespace = "")]    
    public enum BoundaryMode
    {
        [EnumMember]
        Average,

        [EnumMember]
        Bid,

        [EnumMember]
        Delta
    }
}
