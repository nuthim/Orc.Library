using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "fieldname_values", ItemName = "fieldname_value", Namespace = "")]
    public class FieldNameValues : List<FieldNameValue>
    {
        
    }

    [DataContract(Name = "fieldname_value", Namespace = "")]
    public class FieldNameValue
    {
        [DataMember(Name = "fieldname")]
        public string FieldName { get; set; }

        [DataMember(Name = "name")]
        public string Value { get; set; }
    }
}