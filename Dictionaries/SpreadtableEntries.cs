using Orc.Library.Enums;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "spread_tables", ItemName = "spread_table", Namespace = "")]
    public class SpreadTables : List<SpreadTable>
    {

    }

    [DataContract(Name = "spread_table", Namespace = "")]
    public class SpreadTable
    {
        [DataMember(Name = "name", Order = 1)]
        public string Name { get; set; }

        [DataMember(Name = "boundarymode", Order = 2)]
        public BoundaryMode? BoundaryMode { get; set; }

        [DataMember(Name = "direction", Order = 3)]
        public Direction? Direction { get; set; }
    }
}
