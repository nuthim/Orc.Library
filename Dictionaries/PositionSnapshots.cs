using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Orc.Library.Enums;


namespace Orc.Library.Dictionaries
{

    [CollectionDataContract(Name = "positionsnapshots", ItemName = "positionsnapshot", Namespace = "")]
    public class PositionSnapshots : List<PositionSnapshot>
    {

    }

    [DataContract(Name = "positionsnapshot", Namespace = "")]
    public class PositionSnapshot
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "buy_or_sell")]
        public BuySell? BuyOrSell { get; set; }

        [DataMember(Name = "settlement_date")]
        public DateTime? SettlementDate { get; set; }

        [DataMember(Name = "from_date")]
        public DateTime? FromDate { get; set; }

        [DataMember(Name = "to_date")]
        public DateTime? ToDate { get; set; }

        [DataMember(Name = "baseprice")]
        public double? BasePrice { get; set; }

        [DataMember(Name = "dividends")]
        public double? Dividends { get; set; }

        [DataMember(Name = "interest_rate")]
        public double? InterestRate { get; set; }

        [DataMember(Name = "market_value")]
        public double? MarketValue { get; set; }

        [DataMember(Name = "rho")]
        public double? Rho { get; set; }

        [DataMember(Name = "swimming_skew_delta")]
        public double? SwimmingSkewDelta { get; set; }

        [DataMember(Name = "swimming_skew_gamma")]
        public double? SwimmingSkewGamma { get; set; }

        [DataMember(Name = "theoretical_value_from")]
        public double? TheoreticalValueFrom { get; set; }

        [DataMember(Name = "theoretical_value_to")]
        public double? TheoreticalValueTo { get; set; }

        [DataMember(Name = "vega")]
        public double? Vega { get; set; }

        [DataMember(Name = "volatility")]
        public double? Volatility { get; set; }

        [DataMember(Name = "volume")]
        public double? Volume { get; set; }
    }

}
