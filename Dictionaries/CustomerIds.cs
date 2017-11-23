using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "customer_ids", ItemName = "customer_id", Namespace = "")]
    public class CustomerIds : List<string>
    {

    }
}