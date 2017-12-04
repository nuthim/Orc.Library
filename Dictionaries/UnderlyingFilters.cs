using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "underlying_filters", ItemName = "underlying_filter", Namespace = "")]
    public class UnderlyingFilters : List<string>
    {

    }
}