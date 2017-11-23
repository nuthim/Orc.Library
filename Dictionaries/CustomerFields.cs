using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "customer_fields", ItemName = "customer_field", Namespace = "")]
    public class CustomerFields : List<CustomerField>
    {

    }

    [DataContract(Name = "customer_field", Namespace = "")]
    public class CustomerField : List<string>
    {
        [DataMember(Name = "fieldname")]
        public string FieldName { get; set; }

        [DataMember(Name = "locked")]
        public bool? Locked { get; set; }

        [DataMember(Name = "order")]
        public int? Order { get; set; }
    }
}