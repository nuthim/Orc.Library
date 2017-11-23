using System.Runtime.Serialization;
using Orc.Library.Dictionaries;


namespace Orc.Library.Messages.Server
{
    public class EnumValueCollection : OrcMessage
    {
        [DataMember(Name = "requested_enum")]
        public string EnumType { get; set; }

        [DataMember(Name = "enumerated_values")]
        public EnumeratedValues Values { get; set; }
    }


}
