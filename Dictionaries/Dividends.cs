using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Orc.Library.Enums;


namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "dividends", ItemName = "dividend", Namespace = "")]
    public class Dividends : List<Dividend>
    {

    }

    [DataContract(Name = "dividend", Namespace = "")]
    public class Dividend
    {
        [DataMember(Name = "dividend")]
        public double? Amount { get; set; }

        [DataMember(Name = "dividenddate")]
        public DateTime? DividendDate { get; set; }

        [DataMember(Name = "exdividenddate")]
        public DateTime? ExDividendDate { get; set; }

        [DataMember(Name = "comment")]
        public string Comment { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "dividendkind")]
        public DividendKind? DividendKind { get; set; }

        [DataMember(Name = "weight")]
        public double? Weight { get; set; }
    }
}