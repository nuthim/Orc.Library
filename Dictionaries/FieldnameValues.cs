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
        [DataMember(Name = "fieldname", IsRequired = true, Order = 1)]
        public string FieldName { get; set; }

        [DataMember(Name = "value", IsRequired = true, Order = 2)]
        public string Value { get; set; }
    }
}