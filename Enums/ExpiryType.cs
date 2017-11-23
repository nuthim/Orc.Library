using System.Runtime.Serialization;

namespace Orc.Library.Enums
{

    [DataContract(Name = "expirytype", Namespace = "")]
    public enum ExpiryType
    {
        [EnumMember]
        American,

        [EnumMember]
        European
    }

    
}