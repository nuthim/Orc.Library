using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "instrument_list", ItemName = "instrument_id", Namespace = "")]
    public class InstrumentList : List<InstrumentId>
    {

    }
}