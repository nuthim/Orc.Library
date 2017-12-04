using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "simulated_prices", ItemName = "simulated_price", Namespace = "")]
    public class SimulatedPrices : List<double>
    {

    }
}