using System.Collections.Generic;
using System.Runtime.Serialization;
using Orc.Library.Enums;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "allocateItems", ItemName = "allocateItem", Namespace = "")]
    public class AllocateItems : List<AllocateItem>
    {

    }

    [DataContract(Name = "allocateItem", Namespace = "")]
    public class AllocateItem
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "unique_trade_id")]
        public string UniqueTradeId { get; set; }

        [DataMember(Name = "portfolio")]
        public string Portfolio { get; set; }

        [DataMember(Name = "price")]
        public double? Price { get; set; }

        [DataMember(Name = "volume")]
        public double? Volume { get; set; }

        [DataMember(Name = "bic")]
        public int? Bic { get; set; }

        [DataMember(Name = "buy_or_sell")]
        public BuySell? BuyOrSell { get; set; }

        [DataMember(Name = "accrued")]
        public double? Accrued { get; set; }
    }
}