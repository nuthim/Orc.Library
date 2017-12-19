using Orc.Library.Enums;
using System;
using System.Runtime.Serialization;


namespace Orc.Library.Dictionaries
{
    [DataContract(Name = "parameters", Namespace = "")]
    public class Parameters
    {
        [DataMember(Name = "accrued_rateday_convention", Order = 1)]
        public DayConvention? AccruedRatedayConvention { get; set; }

        [DataMember(Name = "apply_baseoffset_logic", Order = 2)]
        public ApplyBaseOffsetLogic? ApplyBaseOffsetLogic { get; set; }

        [DataMember(Name = "askbaseoffset", Order = 3)]
        public double? AskBaseOffset { get; set; }

        [DataMember(Name = "askoffset", Order = 4)]
        public double? AskOffset { get; set; }

        [DataMember(Name = "askrateoffset", Order = 5)]
        public double? AskRateOffset { get; set; }

        [DataMember(Name = "auto_diming_ask_flag", Order = 6)]
        public bool? AutoDimingAskFlag { get; set; }

        [DataMember(Name = "auto_diming_bid_flag", Order = 7)]
        public bool? AutoDimingBidFlag { get; set; }

        [DataMember(Name = "auto_hedging_ask_flag", Order = 8)]
        public bool? AutoHedgingAskFlag { get; set; }

        [DataMember(Name = "auto_hedging_bid_flag", Order = 9)]
        public bool? AutoHedgingBidFlag { get; set; }

        [DataMember(Name = "auto_mass_quote_ask_flag", Order = 10)]
        public bool? AutoMassQuoteAskFlag { get; set; }

        [DataMember(Name = "auto_mass_quote_bid_flag", Order = 11)]
        public bool? AutoMassQuoteBidFlag { get; set; }

        [DataMember(Name = "auto_quote_flag", Order = 12)]
        public bool? AutoQuoteFlag { get; set; }

        [DataMember(Name = "auto_responding_ask_flag", Order = 13)]
        public bool? AutoRespondingAskFlag { get; set; }

        [DataMember(Name = "auto_responding_bid_flag", Order = 14)]
        public bool? AutoRespondingBidFlag { get; set; }

        [DataMember(Name = "auto_traded_allowed_volume", Order = 15)]
        public double? AutoTradedAllowedVolume { get; set; }

        [DataMember(Name = "auto_traded_volume_ask", Order = 16)]
        public double? AutoTradedVolumeAsk { get; set; }

        [DataMember(Name = "auto_traded_volume_bid", Order = 17)]
        public double? AutoTradedVolumeBid { get; set; }

        [DataMember(Name = "auto_trading_ask_flag", Order = 18)]
        public bool? AutoTradingAskFlag { get; set; }

        [DataMember(Name = "auto_trading_bid_flag", Order = 19)]
        public bool? AutoTradingBidFlag { get; set; }

        [DataMember(Name = "barrier", Order = 20)]
        public double? Barrier { get; set; }

        [DataMember(Name = "base_price_multiplier", Order = 21)]
        public double? BasePriceMultiplier { get; set; }

        [DataMember(Name = "basecontract", Order = 22)]
        public InstrumentId BaseContract { get; set; }

        [DataMember(Name = "baseoffset]", Order = 23)]
        public double? BaseOffset { get; set; }

        [DataMember(Name = "bidbaseoffset", Order = 24)]
        public double? BidBaseOffset { get; set; }

        [DataMember(Name = "bidoffset", Order = 25)]
        public double? BidOffset { get; set; }

        [DataMember(Name = "bidrateoffset", Order = 26)]
        public double? BidRateOffset { get; set; }

        [DataMember(Name = "cficode", Order = 27)]
        public string Cficode { get; set; }

        [DataMember(Name = "components", Order = 28)]
        public Components Components { get; set; }

        [DataMember(Name = "convertible_from", Order = 29)]
        public DateTime? ConvertibleFrom { get; set; }

        [DataMember(Name = "cusip", Order = 30)]
        public string Cusip { get; set; }

        [DataMember(Name = "custom_tick_size", Order = 31)]
        public double? CustomTickSize { get; set; }

        [DataMember(Name = "custom_lot_size", Order = 32)]
        public double? CustomLotSize { get; set; }

        [DataMember(Name = "custom_min_volume", Order = 33)]
        public double? CustomMinVolume { get; set; }

        [DataMember(Name = "custom_volume_step", Order = 34)]
        public double? CustomVolumeStep { get; set; }

        [DataMember(Name = "customer_unique_id", Order = 35)]
        public string CustomerUniqueId { get; set; }

        [DataMember(Name = "description", Order = 36)]
        public string Description { get; set; }

        [DataMember(Name = "dividendcontract", Order = 37)]
        public InstrumentId DividendContract { get; set; }

        [DataMember(Name = "divs_est_net", Order = 38)]
        public double? DivsEstNet { get; set; }

        [DataMember(Name = "divs_paid_to_holder", Order = 39)]
        public double? DivsPaidToHolder { get; set; }

        [DataMember(Name = "dynamic_parameters", Order = 40)]
        public DynamicParameters DynamicParameters { get; set; }

        [DataMember(Name = "end_date", Order = 41)]
        public DateTime? EndDate { get; set; }

        [DataMember(Name = "enforced_customer_unique_id", Order = 42)]
        public string EnforcedCustomerUniqueId { get; set; }

        [DataMember(Name = "exchange", Order = 43)]
        public string Exchange { get; set; }

        [DataMember(Name = "expirytime", Order = 44)]
        public string ExpiryTime { get; set; }

        [DataMember(Name = "feedcode", Order = 45)]
        public string FeedCode { get; set; }

        [DataMember(Name = "final_settlement_days", Order = 46)]
        public int? FinalSettlementDays { get; set; }

        [DataMember(Name = "fixed_fx_rate", Order = 47)]
        public double? FixedFxRate { get; set; }

        [DataMember(Name = "frn_spread", Order = 48)]
        public double? FrnSpread { get; set; }

        [DataMember(Name = "fx_spot_correlation", Order = 49)]
        public double? FxSpotCorrelation { get; set; }

        [DataMember(Name = "fx_volatility", Order = 50)]
        public double? FxVolatility { get; set; }

        [DataMember(Name = "hedgecontract", Order = 51)]
        public InstrumentId HedgeContract { get; set; }

        [DataMember(Name = "instrument_subtype", Order = 52)]
        public int? InstrumentSubtype { get; set; }

        [DataMember(Name = "is_clean_quoted", Order = 53)]
        public bool? IsCleanQuoted { get; set; }

        [DataMember(Name = "isincode", Order = 54)]
        public string IsinCode { get; set; }

        [DataMember(Name = "issuer", Order = 55)]
        public string Issuer { get; set; }

        [DataMember(Name = "is_consolidated_contract", Order = 56)]
        public bool? IsConsolidatedContract { get; set; }

        [DataMember(Name = "is_ytm_quoted", Order = 57)]
        public bool? IsYtmQuoted { get; set; }

        [DataMember(Name = "is_ytm_strike", Order = 58)]
        public bool? IsYtmStrike { get; set; }

        [DataMember(Name = "lower_barrier", Order = 59)]
        public double? LowerBarrier { get; set; }

        [DataMember(Name = "market", Order = 60)]
        public string Market { get; set; }

        [DataMember(Name = "marketcontracts", Order = 61)]
        public MarketContracts MarketContracts { get; set; }

        [DataMember(Name = "mic", Order = 62)]
        public string Mic { get; set; }

        [DataMember(Name = "model", Order = 63)]
        public string Model { get; set; }

        [DataMember(Name = "note_option_multiplier", Order = 64)]
        public double? note_option_multiplier { get; set; }

        [DataMember(Name = "period_length", Order = 65)]
        public int? PeriodLength { get; set; }

        [DataMember(Name = "premium_payment_at_expiry", Order = 66)]
        public bool? PremiumPaymentAtExpiry { get; set; }

        [DataMember(Name = "premium_payment_future", Order = 67)]
        public bool? PremiumPaymentFuture { get; set; }

        [DataMember(Name = "price_display", Order = 68)]
        public string PriceDisplay { get; set; }

        [DataMember(Name = "price_multiplier", Order = 69)]
        public double? PriceMultiplier { get; set; }

        [DataMember(Name = "quote_volatility_surface", Order = 70)]
        public string QuoteVolatilitySurface { get; set; }

        [DataMember(Name = "quotelot_multiplier", Order = 71)]
        public double? QuoteLotMultiplier { get; set; }

        [DataMember(Name = "quotevolatility", Order = 72)]
        public double? QuoteVolatility { get; set; }

        [DataMember(Name = "quotevolatility_askoffset", Order = 73)]
        public double? QuoteVolatilityAskOffset { get; set; }

        [DataMember(Name = "quotevolatility_bidoffset", Order = 74)]
        public double? QuoteVolatilityBidOffset { get; set; }

        [DataMember(Name = "quote_askbaseoffset", Order = 75)]
        public double? QuoteAskBaseOffset { get; set; }

        [DataMember(Name = "quote_askoffset", Order = 76)]
        public double? QuoteAskOffset { get; set; }

        [DataMember(Name = "quote_bidbaseoffset", Order = 77)]
        public double? QuoteBidBaseOffset { get; set; }

        [DataMember(Name = "quote_bidoffset", Order = 78)]
        public double? QuoteBidOffset { get; set; }

        [DataMember(Name = "quote_traded_allowed_volume", Order = 79)]
        public double? QuoteTradedAllowedVolume { get; set; }

        [DataMember(Name = "quote_traded_volume_ask", Order = 80)]
        public double? QuoteTradedVolumeAsk { get; set; }

        [DataMember(Name = "quote_traded_volume_bid", Order = 81)]
        public double? QuoteTradedVolumeBid { get; set; }

        [DataMember(Name = "quote_volume_ask", Order = 82)]
        public double? QuoteVolumeAsk { get; set; }

        [DataMember(Name = "quote_volume_bid", Order = 83)]
        public double? QuoteVolumeBid { get; set; }

        [DataMember(Name = "rebate", Order = 84)]
        public double? Rebate { get; set; }

        [DataMember(Name = "redemption", Order = 85)]
        public double? Redemption { get; set; }

        [DataMember(Name = "risk_volatility_surface", Order = 86)]
        public string RiskVolatilitySurface { get; set; }

        [DataMember(Name = "riskcontract", Order = 87)]
        public InstrumentId RiskContract { get; set; }

        [DataMember(Name = "sedol", Order = 88)]
        public string Sedol { get; set; }

        [DataMember(Name = "settlement_calendar", Order = 89)]
        public string SettlementCalendar { get; set; }

        [DataMember(Name = "settlement_days", Order = 90)]
        public int? SettlementDays { get; set; }

        [DataMember(Name = "settlement_style", Order = 91)]
        public SettlementStyle? SettlementStyle { get; set; }

        [DataMember(Name = "spread", Order = 92)]
        public double? Spread { get; set; }

        [DataMember(Name = "spread_bias", Order = 93)]
        public double? SpreadBias { get; set; }

        [DataMember(Name = "spread_table", Order = 94)]
        public string SpreadTable { get; set; }

        [DataMember(Name = "start_date", Order = 95)]
        public DateTime? StartDate { get; set; }

        [DataMember(Name = "strike_currency", Order = 96)]
        public string StrikeCurrency { get; set; }

        [DataMember(Name = "strike_yield_name", Order = 97)]
        public string StrikeYieldName { get; set; }

        [DataMember(Name = "submarket", Order = 98)]
        public string Submarket { get; set; }

        [DataMember(Name = "suggest_logic", Order = 99)]
        public SuggestLogic? SuggestLogic { get; set; }

        [DataMember(Name = "suggest_volume_logic", Order = 100)]
        public SuggestLogic? SuggestVolumeLogic { get; set; }

        [DataMember(Name = "suggest_volume_min", Order = 101)]
        public double? SuggestVolumeMin { get; set; }

        [DataMember(Name = "symbol", Order = 102)]
        public string Symbol { get; set; }

        [DataMember(Name = "tick_rule", Order = 103)]
        public string TickRule { get; set; }

        [DataMember(Name = "trading_calendar", Order = 104)]
        public string TradingCalendar { get; set; }

        [DataMember(Name = "underlying_expiry", Order = 105)]
        public DateTime? UnderlyingExpiry { get; set; }

        [DataMember(Name = "underlying_rate", Order = 106)]
        public double? UnderlyingRate { get; set; }

        [DataMember(Name = "underlying_rate_mode", Order = 107)]
        public UnderlyingRateMode? UnderlyingRateMode { get; set; }

        [DataMember(Name = "underlying_strike", Order = 108)]
        public double? UnderlyingStrike { get; set; }

        [DataMember(Name = "upper_barrier", Order = 109)]
        public double? UpperBarrier { get; set; }

        [DataMember(Name = "use_volatility_surface", Order = 110)]
        public bool? UseVolatilitySurface { get; set; }

        [DataMember(Name = "use_volatility_surface_for_quoting", Order = 111)]
        public bool? UseVolatilitySurfaceForQuoting { get; set; }

        [DataMember(Name = "valoren", Order = 112)]
        public int? Valoren { get; set; }

        [DataMember(Name = "volatility", Order = 113)]
        public double? Volatility { get; set; }

        [DataMember(Name = "volatility_askoffset", Order = 114)]
        public double? VolatilityAskOffset { get; set; }

        [DataMember(Name = "volatility_bidoffset", Order = 115)]
        public double? VolatilityBidOffset { get; set; }

        [DataMember(Name = "volatility_day_convention", Order = 116)]
        public VolatilityDayConvention? VolatilityDayConvention { get; set; }

        [DataMember(Name = "volatility_decrease_end", Order = 117)]
        public string VolatilityDecreaseEnd { get; set; }

        [DataMember(Name = "volatility_decrease_start", Order = 118)]
        public string VolatilityDecreaseStart { get; set; }

        [DataMember(Name = "volatility_time_mode", Order = 119)]
        public VolatilityTimeMode? VolatilityTimeMode { get; set; }

        [DataMember(Name = "volume_limit", Order = 120)]
        public double? VolumeLimit { get; set; }

        [DataMember(Name = "yield_name", Order = 121)]
        public string YieldName { get; set; }

        [DataMember(Name = "yield_offset", Order = 122)]
        public double? YieldOffset { get; set; }

        [DataMember(Name = "ytm_display", Order = 123)]
        public string YtmDisplay { get; set; }

        [DataMember(Name = "ytm_rateday_convention", Order = 124)]
        public DayConvention? YtmRatedayConvention { get; set; }

        [DataMember(Name = "ytm_ratetype_convention", Order = 125)]
        public DayConvention? YtmRateTypeConvention { get; set; }

    }
}
