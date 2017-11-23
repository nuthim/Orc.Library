using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "additional_data", ItemName = "additional_data_entry", Namespace = "")]
    public class AdditionalData : List<AdditionalDataEntry>
    {
  
    }

    [DataContract(Name = "additional_data_entry", Namespace = "")]
    public class AdditionalDataEntry
    {
        [DataMember(Name = "key")]
        public string Key { get; set; }

        [DataMember(Name = "value")]
        public string Value { get; set; }
    }

    
}