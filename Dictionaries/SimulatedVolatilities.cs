using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "simulated_volatilities", ItemName = "simulated_volatility", Namespace = "")]
    public class SimulatedVolatilities : List<double>
    {

    }
}