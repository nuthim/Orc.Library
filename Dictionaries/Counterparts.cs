using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name= "counterparts", ItemName = "counterpart", Namespace = "")]
    public class Counterparts : List<string>
    {

    }
}