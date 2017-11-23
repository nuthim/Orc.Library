using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "inserted_trades", ItemName = "trade_tag", Namespace = "")]
    public class InsertedTrades : List<int>
    {

    }
}