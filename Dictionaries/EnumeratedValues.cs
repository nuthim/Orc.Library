using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "enumerated_values", ItemName = "enum", Namespace = "")]
    public class EnumeratedValues : List<string>
    {

    }
}
