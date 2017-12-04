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
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "value")]
        public string Value { get; set; }

        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }
    }
}