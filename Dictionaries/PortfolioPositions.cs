using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Orc.Library.Enums;


namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "portfolio_positions", ItemName = "portfolio_position", Namespace = "")]
    public class PortfolioPositions : List<PortfolioPosition>
    {

    }

    [DataContract(Name = "portfolio_position", Namespace = "")]
    public class PortfolioPosition
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "invested")]
        public double? Invested { get; set; }

        [DataMember(Name = "volume")]
        public double? Volume { get; set; }

        [DataMember(Name = "accrued")]
        public double? Accrued { get; set; }

        [DataMember(Name = "buy_or_sell]")]
        public BuySell? BuyOrSell { get; set; }

        [DataMember(Name = "change_in_accrued")]
        public double? ChangeInAccrued { get; set; }

        [DataMember(Name = "change_in_commission")]
        public double? ChangeInCommission { get; set; }

        [DataMember(Name = "change_in_invested")]
        public double? ChangeInInvested { get; set; }

        [DataMember(Name = "change_in_volume")]
        public double? ChangeInVolume { get; set; }

        [DataMember(Name = "commission")]
        public double? Commission { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "fee")]
        public double? Fee { get; set; }

        [DataMember(Name = "settlement_date")]
        public DateTime? SettlementDate { get; set; }
    }
}
