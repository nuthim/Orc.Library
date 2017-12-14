using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "spreadtable_entries", ItemName = "spreadtable_entry", Namespace = "")]
    public class SpreadTableEntries : List<SpreadTableEntry>
    {

    }

    [DataContract(Name = "spreadtable_entry", Namespace = "")]
    public class SpreadTableEntry
    {
        [DataMember(Name = "lower", Order = 1)]
        public double? Lower { get; set; }

        [DataMember(Name = "spread", Order = 2)]
        public double? Spread { get; set; }

        [DataMember(Name = "type", Order = 3)]
        public string Type { get; set; }
    }
}
