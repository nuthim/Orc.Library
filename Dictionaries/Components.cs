using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "components", ItemName = "component", Namespace = "")]
    public class Components : List<Component>
    {

    }

    [DataContract(Name = "component", Namespace = "")]
    public class Component
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "volume")]
        public double? Volume { get; set; }

        [DataMember(Name = "ranking")]
        public int? Ranking { get; set; }

        [DataMember(Name = "calculation_volume")]
        public double? CalculationVolume { get; set; }
    }
}