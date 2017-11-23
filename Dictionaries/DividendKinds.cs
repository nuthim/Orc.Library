using System.Collections.Generic;
using System.Runtime.Serialization;
using Orc.Library.Enums;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "dividendkinds", ItemName = "dividendkind", Namespace = "")]
    public class DividendKinds : List<DividendKind>
    {
        
    }
}