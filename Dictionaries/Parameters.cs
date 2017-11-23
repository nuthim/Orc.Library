using Orc.Library.Enums;
using System;
using System.Runtime.Serialization;


namespace Orc.Library.Dictionaries
{
    [DataContract(Name = "parameters", Namespace = "")]
    public class Parameters
    {
        [DataMember(Name = "accrued_rateday_convention")]
        public DayConvention? AccruedRatedayConvention { get; set; }

        [DataMember(Name = "apply_baseoffset_logic")]
        public ApplyBaseOffsetLogic? ApplyBaseOffsetLogic { get; set; }

        [DataMember(Name = "askbaseoffset")]
        public double? AskBaseOffset { get; set; }

        [DataMember(Name = "askoffset")]
        public double? AskOffset { get; set; }

        [DataMember(Name = "askrateoffset")]
        public double? AskRateOffset { get; set; }

        [DataMember(Name = "auto_diming_ask_flag")]
        public bool? AutoDimingAskFlag { get; set; }

        [DataMember(Name = "auto_diming_bid_flag")]
        public bool? AutoDimingBidFlag { get; set; }

        [DataMember(Name = "auto_hedging_ask_flag")]
        public bool? AutoHedgingAskFlag { get; set; }

        [DataMember(Name = "auto_hedging_bid_flag")]
        public bool? AutoHedgingBidFlag { get; set; }

        [DataMember(Name = "auto_mass_quote_ask_flag")]
        public bool? AutoMassQuoteAskFlag { get; set; }

        [DataMember(Name = "auto_mass_quote_bid_flag")]
        public bool? AutoMassQuoteBidFlag { get; set; }

        [DataMember(Name = "auto_quote_flag")]
        public bool? AutoQuoteFlag { get; set; }

        [DataMember(Name = "auto_responding_ask_flag")]
        public bool? AutoRespondingAskFlag { get; set; }

        [DataMember(Name = "auto_responding_bid_flag")]
        public bool? AutoRespondingBidFlag { get; set; }

        [DataMember(Name = "auto_traded_allowed_volume")]
        public double? AutoTradedAllowedVolume { get; set; }

        [DataMember(Name = "auto_traded_volume_ask")]
        public double? AutoTradedVolumeAsk { get; set; }

        [DataMember(Name = "auto_traded_volume_bid")]
        public double? AutoTradedVolumeBid { get; set; }

        [DataMember(Name = "auto_trading_ask_flag")]
        public bool? AutoTradingAskFlag { get; set; }

        [DataMember(Name = "auto_trading_bid_flag")]
        public bool? AutoTradingBidFlag { get; set; }

        [DataMember(Name = "barrier")]
        public double? Barrier { get; set; }

        [DataMember(Name = "base_price_multiplier")]
        public double? BasePriceMultiplier { get; set; }

        [DataMember(Name = "basecontract")]
        public InstrumentId BaseContract { get; set; }

        [DataMember(Name = "baseoffset]")]
        public double? BaseOffset { get; set; }

        [DataMember(Name = "bidbaseoffset")]
        public double? BidBaseOffset { get; set; }

        [DataMember(Name = "bidoffset")]
        public double? BidOffset { get; set; }

        [DataMember(Name = "bidrateoffset")]
        public double? BidRateOffset { get; set; }

        [DataMember(Name = "cficode")]
        public string Cficode { get; set; }

        [DataMember(Name = "components")]
        public Components Components { get; set; }

        [DataMember(Name = "convertible_from")]
        public DateTime? ConvertibleFrom { get; set; }

        [DataMember(Name = "cusip")]
        public string Cusip { get; set; }

        [DataMember(Name = "custom_tick_size")]
        public double? CustomTickSize { get; set; }

        [DataMember(Name = "custom_lot_size")]
        public double? CustomLotSize { get; set; }

        [DataMember(Name = "custom_min_volume")]
        public double? CustomMinVolume { get; set; }

        [DataMember(Name = "custom_volume_step")]
        public double? CustomVolumeStep { get; set; }

        [DataMember(Name = "customer_unique_id")]
        public string CustomerUniqueId { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "dividendcontract")]
        public InstrumentId DividendContract { get; set; }

        [DataMember(Name = "divs_est_net")]
        public double? DivsEstNet { get; set; }

        [DataMember(Name = "divs_paid_to_holder")]
        public double? DivsPaidToHolder { get; set; }

        [DataMember(Name = "dynamic_parameters")]
        public DynamicParameters DynamicParameters { get; set; }

        [DataMember(Name = "end_date")]
        public DateTime? EndDate { get; set; }

        [DataMember(Name = "enforced_customer_unique_id")]
        public string EnforcedCustomerUniqueId { get; set; }

        [DataMember(Name = "exchange")]
        public string Exchange { get; set; }

        [DataMember(Name = "expirytime")]
        public string ExpiryTime { get; set; }

        [DataMember(Name = "feedcode")]
        public string FeedCode { get; set; }

        [DataMember(Name = "final_settlement_days")]
        public int? FinalSettlementDays { get; set; }

        [DataMember(Name = "fixed_fx_rate")]
        public double? FixedFxRate { get; set; }

        [DataMember(Name = "frn_spread")]
        public double? FrnSpread { get; set; }

        [DataMember(Name = "fx_spot_correlation")]
        public double? FxSpotCorrelation { get; set; }

        [DataMember(Name = "fx_volatility")]
        public double? FxVolatility { get; set; }

        [DataMember(Name = "hedgecontract")]
        public InstrumentId HedgeContract { get; set; }

        [DataMember(Name = "instrument_subtype")]
        public int? InstrumentSubtype { get; set; }

        [DataMember(Name = "is_clean_quoted")]
        public bool? IsCleanQuoted { get; set; }

        [DataMember(Name = "isincode")]
        public string IsinCode { get; set; }

        [DataMember(Name = "issuer")]
        public string Issuer { get; set; }

        [DataMember(Name = "is_consolidated_contract")]
        public bool? IsConsolidatedContract { get; set; }

        [DataMember(Name = "is_ytm_quoted")]
        public bool? IsYtmQuoted { get; set; }

        [DataMember(Name = "is_ytm_strike")]
        public bool? IsYtmStrike { get; set; }

        [DataMember(Name = "lower_barrier")]
        public double? LowerBarrier { get; set; }

        [DataMember(Name = "market")]
        public string Market { get; set; }

        [DataMember(Name = "marketcontracts")]
        public MarketContracts MarketContracts { get; set; }

        [DataMember(Name = "mic")]
        public string Mic { get; set; }

        [DataMember(Name = "model")]
        public string Model { get; set; }

        [DataMember(Name = "note_option_multiplier")]
        public double? note_option_multiplier { get; set; }

        [DataMember(Name = "period_length")]
        public int? PeriodLength { get; set; }

        [DataMember(Name = "premium_payment_at_expiry")]
        public bool? PremiumPaymentAtExpiry { get; set; }

        [DataMember(Name = "premium_payment_future")]
        public bool? PremiumPaymentFuture { get; set; }

        [DataMember(Name = "price_display")]
        public string PriceDisplay { get; set; }

        [DataMember(Name = "price_multiplier")]
        public double? PriceMultiplier { get; set; }

        [DataMember(Name = "quote_volatility_surface")]
        public string QuoteVolatilitySurface { get; set; }

        [DataMember(Name = "quotelot_multiplier")]
        public double? QuoteLotMultiplier { get; set; }

        [DataMember(Name = "quotevolatility")]
        public double? QuoteVolatility { get; set; }

        [DataMember(Name = "quotevolatility_askoffset")]
        public double? QuoteVolatilityAskOffset { get; set; }

        [DataMember(Name = "quotevolatility_bidoffset")]
        public double? QuoteVolatilityBidOffset { get; set; }

        [DataMember(Name = "quote_askbaseoffset")]
        public double? QuoteAskBaseOffset { get; set; }

        [DataMember(Name = "quote_askoffset")]
        public double? QuoteAskOffset { get; set; }

        [DataMember(Name = "quote_bidbaseoffset")]
        public double? QuoteBidBaseOffset { get; set; }

        [DataMember(Name = "quote_bidoffset")]
        public double? QuoteBidOffset { get; set; }

        [DataMember(Name = "quote_traded_allowed_volume")]
        public double? QuoteTradedAllowedVolume { get; set; }

        [DataMember(Name = "quote_traded_volume_ask")]
        public double? QuoteTradedVolumeAsk { get; set; }

        [DataMember(Name = "quote_traded_volume_bid")]
        public double? QuoteTradedVolumeBid { get; set; }

        [DataMember(Name = "quote_volume_ask")]
        public double? QuoteVolumeAsk { get; set; }

        [DataMember(Name = "quote_volume_bid")]
        public double? QuoteVolumeBid { get; set; }

        [DataMember(Name = "rebate")]
        public double? Rebate { get; set; }

        [DataMember(Name = "redemption")]
        public double? Redemption { get; set; }

        [DataMember(Name = "risk_volatility_surface")]
        public string RiskVolatilitySurface { get; set; }

        [DataMember(Name = "riskcontract")]
        public InstrumentId RiskContract { get; set; }

        [DataMember(Name = "sedol")]
        public string Sedol { get; set; }

        [DataMember(Name = "settlement_calendar")]
        public string SettlementCalendar { get; set; }

        [DataMember(Name = "settlement_days")]
        public int? SettlementDays { get; set; }

        [DataMember(Name = "settlement_style")]
        public SettlementStyle? SettlementStyle { get; set; }

        [DataMember(Name = "spread")]
        public double? Spread { get; set; }

        [DataMember(Name = "spread_bias")]
        public double? SpreadBias { get; set; }

        [DataMember(Name = "spread_table")]
        public SpreadTable? SpreadTable { get; set; }

        [DataMember(Name = "start_date")]
        public DateTime? StartDate { get; set; }

        [DataMember(Name = "strike_currency")]
        public string StrikeCurrency { get; set; }

        [DataMember(Name = "strike_yield_name")]
        public string StrikeYieldName { get; set; }

        [DataMember(Name = "submarket")]
        public string Submarket { get; set; }

        [DataMember(Name = "suggest_logic")]
        public SuggestLogic? SuggestLogic { get; set; }

        [DataMember(Name = "suggest_volume_logic")]
        public SuggestLogic? SuggestVolumeLogic { get; set; }

        [DataMember(Name = "suggest_volume_min")]
        public double? SuggestVolumeMin { get; set; }

        [DataMember(Name = "symbol")]
        public string Symbol { get; set; }

        [DataMember(Name = "tick_rule")]
        public string TickRule { get; set; }

        [DataMember(Name = "trading_calendar")]
        public string TradingCalendar { get; set; }

        [DataMember(Name = "underlying_expiry")]
        public DateTime? UnderlyingExpiry { get; set; }

        [DataMember(Name = "underlying_rate")]
        public double? UnderlyingRate { get; set; }

        [DataMember(Name = "underlying_rate_mode")]
        public UnderlyingRateMode? UnderlyingRateMode { get; set; }

        [DataMember(Name = "underlying_strike")]
        public double? UnderlyingStrike { get; set; }

        [DataMember(Name = "upper_barrier")]
        public double? UpperBarrier { get; set; }

        [DataMember(Name = "use_volatility_surface")]
        public bool? UseVolatilitySurface { get; set; }

        [DataMember(Name = "use_volatility_surface_for_quoting")]
        public bool? UseVolatilitySurfaceForQuoting { get; set; }

        [DataMember(Name = "valoren")]
        public int? Valoren { get; set; }

        [DataMember(Name = "volatility")]
        public double? Volatility { get; set; }

        [DataMember(Name = "volatility_askoffset")]
        public double? VolatilityAskOffset { get; set; }

        [DataMember(Name = "volatility_bidoffset")]
        public double? VolatilityBidOffset { get; set; }

        [DataMember(Name = "volatility_day_convention")]
        public VolatilityDayConvention? VolatilityDayConvention { get; set; }

        [DataMember(Name = "volatility_decrease_end")]
        public string VolatilityDecreaseEnd { get; set; }

        [DataMember(Name = "volatility_decrease_start")]
        public string VolatilityDecreaseStart { get; set; }

        [DataMember(Name = "volatility_time_mode")]
        public VolatilityTimeMode? VolatilityTimeMode { get; set; }

        [DataMember(Name = "volume_limit")]
        public double? VolumeLimit { get; set; }

        [DataMember(Name = "yield_name")]
        public string YieldName { get; set; }

        [DataMember(Name = "yield_offset")]
        public double? YieldOffset { get; set; }

        [DataMember(Name = "ytm_display")]
        public string YtmDisplay { get; set; }

        [DataMember(Name = "ytm_rateday_convention")]
        public DayConvention? YtmRatedayConvention { get; set; }

        [DataMember(Name = "ytm_ratetype_convention")]
        public DayConvention? YtmRateTypeConvention { get; set; }

    }
}
