using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "volatility_models", ItemName = "volatility_model", Namespace = "")]
    public class VolatilityModels : List<string>
    {

    }
}