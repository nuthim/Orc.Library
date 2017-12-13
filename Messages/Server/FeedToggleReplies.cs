using System;
using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;


namespace Orc.Library.Messages.Server
{
    [DataContract(Name = nameof(MessageType.DIVIDEND_FEED_TOGGLE), Namespace = "")]
    public class DividendFeedToggleReply : ServerMessage
    {
        [DataMember(Name = "toggle", Order = 1)]
        public bool? Toggle { get; set; }

        [DataMember(Name = "market", Order = 2)]
        public string Market { get; set; }
    }


    [DataContract(Name = nameof(MessageType.INSTRUMENT_FEED_TOGGLE), Namespace = "")]
    public class InstrumentFeedToggleReply : ServerMessage
    {
        [DataMember(Name = "toggle", Order = 1)]
        public bool? Toggle { get; set; }

        [DataMember(Name = "assettype", Order = 2)]
        public AssetType? AssetType { get; set; }

        [DataMember(Name = "basecontract", Order = 3)]
        public int? BaseContract { get; set; }

        [DataMember(Name = "currency", Order = 4)]
        public string Currency { get; set; }

        [DataMember(Name = "customer_unique_id", Order = 5)]
        public string CustomerUniqueIdPattern { get; set; }

        [DataMember(Name = "enforced_customer_unique_id", Order = 6)]
        public string EnforcedCustomerUniqueIdPattern { get; set; }

        [DataMember(Name = "expirydate_start", Order = 7)]
        public DateTime? ExpirydateStart { get; set; }

        [DataMember(Name = "expirydate_end", Order = 8)]
        public DateTime? ExpirydateEnd { get; set; }

        [DataMember(Name = "feedcode", Order = 9)]
        public string Feedcode { get; set; }

        [DataMember(Name = "ignore_case", Order = 10)]
        public bool? IgnoreCase { get; set; }

        [DataMember(Name = "instrument_list", Order = 11)]
        public InstrumentList instrument_list { get; set; }

        [DataMember(Name = "isincode", Order = 12)]
        public string IsinCodePattern { get; set; }

        [DataMember(Name = "symbol", Order = 13)]
        public string Symbol { get; set; }

        [DataMember(Name = "exchange", Order = 14)]
        public string Exchange { get; set; }

        [DataMember(Name = "issuer", Order = 15)]
        public string Issuer { get; set; }

        [DataMember(Name = "kind", Order = 16)]
        public string Kind { get; set; }

        [DataMember(Name = "market", Order = 17)]
        public string Market { get; set; }

        [DataMember(Name = "strikeprice_min", Order = 18)]
        public double? StrikePriceMin { get; set; }

        [DataMember(Name = "strikeprice_max", Order = 19)]
        public double? StrikePriceMax { get; set; }

        [DataMember(Name = "submarket", Order = 20)]
        public string SubMarket { get; set; }

        [DataMember(Name = "tick_rule", Order = 21)]
        public string TickRule { get; set; }

        [DataMember(Name = "underlying", Order = 22)]
        public string UnderlyingPattern { get; set; }
    }


    [DataContract(Name = nameof(MessageType.MARKET_STATUS_TOGGLE), Namespace = "")]
    public class MarketStatusToggleReply : ServerMessage
    {
        [DataMember(Name = "toggle", Order = 1)]
        public bool? Toggle { get; set; }

        [DataMember(Name = "market", Order = 2)]
        public string Market { get; set; }
    }


    [DataContract(Name = nameof(MessageType.MONEY_FEED_TOGGLE), Namespace = "")]
    public class MoneyFeedToggleReply : ServerMessage
    {
        [DataMember(Name = "toggle")]
        public bool? Toggle { get; set; }
    }


    [DataContract(Name = nameof(MessageType.NEWS_FEED_TOGGLE), Namespace = "")]
    public class NewsFeedToggleReply : ServerMessage
    {
        [DataMember(Name = "toggle")]
        public bool? Toggle { get; set; }
    }


    [DataContract(Name = nameof(MessageType.ORDER_DEPTH_FEED_TOGGLE), Namespace = "")]
    public class OrderDepthFeedToggleReply : ServerMessage
    {
        [DataMember(Name = "instrument_id", Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "toggle", Order = 2)]
        public bool? Toggle { get; set; }
    }


    [DataContract(Name = nameof(MessageType.ORDER_FEED_TOGGLE), Namespace = "")]
    public class OrderFeedToggleReply : ServerMessage
    {
        [DataMember(Name = "toggle")]
        public bool? Toggle { get; set; }
    }


    [DataContract(Name = nameof(MessageType.PORTFOLIO_POSITION_FEED_TOGGLE), Namespace = "")]
    public class PortfolioPositionFeedToggleReply : ServerMessage
    {
        [DataMember(Name = "toggle")]
        public bool? Toggle { get; set; }
    }


    [DataContract(Name = nameof(MessageType.PORTFOLIO_RESET_FEED_TOGGLE), Namespace = "")]
    public class PortfolioResetFeedToggleReply : ServerMessage
    {
        [DataMember(Name = "portfolio", Order = 1)]
        public string Portfolio { get; set; }

        [DataMember(Name = "toggle", Order = 2)]
        public bool? Toggle { get; set; }
    }


    [DataContract(Name = nameof(MessageType.PRICEFEED_TOGGLE), Namespace = "")]
    public class PriceFeedToggleReply : ServerMessage
    {
        [DataMember(Name = "instrument_id", Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "toggle", Order = 2)]
        public bool? Toggle { get; set; }
    }


    [DataContract(Name = nameof(MessageType.QUOTEDFEED_TOGGLE), Namespace = "")]
    public class QuoteFeedToggleReply : ServerMessage
    {
        [DataMember(Name = "instrument_id", Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "toggle", Order = 2)]
        public bool? Toggle { get; set; }
    }


    [DataContract(Name = nameof(MessageType.QUOTE_REQUEST_FEED_TOGGLE), Namespace = "")]
    public class QuoteRequestFeedToggleReply : ServerMessage
    {
        [DataMember(Name = "toggle")]
        public bool? Toggle { get; set; }
    }


    [DataContract(Name = nameof(MessageType.REFERENCE_PRICE_FEED_TOGGLE), Namespace = "")]
    public class ReferencePriceFeedToggleReply : ServerMessage
    {
        [DataMember(Name = "toggle")]
        public bool? Toggle { get; set; }
    }


    [DataContract(Name = nameof(MessageType.SPREADTABLE_FEED_TOGGLE), Namespace = "")]
    public class SpreadTableFeedToggleReply : ServerMessage
    {
        [DataMember(Name = "toggle")]
        public bool? Toggle { get; set; }
    }


    [DataContract(Name = nameof(MessageType.TEXT_TICKER_FEED_TOGGLE), Namespace = "")]
    public class TextTickerFeedToggleReply : ServerMessage
    {
        [DataMember(Name = "toggle")]
        public bool? Toggle { get; set; }
    }


    [DataContract(Name = nameof(MessageType.TRADETICKER_TOGGLE), Namespace = "")]
    public class TradeTickerToggleReply : ServerMessage
    {
        [DataMember(Name = "underlying", Order = 1)]
        public string Underlying { get; set; }

        [DataMember(Name = "kind", Order = 2)]
        public string Kind { get; set; }

        [DataMember(Name = "instrument_id", Order = 3)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "toggle", Order = 4)]
        public bool? Toggle { get; set; }
    }


    [DataContract(Name = nameof(MessageType.TRADE_FEED_TOGGLE), Namespace = "")]
    public class TradeFeedToggleReply : ServerMessage
    {
        [DataMember(Name = "toggle")]
        public bool? Toggle { get; set; }
    }


    [DataContract(Name = nameof(MessageType.UNDERLYING_FEED_TOGGLE), Namespace = "")]
    public class UnderlyingFeedToggleReply : ServerMessage
    {
        [DataMember(Name = "toggle")]
        public bool? Toggle { get; set; }
    }


    [DataContract(Name = nameof(MessageType.UNDERLYING_RATECURVE_FEED_TOGGLE), Namespace = "")]
    public class UnderlyingRateCurveFeedToggleReply : ServerMessage
    {
        [DataMember(Name = "toggle")]
        public bool? Toggle { get; set; }
    }


    [DataContract(Name = nameof(MessageType.VOLATILITY_RAW_SURFACE_FEED_TOGGLE), Namespace = "")]
    public class VolatilifyRawSurfaceFeedToggleReply : ServerMessage
    {
        [DataMember(Name = "toggle")]
        public bool? Toggle { get; set; }
    }


    [DataContract(Name = nameof(MessageType.YIELD_CURVE_FEED_TOGGLE), Namespace = "")]
    public class YieldRateCurveFeedToggleReply : ServerMessage
    {
        [DataMember(Name = "toggle")]
        public bool? Toggle { get; set; }
    }
}
