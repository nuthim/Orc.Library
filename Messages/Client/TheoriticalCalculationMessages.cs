using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Client
{
    /// <summary>
    /// Perform theoretical calculation on a given instrument. 
    /// <param>The asynch flag set to "true" means that the OP will continue to process requests, while the calculation is on its way. When asynch is set
    /// to "false", the OP input is blocked until the calculation is sent. With async set to "true", the overall calculation speed is significantly faster
    /// than when set to "false".  It is recommended to always use asynchronous mode for theoretical calculations. 
    /// Make sure to subscribe to relevant contracts and base contracts before sending the first theoretical calculation request.
    /// </param>
    /// </summary>
    [DataContract(Name = nameof(MessageType.THEORETICAL_CALCULATION), Namespace = "")]
    public class TheoreticalCalculationMessage : ClientMessage
    {
        [DataMember(Name = "action", IsRequired = true, Order = 1)]
        public string Action { get; set; }

        [DataMember(Name = "instrument_id", Order = 2)]
        public InstrumentId InstrumentId { get; set; }

        /// <summary>
        /// Default: today's date.
        /// </summary>
        [DataMember(Name = "analysis_date", Order = 3)]
        public DateTime? AnalysisDate { get; set; }

        /// <summary>
        /// If "true" do asynchronous calculation. Default: "false".
        /// </summary>
        [DataMember(Name = "asynch", Order = 4)]
        public bool? Asynch { get; set; }

        /// <summary>
        /// Only used for ATM Forward action. If used, do not specify InstrumentId.
        /// </summary>
        [DataMember(Name = "basecontract", Order = 5)]
        public InstrumentId BaseContract { get; set; }

        /// <summary>
        /// Default: 0.0
        /// </summary>
        [DataMember(Name = "base_ytm_offset", Order = 6)]
        public double? BaseYtmOffset { get; set; }


        [DataMember(Name = "contract_price", Order = 7)]
        public double? ContractPrice { get; set; }

        /// <summary>
        /// Used with ATM Forward, Discount Factor and Financing Rate actions. If used, do not specify InstrumentId.
        /// </summary>
        [DataMember(Name = "date", Order = 8)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Only used for ATM Forward action. If used, do not specify InstrumentId.
        /// </summary>
        [DataMember(Name = "dividendcontract", Order = 9)]
        public InstrumentId DividendContract { get; set; }

        /// <summary>
        /// Default: 0.0
        /// </summary>
        [DataMember(Name = "dividend_percentage", Order = 10)]
        public double? DividendPercentage { get; set; }

        /// <summary>
        /// Default false. If this key is set to true, you will receive a new reply to this message every time the result of the calculation changes.
        /// </summary>
        [DataMember(Name = "feed", Order = 11)]
        public bool? Feed { get; set; }

        /// <summary>
        /// The minimum time (seconds) between two feed updates.
        /// </summary>
        [DataMember(Name = "feed_minimum_hold", Order = 12)]
        public double? FeedMinimumHold { get; set; }

        /// <summary>
        /// Offset which is added to the existing financial rate in the Orc. Default: 0.0
        /// </summary>
        [DataMember(Name = "financial_rate_offset", Order = 13)]
        public double? FinancialRateOffset { get; set; }

        /// <summary>
        /// Default value is 0.
        /// </summary>
        [DataMember(Name = "portfolio_accrued", Order = 14)]
        public double? PortfolioAccrued { get; set; }

        /// <summary>
        /// Default value is 0.
        /// </summary>
        [DataMember(Name = "portfolio_change_in_accrued", Order = 15)]
        public double? PortfolioChangeInAccrued { get; set; }

        /// <summary>
        /// Default value is 0.
        /// </summary>
        [DataMember(Name = "portfolio_change_in_invested", Order = 16)]
        public double? PortfolioChangeInInvested { get; set; }

        /// <summary>
        /// Default value is 0.
        /// </summary>
        [DataMember(Name = "portfolio_change_in_volume", Order = 17)]
        public double? PortfolioChangeInVolume { get; set; }

        /// <summary>
        /// Default value is the Orc default currency for the specified instrument.
        /// </summary>
        [DataMember(Name = "portfolio_currency", Order = 18)]
        [StringLength(3, MinimumLength = 3)]
        public string PortfolioCurrency { get; set; }

        /// <summary>
        /// Default value is 0.
        /// </summary>
        [DataMember(Name = "portfolio_invested", Order = 19)]
        public double? PortfolioInvested { get; set; }

        /// <summary>
        /// Default value is 1.
        /// </summary>
        [DataMember(Name = "portfolio_volume", Order = 20)]
        public double? PortfolioVolume { get; set; }

        /// <summary>
        /// A three letter currency identifier. Default: the contract currency.
        /// </summary>
        [DataMember(Name = "result_currency", Order = 21)]
        [StringLength(3, MinimumLength = 3)]
        public string ResultCurrency { get; set; }

        /// <summary>
        /// Select a model for the calculation.
        /// </summary>
        [DataMember(Name = "simulated_model", Order = 22)]
        public string SimulatedModel { get; set; }

        /// <summary>
        /// A price to use in the calculation. Default is market price for the instrument. This is the price of the base contract. 
        /// </summary>
        [DataMember(Name = "simulated_price", Order = 23)]
        public double? SimulatedPrice { get; set; }

        /// <summary>
        /// Default: Offset. (Only used if simulated_price is set). 
        /// </summary>
        [DataMember(Name = "simulated_price_mode", Order = 24)]
        public SimulationMode? SimulatedPriceMode { get; set; }

        /// <summary>
        /// Default value is the Orc default currency for the specified instrument.
        /// </summary>
        [DataMember(Name = "simulated_price_currency", Order = 25)]
        [StringLength(3, MinimumLength = 3)]
        public string SimulatedPriceCurrency { get; set; }

        /// <summary>
        /// The strike price for simulation
        /// </summary>
        [DataMember(Name = "simulated_strikeprice", Order = 26)]
        public double? SimulatedStrikePrice { get; set; }

        /// <summary>
        /// Default: Offset. (Only used if simulated_price is set). 
        /// </summary>
        [DataMember(Name = "simulated_strikeprice_mode", Order = 27)]
        public SimulationMode? SimulatedStrikePriceMode { get; set; }

        /// <summary>
        /// A volatility to use in the calculation. Default is the volatility setting for that instrument. 
        /// Simulated volatility of e.g. 1.0 means 1.0% (if SimulatedVolatilityMode is offset).
        /// </summary>
        [DataMember(Name = "simulated_volatility", Order = 28)]
        public double? SimulatedVolatility { get; set; }

        /// <summary>
        /// Default: Offset. (Only used if SimulatedVolatility is set).
        /// </summary>
        [DataMember(Name = "simulated_volatility_mode", Order = 29)]
        public SimulationMode? SimulatedVolatilityMode { get; set; }

        /// <summary>
        /// Only used for ATM Forward action. If used, do not specify InstrumentId.
        /// </summary>
        [DataMember(Name = "underlying", Order = 30)]
        [StringLength(32)]
        public string Underlying { get; set; }

        /// <summary>
        /// The continuous return or cost of the underlying value. Default: 0.0. Only used for ATM Forward action. If used, do not specify InstrumentId.
        /// Note that the UnderlyingRate is not expressed in percent, i.e.to specify 2%, 0.02 should be entered. 
        /// </summary>
        [DataMember(Name = "underlying_rate", Order = 31)]
        public double? UnderlyingRate { get; set; }

        /// <summary>
        /// Default: Contract. Only used for ATM Forward action.If used, do not specify InstrumentId.
        /// </summary>
        [DataMember(Name = "underlying_rate_mode", Order = 32)]
        public UnderlyingRateMode? UnderlyingRateMode { get; set; }

        [DataMember(Name = "user_percentage", Order = 33)]
        public double? UserPercentage { get; set; }

        /// <summary>
        /// The name of the volatility surface. 
        /// </summary>
        [DataMember(Name = "volatility_surface", Order = 34)]
        public string VolatilitySurface { get; set; }

        /// <summary>
        /// Used together with ResultCurrency to identify a yield curve for the Discount Factor and Financing Rate actions. 
        /// Default: Default yield curve for the ResultCurrency. Note that YieldName is used only if no InstrumentId is specified, 
        /// and only for the action Discount Factor or Financing Rate. The yield curve is specified for an exact currency, and not for a specific instrument.
        /// </summary>
        [DataMember(Name = "yield_name", Order = 35)]
        [StringLength(64)]
        public string YieldName { get; set; }

        public TheoreticalCalculationMessage() : base(MessageType.THEORETICAL_CALCULATION)
        {

        }
    }


    [DataContract(Name = nameof(MessageType.THEORETICAL_CALCULATION_FEED_STOP), Namespace = "")]
    public class TheoreticalCalculationFeedStopMessage : ClientMessage
    {
        [DataMember(Name = "feed_tag", IsRequired = true)]
        public int? FeedTag { get; set; }

        public TheoreticalCalculationFeedStopMessage() : base(MessageType.THEORETICAL_CALCULATION_FEED_STOP)
        {
            
        }
    }


    /// <summary>
    /// Do theoretical calculation on a given instrument. The upper limit for group calculations is 100 actions.
    /// </summary>
    [DataContract(Name = nameof(MessageType.THEORETICAL_CALCULATION_GROUP), Namespace = "")]
    public class TheoreticalCalculationGroupMessage : ClientMessage
    {

        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "actions", IsRequired = true, Order = 2)]
        public Actions Action { get; set; }

        /// <summary>
        /// A price to use in the calculation. Default is market price for the instrument. This is the price of the base contract. 
        /// </summary>
        [DataMember(Name = "simulated_price", Order = 3)]
        public double? SimulatedPrice { get; set; }

        /// <summary>
        /// Default: Offset. (Only used if SimulatedPrice is set). 
        /// </summary>
        [DataMember(Name = "simulated_price_mode", Order = 4)]
        public SimulationMode? SimulatedPriceMode { get; set; }

        /// <summary>
        /// Default value is the Orc default currency for the specified instrument.
        /// </summary>
        [DataMember(Name = "simulated_price_currency", Order = 5)]
        [StringLength(3, MinimumLength = 3)]
        public string SimulatedPriceCurrency { get; set; }

        /// <summary>
        /// A volatility to use in the calculation. Default is the volatility setting for that instrument. 
        /// Simulated volatility of e.g. 1.0 means 1.0% (if SimulatedVolatilityMode is offset).
        /// </summary>
        [DataMember(Name = "simulated_volatility", Order = 6)]
        public double? SimulatedVolatility { get; set; }

        /// <summary>
        /// Default: Offset. (Only used if SimulatedVolatility is set).
        /// </summary>
        [DataMember(Name = "simulated_volatility_mode", Order = 7)]
        public SimulationMode? SimulatedVolatilityMode { get; set; }

        /// <summary>
        /// Select a model for the calculation
        /// </summary>
        [DataMember(Name = "simulated_model", Order = 8)]
        public string SimulatedModel { get; set; }

        /// <summary>
        /// The strike price for simulation
        /// </summary>
        [DataMember(Name = "simulated_strikeprice", Order = 9)]
        public double? SimulatedStrikePrice { get; set; }

        [DataMember(Name = "simulated_strikeprice_mode", Order = 10)]
        public SimulationMode? SimulatedStrikePriceMode { get; set; }

        /// <summary>
        /// Offset which is added to the existing financial rate in the Orc. Default: 0.0
        /// </summary>
        [DataMember(Name = "financial_rate_offset", Order = 11)]
        public double? FinancialRateOffset { get; set; }

        /// <summary>
        /// Default: 0.0
        /// </summary>
        [DataMember(Name = "base_ytm_offset", Order = 12)]
        public double? BaseYtmOffset { get; set; }

        /// <summary>
        /// Default: 0.0
        /// </summary>
        [DataMember(Name = "dividend_percentage", Order = 13)]
        public double? DividendPercentage { get; set; }

        /// <summary>
        /// Default: today's date.
        /// </summary>
        [DataMember(Name = "analysis_date", Order = 14)]
        public DateTime? AnalysisDate { get; set; }

        /// <summary>
        /// The name of a volatility surface. 
        /// </summary>
        [DataMember(Name = "volatility_surface", Order = 15)]
        public string VolatilitySurface { get; set; }

        /// <summary>
        /// Price of the instrument to use in calculations. Used for example for implied volatility.
        /// </summary>
        [DataMember(Name = "contract_price", Order = 16)]
        public double? ContractPrice { get; set; }

        [DataMember(Name = "user_percentage", Order = 17)]
        public double? UserPercentage { get; set; }

        /// <summary>
        /// A three letter currency identifier. Default: the contract currency.
        /// </summary>
        [DataMember(Name = "result_currency", Order = 18)]
        [StringLength(3, MinimumLength = 3)]
        public string ResultCurrency { get; set; }

        /// <summary>
        /// If "true" do asynchronous calculation. Default: "false".
        /// </summary>
        [DataMember(Name = "asynch", Order = 19)]
        public bool? Asynch { get; set; }

        /// <summary>
        /// Default false. If this key is set to true, you will receive a new reply to this message every time the result of the calculation changes.
        /// </summary>
        [DataMember(Name = "feed", Order = 20)]
        public bool? Feed { get; set; }

        /// <summary>
        /// The minimum time (seconds) between two feed updates.
        /// </summary>
        [DataMember(Name = "feed_minimum_hold", Order = 21)]
        public double? FeedMinimumHold { get; set; }

        /// <summary>
        /// Default value is 1.
        /// </summary>
        [DataMember(Name = "portfolio_volume", Order = 22)]
        public double? PortfolioVolume { get; set; }

        /// <summary>
        /// Default value is 0.
        /// </summary>
        [DataMember(Name = "portfolio_accrued", Order = 23)]
        public double? PortfolioAccrued { get; set; }

        /// <summary>
        /// Default value is 0.
        /// </summary>
        [DataMember(Name = "portfolio_invested", Order = 24)]
        public double? PortfolioInvested { get; set; }

        /// <summary>
        /// Default value is the Orc default currency for the specified instrument.
        /// </summary>
        [DataMember(Name = "portfolio_currency", Order = 25)]
        [StringLength(3, MinimumLength = 3)]
        public string PortfolioCurrency { get; set; }

        /// <summary>
        /// Default value is 0.
        /// </summary>
        [DataMember(Name = "portfolio_change_in_accrued", Order = 26)]
        public double? PortfolioChangeInAccrued { get; set; }

        /// <summary>
        /// Default value is 0.
        /// </summary>
        [DataMember(Name = "portfolio_change_in_invested", Order = 27)]
        public double? PortfolioChangeInInvested { get; set; }

        /// <summary>
        /// Default value is 0.
        /// </summary>
        [DataMember(Name = "portfolio_change_in_volume", Order = 28)]
        public double? PortfolioChangeInVolume { get; set; }


        public TheoreticalCalculationGroupMessage() : base(MessageType.THEORETICAL_CALCULATION_GROUP)
        {

        }
    }

}
