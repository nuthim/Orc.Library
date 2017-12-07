using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Orc.Library.Dictionaries
{

    [CollectionDataContract(Name = "reference_price_entries_per_underlying", ItemName = "reference_price_entries", Namespace = "")]
    public class ReferencePriceEntriesPerUnderlying : List<ReferencePriceEntries>
    {

    }
}
