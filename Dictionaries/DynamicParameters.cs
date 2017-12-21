using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "dynamic_parameters", ItemName = "dynamic_parameter", Namespace = "")]
    public class DynamicParameters : List<DynamicParameter>
    {

    }

    [DataContract(Name = "dynamic_parameter", Namespace = "")]
    public class DynamicParameter
    {
        [DataMember(Name = "name", IsRequired = true, Order = 1)]
        public string Name { get; set; }

        [DataMember(Name = "value", Order = 2)]
        public string Value { get; set; }

        [DataMember(Name = "instrument_id", Order = 3)]
        public InstrumentId InstrumentId { get; set; }
    }
}