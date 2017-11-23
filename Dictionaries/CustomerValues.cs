using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "customer_values", ItemName = "customer_value", Namespace = "")]
    public class CustomerValues : List<CustomerValue>
    {

    }

    [DataContract(Name = "customer_value", Namespace = "")]
    public class CustomerValue
    {
        [DataMember(Name = "customer_id")]
        public string CustomerId { get; set; }

        [DataMember(Name = "fieldname")]
        public string FieldName { get; set; }

        [DataMember(Name = "value")]
        public string Value { get; set; }
    }
}