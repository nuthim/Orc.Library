using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "reference_price_downloads", ItemName = "reference_price_download", Namespace = "")]
    public class ReferencePriceDownloads : List<ReferencePriceDownload>
    {

    }

    [DataContract(Name = "reference_price_download", Namespace = "")]
    public class ReferencePriceDownload
    {
        [DataMember(Name = "Underlying")]
        public string Underlying { get; set; }

        [DataMember(Name = "reference_price_entries")]
        public ReferencePriceEntries ReferencePriceEntries { get; set; }

        [DataMember(Name = "surface_name")]
        public string SurfaceName { get; set; }
    }

    
}
