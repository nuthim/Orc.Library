using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "reference_price_entries", ItemName = "reference_price_entry", Namespace = "")]
    public class ReferencePriceEntries : List<ReferencePriceEntry>
    {

    }

    [DataContract(Name = "reference_price_entry", Namespace = "")]
    public class ReferencePriceEntry
    {
        [DataMember(Name = "date")]
        public DateTime Date { get; set; }

        [DataMember(Name = "reference_price")]
        public double? ReferencePrice { get; set; }
    }


}
