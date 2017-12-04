using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Client
{
    /// <summary>
    /// This function calculates a stresstest matrix (scenario analysis) for a number of actions, prices and volatilities. 
    /// Note that the calculations are based on a given portfolio.
    /// </summary>
    [DataContract(Name = "STRESSTEST", Namespace = "")]
    public class StressTestMessage : ClientMessage
    {
        /// <summary>
        /// Portfolio for which the stress test is done.
        /// </summary>
        [DataMember(Name = "portfolio_name", IsRequired = true, Order = 1)]
        [StringLength(51)]
        public string PortfolioName { get; set; }

        [DataMember(Name = "actions", IsRequired = true, Order = 2)]
        public Actions Actions { get; set; }

        /// <summary>
        /// Prices to calculate for.
        /// </summary>
        [DataMember(Name = "simulated_prices", IsRequired = true, Order = 3)]
        public SimulatedPrices SimulatedPrices { get; set; }

        /// <summary>
        /// Default: Offset.
        /// </summary>
        [DataMember(Name = "simulated_price_mode", Order = 4)]
        public SimulationMode? SimulatedPriceMode { get; set; }

        /// <summary>
        /// Volatility values to calculate for.
        /// </summary>
        [DataMember(Name = "simulated_volatilities", IsRequired = true, Order = 5)]
        public SimulatedVolatilities SimulatedVolatilities { get; set; }

        /// <summary>
        /// Default: Offset.
        /// </summary>
        [DataMember(Name = "simulated_volatility_mode", Order = 6)]
        public SimulationMode? SimulatedVolatilityMode { get; set; }

        /// <summary>
        /// Offset which is added to the existing financial rate in the Orc. Default: 0.0
        /// </summary>
        [DataMember(Name = "financial_rate_offset", Order = 7)]
        public double? FinancialRateOffset { get; set; }

        /// <summary>
        /// Default: today's date.
        /// </summary>
        [DataMember(Name = "analysis_date", Order = 8)]
        public DateTime? AnalysisDate { get; set; }

        /// <summary>
        /// The name of a volatility surface. This surface will be used for all calculations for the specific stresstest. 
        /// If a surface is specified, all calculations for the stresstest will based on that surface, regardless of the underlying of the contract.
        /// </summary>
        [DataMember(Name = "volatility_surface", Order = 9)]
        public string VolatilitySurface { get; set; }

        /// <summary>
        /// Default: the underlying currency.
        /// </summary>
        [DataMember(Name = "result_currency", Order = 10)]
        [StringLength(3, MinimumLength = 3)]
        public string ResultCurrency { get; set; }

        /// <summary>
        /// Default: UnderlyingIf this is set to 'Position', the stress_matrix dictionary in the reply will group the result on contract basis and 
        /// thus return 'instrument_id' instead of 'underlying' and 'expirydate'. Note that grouping by underlying in OP is not necessarily the same 
        /// as looking at the risk underlying summary in the client, since the risk underlying is not of necessity the same as the underlying (and vice versa).
        /// </summary>
        [DataMember(Name = "group_results_by", Order = 11)]
        public GroupResultsBy? GroupResultsBy { get; set; }

        /// <summary>
        /// First expirydate to do calculations for.
        /// </summary>
        [DataMember(Name = "expirydate_start", Order = 12)]
        public DateTime? ExpirydateStart { get; set; }

        /// <summary>
        /// Last expirydate to include in the calculation.
        /// </summary>
        [DataMember(Name = "expirydate_end", Order = 13)]
        public DateTime? ExpirydateEnd { get; set; }

        /// <summary>
        /// If set, only the given underlyings will be included in the calculation.
        /// </summary>
        [DataMember(Name = "underlying_filters", Order = 14)]
        public UnderlyingFilters UnderlyingFilters { get; set; }
        /// <summary>
        /// Set this key in order to receive replies in several messages. Default behaviour is that the Orc Protocol sends all replies in one message.
        /// The recommended value for this key is 1000. If the reply is split up, this will also be indicated by the boolean flag more_replies in the reply_to dictionary.
        /// </summary>
        [DataMember(Name = "items_per_message", Order = 15)]
        public int? ItemsPerMessage { get; set; }

        public StressTestMessage() : base(MessageType.STRESSTEST)
        {
            
        }
    }
}