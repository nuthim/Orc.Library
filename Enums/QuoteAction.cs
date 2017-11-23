using System.Runtime.Serialization;


namespace Orc.Library.Enums
{
    [DataContract(Name = "quote_action", Namespace = "")]
    public enum QuoteAction
    {
        [EnumMember]
        Suggest,

        [EnumMember]
        Send,

        [EnumMember]
        Zap
    }
}
