using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        /// <summary>
        /// The dividend or coupon amount.
        /// </summary>
        [DataMember(Name = "dividend", IsRequired = true, Order = 1)]
        public double? Amount { get; set; }

        /// <summary>
        /// The day you receive your money.
        /// </summary>
        [DataMember(Name = "dividenddate", IsRequired = true, Order = 1)]
        public DateTime? DividendDate { get; set; }

        /// <summary>
        /// The day the stock is traded without dividend.
        /// </summary>
        [DataMember(Name = "exdividenddate", IsRequired = true, Order = 1)]
        public DateTime? ExDividendDate { get; set; }

        /// <summary>
        /// An optional comment to describe the dividend.
        /// </summary>
        [DataMember(Name = "comment", Order = 1)]
        [StringLength(64)]
        public string Comment { get; set; }

        /// <summary>
        /// A three letter currency identifier. Default: Contract currency.
        /// </summary>
        [DataMember(Name = "currency", Order = 1)]
        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; }

        /// <summary>
        /// Kind of dividend. Default: If the underlyings assettype is "Interest Rate" or the instrument has kind "Convertible", 
        /// "Structured note" or "Structured Convertible" default is "Relative" else default is "Absolute".
        /// </summary>
        [DataMember(Name = "dividendkind", Order = 1)]
        public DividendKind? DividendKind { get; set; }

        /// <summary>
        /// How big part of the dividend you get. Default: 1.0 (100 %).
        /// </summary>
        [DataMember(Name = "weight", Order = 1)]
        public double? Weight { get; set; }
    }
}