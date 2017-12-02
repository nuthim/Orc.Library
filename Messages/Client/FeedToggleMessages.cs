using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;


namespace Orc.Library.Messages.Client
{
    /// <summary>
    /// A marker for subscription types
    /// </summary>
    public interface ISubscriptionMessage
    {
        bool? Enable { get; set; }
    }

    /// <summary>
    /// Toggle dividend feed on or off.
    /// </summary>
    [DataContract(Name = "DIVIDEND_FEED_TOGGLE", Namespace = "")]
    public class DividendFeedToggleMessage : ClientMessage, ISubscriptionMessage
    {
        [DataMember(Name = "toggle", IsRequired = true, Order = 1)]
        public bool? Enable { get; set; }

        /// <summary>
        /// Market to receive dividend feed from
        /// </summary>
        [DataMember(Name = "market", Order = 2)]
        public string Market { get; set; }

        public DividendFeedToggleMessage() : base(MessageType.DIVIDEND_FEED_TOGGLE)
        {

        }
    }

    /// <summary>
    /// Toggle instrument feed on or off.
    /// <para>You will receive feed on instruments that matches the combination of the instruments (or the regular expressions of instruments) in the 
    /// dictionary instrument_list and the other keys listed in the table below. If you send several instrument_feed_toggle messages, 
    /// you will receive instrument feeds according to all filters(logically OR, i.e.filter1 OR filter2 OR...)
    /// </para>
    /// </summary>
    [DataContract(Name = "INSTRUMENT_FEED_TOGGLE", Namespace = "")]
    public class InstrumentFeedToggleMessage : ClientMessage, ISubscriptionMessage
    {
        [DataMember(Name = "toggle", IsRequired = true, Order = 1)]
        public bool? Enable { get; set; }

        /// <summary>
        /// This key enables selective download of instruments of one asset type.
        /// </summary>
        [DataMember(Name = "assettype", Order = 2)]
        public AssetType? AssetType { get; set; }

        /// <summary>
        /// Tag of basecontract to match.
        /// </summary>
        [DataMember(Name = "basecontract", Order = 3)]
        public int? BaseContract { get; set; }

        /// <summary>
        /// This key enables selective download of instruments of one currency.
        /// </summary>
        [DataMember(Name = "currency", Order = 4)]
        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; }

        [DataMember(Name = "customer_unique_id", Order = 5)]
        [StringLength(64)]
        public string CustomerUniqueIdPattern { get; set; }

        [DataMember(Name = "enforced_customer_unique_id", Order = 6)]
        public string EnforcedCustomerUniqueIdPattern { get; set; }

        /// <summary>
        /// First expirydate to match
        /// </summary>
        [DataMember(Name = "expirydate_start", Order = 7)]
        public DateTime? ExpirydateStart { get; set; }

        /// <summary>
        /// Last expirydate to match
        /// </summary>
        [DataMember(Name = "expirydate_end", Order = 8)]
        public DateTime? ExpirydateEnd { get; set; }

        [DataMember(Name = "feedcode", Order = 9)]
        [StringLength(32)]
        public string Feedcode { get; set; }

        /// <summary>
        /// Set this key to "true" in order to download instruments ignoring the case for the string based keys. Default is "false".
        /// </summary>
        [DataMember(Name = "ignore_case", Order = 10)]
        public bool? IgnoreCase { get; set; }

        [DataMember(Name = "instrument_list", Order = 11)]
        public InstrumentList instrument_list { get; set; }

        [DataMember(Name = "isincode", Order = 12)]
        [StringLength(16)]
        public string IsinCodePattern { get; set; }

        [DataMember(Name = "symbol", Order = 13)]
        [StringLength(32)]
        public string Symbol { get; set; }

        /// <summary>
        /// Reuters Exchange Mnemonic.
        /// </summary>
        [DataMember(Name = "exchange", Order = 14)]
        [StringLength(3, MinimumLength = 3)]
        public string Exchange { get; set; }

        [DataMember(Name = "issuer", Order = 15)]
        public string Issuer { get; set; }

        [DataMember(Name = "kind", Order = 16)]
        public string Kind { get; set; }

        [DataMember(Name = "market", Order = 17)]
        public string Market { get; set; }

        /// <summary>
        /// Min strikeprice to match
        /// </summary>
        [DataMember(Name = "strikeprice_min", Order = 18)]
        public double? StrikePriceMin { get; set; }

        /// <summary>
        /// Max strikeprice to match
        /// </summary>
        [DataMember(Name = "strikeprice_max", Order = 19)]
        public double? StrikePriceMax { get; set; }

        /// <summary>
        /// Applicable on markets with submarkets. Use this key to limit the downloaded information to only one submarket.
        /// </summary>
        [DataMember(Name = "submarket", Order = 20)]
        public string SubMarket { get; set; }

        /// <summary>
        /// The name of a tick rule.
        /// </summary>
        [DataMember(Name = "tick_rule", Order = 21)]
        public string TickRule { get; set; }

        [DataMember(Name = "underlying", Order = 22)]
        [StringLength(32)]
        public string UnderlyingPattern { get; set; }

        /// <summary>
        /// To only include instruments that have been created or modified within the specified time period.
        /// _to defaults to now and _from defaults to include the first created instrument.
        /// </summary>
        [DataMember(Name = "date_changed_from", Order = 23)]
        public DateTime? DateChangedFrom { get; set; }

        [DataMember(Name = "date_changed_to", Order = 24)]
        public DateTime? DateChangedTo { get; set; }

        [DataMember(Name = "time_changed_from", Order = 25)]
        public TimeSpan? TimeChangedFrom { get; set; }

        [DataMember(Name = "time_changed_to", Order = 26)]
        public TimeSpan? TimeChangedTo { get; set; }

        public InstrumentFeedToggleMessage() : base(MessageType.INSTRUMENT_FEED_TOGGLE)
        {

        }
    }

    /// <summary>
    /// Set toggle to on in order to turn on the asynchronous MARKET_STATUS feed. This message will provide information on market status, e.g.connected markets.
    /// If you switch on the market status feed for a specific market, this feed can only be switched off by specifying that market
    /// </summary>
    [DataContract(Name = "MARKET_STATUS_TOGGLE", Namespace = "")]
    public class MarketStatusFeedToggleMessage : ClientMessage, ISubscriptionMessage
    {
        [DataMember(Name = "toggle", IsRequired = true, Order = 1)]
        public bool? Enable { get; set; }

        /// <summary>
        /// Market to receive dividend feed from
        /// </summary>
        [DataMember(Name = "market", Order = 2)]
        public string Market { get; set; }

        public MarketStatusFeedToggleMessage() : base(MessageType.MARKET_STATUS_TOGGLE)
        {

        }
    }

    /// <summary>
    /// Get a feed of bookkeeping transactions.
    /// </summary>
    [DataContract(Name = "MONEY_FEED_TOGGLE", Namespace = "")]
    public class MoneyFeedToggleMessage : ClientMessage, ISubscriptionMessage
    {
        [DataMember(Name = "toggle", IsRequired = true)]
        public bool? Enable { get; set; }

        public MoneyFeedToggleMessage() : base(MessageType.MONEY_FEED_TOGGLE)
        {

        }
    }

    /// <summary>
    /// Set toggle to "true" in order to turn on the asynchronous NEWS_FEED messages. This is information originating from SFC.
    /// </summary>
    [DataContract(Name = "NEWS_FEED_TOGGLE", Namespace = "")]
    public class NewsFeedToggleMessage : ClientMessage, ISubscriptionMessage
    {
        [DataMember(Name = "toggle", IsRequired = true)]
        public bool? Enable { get; set; }

        public NewsFeedToggleMessage() : base(MessageType.NEWS_FEED_TOGGLE)
        {

        }
    }

    /// <summary>
    /// Toggle order depth feed.
    /// </summary>
    [DataContract(Name = "ORDER_DEPTH_FEED_TOGGLE", Namespace = "")]
    public class OrderDepthFeedToggleMessage : ClientMessage, ISubscriptionMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "toggle", IsRequired = true, Order = 2)]
        public bool? Enable { get; set; }

        /// <summary>
        /// Set this to "true" in order to receive full depth. Full depth is configurable and defaults to 20, instead of a 
        /// depth of 5 levels for the specified instrument.Default is "false".
        /// </summary>
        [DataMember(Name = "full_depth", Order = 3)]
        public bool? FullDepth { get; set; }

        public OrderDepthFeedToggleMessage() : base(MessageType.ORDER_DEPTH_FEED_TOGGLE)
        {

        }
    }

    /// <summary>
    /// Toggle order feed. Note that filters are combined with logic OR.
    /// </summary>
    [DataContract(Name = "ORDER_FEED_TOGGLE", Namespace = "")]
    public class OrderFeedToggleMessage : ClientMessage, ISubscriptionMessage
    {
        [DataMember(Name = "toggle", IsRequired = true, Order = 1)]
        public bool? Enable { get; set; }

        /// <summary>
        /// Several values may be specified as a comma-separated list.
        /// </summary>
        [DataMember(Name = "originator", Order = 2)]
        [StringLength(64)]
        public string Originator { get; set; }

        /// <summary>
        /// The name of the portfolio in the Orc.
        /// </summary>
        [DataMember(Name = "portfolio", Order = 3)]
        public string Portfolio { get; set; }

        /// <summary>
        /// Specifies to which customer the order belongs.
        /// </summary>
        [DataMember(Name = "customer_id", Order = 4)]
        [StringLength(64)]
        public string CustomerId { get; set; }

        [DataMember(Name = "market", Order = 5)]
        public string Market { get; set; }

        [DataMember(Name = "origin", Order = 6)]
        public Origin? Origin { get; set; }

        public OrderFeedToggleMessage() : base(MessageType.ORDER_FEED_TOGGLE)
        {

        }
    }


    /// <summary>
    /// Toggle portfolio position feed.
    /// </summary>
    [DataContract(Name = "PORTFOLIO_POSITION_FEED_TOGGLE", Namespace = "")]
    public class PortfolioPositionFeedToggleMessage : ClientMessage, ISubscriptionMessage
    {
        [DataMember(Name = "toggle", IsRequired = true, Order = 1)]
        public bool? Enable { get; set; }

        /// <summary>
        /// The name of the portfolio in the Orc. When specified, you will receive on that portfolio. Note that summation portfolios are not supported by this message.
        /// </summary>
        [DataMember(Name = "portfolio_name", Order = 2)]
        public string Portfolio { get; set; }

        public PortfolioPositionFeedToggleMessage() : base(MessageType.PORTFOLIO_POSITION_FEED_TOGGLE)
        {

        }
    }

    /// <summary>
    /// Toggle portfolio reset feed in order to allow information about performed portfolio resets to be sent to subscribed users.
    /// </summary>
    [DataContract(Name = "PORTFOLIO_RESET_FEED_TOGGLE", Namespace = "")]
    public class PortfolioResetFeedToggleMessage : ClientMessage, ISubscriptionMessage
    {
        /// <summary>
        /// The name of the portfolio in the Orc. When specified, you will receive on that portfolio. Note that summation portfolios are not supported by this message.
        /// </summary>
        [DataMember(Name = "portfolio", Order = 1)]
        [StringLength(64)]
        public string Portfolio { get; set; }

        [DataMember(Name = "toggle", IsRequired = true, Order = 2)]
        public bool? Enable { get; set; }

        public PortfolioResetFeedToggleMessage() : base(MessageType.PORTFOLIO_RESET_FEED_TOGGLE)
        {

        }
    }

    /// <summary>
    /// Toggle price feed. You can also get a snapshot of the market data, without turning on the price feed. This is done with the <see cref="PriceGetMessage"/> message.
    /// </summary>
    [DataContract(Name = "PRICEFEED_TOGGLE", Namespace = "")]
    public class PriceFeedToggleMessage : ClientMessage, ISubscriptionMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "toggle", IsRequired = true, Order = 2)]
        public bool? Enable { get; set; }

        /// <summary>
        /// Set this to true" in order to receive three separate price feeds: BEST_PRICE_FEED, STATISTICS_FEED, CONTRACT_STATUS_FEED
        /// </summary>
        [DataMember(Name = "separate_feed", Order = 3)]
        public bool? SeparateFeed { get; set; }

        /// <summary>
        /// These flags can be used in order to receive one or more feeds separately. 
        /// When at least one of these keys are set to true, the separate_feed key will not apply.
        /// </summary>
        [DataMember(Name = "best_only", Order = 4)]
        public bool? BestOnly { get; set; }

        [DataMember(Name = "statistics_only", Order = 5)]
        public bool? StatisticsOnly { get; set; }

        [DataMember(Name = "status_only", Order = 6)]
        public bool? StatusOnly { get; set; }

        /// <summary>
        /// Set this to true in order to receive market specific data
        /// </summary>
        [DataMember(Name = "market_specific_only", Order = 7)]
        public bool? MarketSpecificOnly { get; set; }

        public PriceFeedToggleMessage() : base(MessageType.PRICEFEED_TOGGLE)
        {

        }
    }

    /// <summary>
    /// Toggle quoted feed. When enabled, you will receive asynchronous QUOTED_FEED messages for all the quotations that are sent to the
    /// market by the specific Orc client that is connected to the OP(and to the market).
    /// </summary>
    [DataContract(Name = "QUOTEDFEED_TOGGLE", Namespace = "")]
    public class QuoteFeedToggleMessage : ClientMessage, ISubscriptionMessage
    {
        [DataMember(Name = "toggle", IsRequired = true, Order = 1)]
        public bool? Enable { get; set; }

        /// <summary>
        /// Market to receive quote feed from
        /// </summary>
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 2)]
        public InstrumentId InstrumentId { get; set; }

        public QuoteFeedToggleMessage() : base(MessageType.QUOTEDFEED_TOGGLE)
        {

        }
    }

    /// <summary>
    /// Toggle quote request feed.
    /// <para>In order to receive quote requests, you need to check Accept price feed in the Server Links panel for the Orc Protocol in the 
    /// Orc Trader when logging in to the Orc Protocol.
    /// </para>
    /// </summary>
    [DataContract(Name = "QUOTE_REQUEST_FEED_TOGGLE", Namespace = "")]
    public class QuoteRequestFeedToggleMessage : ClientMessage, ISubscriptionMessage
    {
        [DataMember(Name = "toggle", IsRequired = true, Order = 1)]
        public bool? Enable { get; set; }

        [DataMember(Name = "market", IsRequired = true, Order = 2)]
        public string Market { get; set; }

        public QuoteRequestFeedToggleMessage() : base(MessageType.QUOTE_REQUEST_FEED_TOGGLE)
        {

        }
    }

    /// <summary>
    /// Toggle reference price feed.
    /// </summary>
    [DataContract(Name = "REFERENCE_PRICE_FEED_TOGGLE", Namespace = "")]
    public class ReferencePriceFeedToggleMessage : ClientMessage, ISubscriptionMessage
    {
        [DataMember(Name = "toggle", IsRequired = true)]
        public bool? Enable { get; set; }

        public ReferencePriceFeedToggleMessage() : base(MessageType.REFERENCE_PRICE_FEED_TOGGLE)
        {

        }
    }

    /// <summary>
    /// Toggle spread table feed.
    /// </summary>
    [DataContract(Name = "SPREADTABLE_FEED_TOGGLE", Namespace = "")]
    public class SpreadTableFeedToggleMessage : ClientMessage, ISubscriptionMessage
    {
        [DataMember(Name = "toggle", IsRequired = true)]
        public bool? Enable { get; set; }

        public SpreadTableFeedToggleMessage() : base(MessageType.SPREADTABLE_FEED_TOGGLE)
        {

        }
    }

    /// <summary>
    /// Toggle text ticker feed.
    /// </summary>
    [DataContract(Name = "TEXT_TICKER_FEED_TOGGLE", Namespace = "")]
    public class TextTickerFeedToggleMessage : ClientMessage, ISubscriptionMessage
    {
        [DataMember(Name = "toggle", IsRequired = true)]
        public bool? Enable { get; set; }

        public TextTickerFeedToggleMessage() : base(MessageType.TEXT_TICKER_FEED_TOGGLE)
        {

        }
    }

    /// <summary>
    /// Toggle trade ticker feed with filter for one of underlying, kind or instrument_id.
    /// </summary>
    [DataContract(Name = "TRADETICKER_TOGGLE", Namespace = "")]
    public class TradeTickerToggleMessage : ClientMessage, ISubscriptionMessage
    {
        [DataMember(Name = "underlying", Order = 1)]
        [StringLength(32)]
        public string Underlying { get; set; }

        [DataMember(Name = "kind", Order = 2)]
        public string Kind { get; set; }

        [DataMember(Name = "instrument_id", Order = 3)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "toggle", IsRequired = true, Order = 4)]
        public bool? Enable { get; set; }

        public TradeTickerToggleMessage() : base(MessageType.TRADETICKER_TOGGLE)
        {

        }
    }


    /// <summary>
    /// Toggle trade feed.
    /// </summary>
    [DataContract(Name = "TRADE_FEED_TOGGLE", Namespace = "")]
    public class TradeFeedToggleMessage : ClientMessage, ISubscriptionMessage
    {
        [DataMember(Name = "toggle", IsRequired = true, Order = 1)]
        public bool? Enable { get; set; }

        /// <summary>
        /// You can specify a market to receive trade feed from.
        /// </summary>
        [DataMember(Name = "market", Order = 2)]
        public string Market { get; set; }

        /// <summary>
        /// Several values may be specified as a comma-separated list.
        /// </summary>
        [DataMember(Name = "originator", Order = 3)]
        [StringLength(64)]
        public string Originator { get; set; }

        /// <summary>
        /// The name of the portfolio (not a summation portfolio) in the Orc.
        /// </summary>
        [DataMember(Name = "portfolio", Order = 4)]
        public string Portfolio { get; set; }

        /// <summary>
        /// Specifies to which customer the order belongs.
        /// </summary>
        [DataMember(Name = "customer_id", Order = 5)]
        [StringLength(64)]
        public string CustomerId { get; set; }

        [DataMember(Name = "origin", Order = 6)]
        public Origin? Origin { get; set; }

        public TradeFeedToggleMessage() : base(MessageType.TRADE_FEED_TOGGLE)
        {

        }
    }

    /// <summary>
    /// Toggle underlying feed.
    /// </summary>
    [DataContract(Name = "UNDERLYING_FEED_TOGGLE", Namespace = "")]
    public class UnderlyingFeedToggleMessage : ClientMessage, ISubscriptionMessage
    {
        [DataMember(Name = "toggle", IsRequired = true)]
        public bool? Enable { get; set; }

        public UnderlyingFeedToggleMessage() : base(MessageType.UNDERLYING_FEED_TOGGLE)
        {

        }
    }

    /// <summary>
    /// Toggle underlying rate curve feed.
    /// </summary>
    [DataContract(Name = "UNDERLYING_RATECURVE_FEED_TOGGLE", Namespace = "")]
    public class UnderlyingRateCurveFeedToggleMessage : ClientMessage, ISubscriptionMessage
    {
        [DataMember(Name = "toggle", IsRequired = true)]
        public bool? Enable { get; set; }

        public UnderlyingRateCurveFeedToggleMessage() : base(MessageType.UNDERLYING_RATECURVE_FEED_TOGGLE)
        {

        }
    }

    /// <summary>
    /// Toggle volatility raw surface feed.
    /// </summary>
    [DataContract(Name = "VOLATILITY_RAW_SURFACE_FEED_TOGGLE", Namespace = "")]
    public class VolatilifyRawSurfaceFeedToggleMessage : ClientMessage, ISubscriptionMessage
    {
        [DataMember(Name = "toggle", IsRequired = true, Order = 1)]
        public bool? Enable { get; set; }

        /// <summary>
        /// Default "true". Set this key to "false" in order to remove unassociated underlyings from the reference_price_entries_per_underlying dictionary.
        /// </summary>
        [DataMember(Name = "all_ref_prices", Order = 2)]
        public bool? AllRefPrices { get; set; }

        public VolatilifyRawSurfaceFeedToggleMessage() : base(MessageType.VOLATILITY_RAW_SURFACE_FEED_TOGGLE)
        {

        }
    }

    /// <summary>
    /// Toggle yield curve feed.
    /// </summary>
    [DataContract(Name = "YIELD_CURVE_FEED_TOGGLE", Namespace = "")]
    public class YieldRateCurveFeedToggleMessage : ClientMessage, ISubscriptionMessage
    {
        [DataMember(Name = "toggle", IsRequired = true)]
        public bool? Enable { get; set; }

        public YieldRateCurveFeedToggleMessage() : base(MessageType.YIELD_CURVE_FEED_TOGGLE)
        {

        }
    }
}
