using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "surface_entries", ItemName = "surface_entry", Namespace = "")]
    public class SurfaceEntries : List<SurfaceEntry>
    {

    }

    [DataContract(Name = "surface_entry", Namespace = "")]
    public class SurfaceEntry
    {
        [DataMember(Name = "model", Order = 1)]
        public string Model { get; set; }

        [DataMember(Name = "surface_name", Order = 2)]
        public string SurfaceName { get; set; }
    }
}