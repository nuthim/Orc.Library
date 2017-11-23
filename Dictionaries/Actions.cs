using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "actions", ItemName = "action", Namespace = "")]
    public class Actions : List<string>
    {

    }
}