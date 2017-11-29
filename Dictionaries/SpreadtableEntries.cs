using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "spreadtable_entries", ItemName = "spreadtable_entry", Namespace = "")]
    public class SpreadtableEntries : List<SpreadtableEntry>
    {

    }

    [DataContract(Name = "spreadtable_entry", Namespace = "")]
    public class SpreadtableEntry
    {
        [DataMember(Name = "lower")]
        public double? Lower { get; set; }

        [DataMember(Name = "spread")]
        public double? Spread { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }
    }
}
