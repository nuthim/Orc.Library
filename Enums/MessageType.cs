
using System.Runtime.Serialization;

namespace Orc.Library.Enums
{
    [DataContract(Name = "message_type")]
    public enum MessageType
    {
        [EnumMember] CALENDAR_DELETE,
        [EnumMember] CALENDAR_DOWNLOAD,
        [EnumMember] CALENDAR_ENTRIES_DELETE,
        [EnumMember] CALENDAR_ENTRIES_INSERT,
        [EnumMember] CALENDAR_GET,
        [EnumMember] CALENDAR_INSERT,
        [EnumMember] CALENDAR_SET_DEFAULT,
        [EnumMember] CALENDAR_UPDATE,
        [EnumMember] COUNTERPART_ADD,
        [EnumMember] COUNTERPART_DOWNLOAD,
        [EnumMember] COUNTERPART_REMOVE,
        [EnumMember] CURRENCY_CREATE,
        [EnumMember] CUSTOMER_DELETE,
        [EnumMember] CUSTOMER_FIELD_DELETE,
        [EnumMember] CUSTOMER_FIELD_GET,
        [EnumMember] CUSTOMER_FIELD_INSERT,
        [EnumMember] CUSTOMER_FIELD_UPDATE,
        [EnumMember] CUSTOMER_GET,
        [EnumMember] CUSTOMER_INSERT,
        [EnumMember] CUSTOMER_PORTFOLIO_DELETE,
        [EnumMember] CUSTOMER_PORTFOLIO_GET,
        [EnumMember] CUSTOMER_PORTFOLIO_INSERT,
        [EnumMember] CUSTOMER_UPDATE,
        [EnumMember] CUSTOMER_VALUE_DELETE,
        [EnumMember] CUSTOMER_VALUE_GET,
        [EnumMember] CUSTOMER_VALUE_SEARCH,
        [EnumMember] CUSTOMER_VALUE_UPDATE,
        [EnumMember] DIVIDEND_DELETE,
        [EnumMember] DIVIDEND_FEED_TOGGLE,
        [EnumMember] DIVIDEND_GET,
        [EnumMember] DIVIDEND_INSERT,
        [EnumMember] DIVIDEND_UPDATE,
        [EnumMember] ENUM_GET,
        [EnumMember] INSTRUMENT_ATTRIBUTES_SET,
        [EnumMember] INSTRUMENT_CLEANUP_EXPIRED,
        [EnumMember] INSTRUMENT_CREATE,
        [EnumMember] INSTRUMENT_DELETE,
        [EnumMember] INSTRUMENT_DOWNLOAD,
        [EnumMember] INSTRUMENT_DYNAMIC_PARAMETER_DELETE,
        [EnumMember] INSTRUMENT_DYNAMIC_PARAMETERS_SET,
        [EnumMember] INSTRUMENT_FEED,
        [EnumMember] INSTRUMENT_FEED_TOGGLE,
        [EnumMember] INSTRUMENT_GET,
        [EnumMember] INSTRUMENT_GROUP_PARAMETERS_GET,
        [EnumMember] INSTRUMENT_GROUP_PARAMETERS_SET,
        [EnumMember] INSTRUMENT_MULTIPLE_FLAG_SET,
        [EnumMember] INSTRUMENT_MULTIPLE_PARAMETER_SET,
        [EnumMember] INSTRUMENT_PARAMETERS_SET,
        [EnumMember] INSTRUMENT_SET_AS_PREFERRED,
        [EnumMember] INSTRUMENT_UPDATE,
        [EnumMember] LOGIN,
        [EnumMember] LOGOUT,
        [EnumMember] MARKET_STATUS_TOGGLE,
        [EnumMember] MONEY_DELETE,
        [EnumMember] MONEY_FEED,
        [EnumMember] MONEY_FEED_TOGGLE,
        [EnumMember] MONEY_INSERT,
        [EnumMember] MONEY_RANGE_GET,
        [EnumMember] NEWS_ARTICLE_GET,
        [EnumMember] NEWS_BROADCAST,
        [EnumMember] NEWS_FEED_TOGGLE,
        [EnumMember] ORDER_ACTIVATE,
        [EnumMember] ORDER_DELETE,
        [EnumMember] ORDER_DEPTH_FEED_TOGGLE,
        [EnumMember] ORDER_FEED,
        [EnumMember] ORDER_FEED_TOGGLE,
        [EnumMember] ORDER_GET,
        [EnumMember] ORDER_HISTORY_GET,
        [EnumMember] ORDER_INSERT,
        [EnumMember] ORDER_MODIFY,
        [EnumMember] ORDER_RANGE_GET,
        [EnumMember] PING,
        [EnumMember] PORTFOLIO_CLEANUP,
        [EnumMember] PORTFOLIO_COMPONENT_ADD,
        [EnumMember] PORTFOLIO_COMPONENT_REMOVE,
        [EnumMember] PORTFOLIO_CREATE,
        [EnumMember] PORTFOLIO_DELETE,
        [EnumMember] PORTFOLIO_DESCRIBE,
        [EnumMember] PORTFOLIO_DOWNLOAD,
        [EnumMember] PORTFOLIO_EMPTY,
        [EnumMember] PORTFOLIO_GET,
        [EnumMember] PORTFOLIO_KIND_RESTRICTION_DELETE,
        [EnumMember] PORTFOLIO_KIND_RESTRICTION_GET,
        [EnumMember] PORTFOLIO_KIND_RESTRICTION_INSERT,
        [EnumMember] PORTFOLIO_MONEY_POSITION_UPDATE,
        [EnumMember] PORTFOLIO_POSITION_FEED,
        [EnumMember] PORTFOLIO_POSITION_FEED_TOGGLE,
        [EnumMember] PORTFOLIO_POSITION_UPDATE,
        [EnumMember] PORTFOLIO_RESET,
        [EnumMember] PORTFOLIO_RESET_FEED_TOGGLE,
        [EnumMember] PORTFOLIO_RESET_GET,
        [EnumMember] PORTFOLIO_SUMMATION_CREATE,
        [EnumMember] PORTFOLIO_UPDATE,
        [EnumMember] PORTFOLIO_ZERO_CHANGE_VALUES,
        [EnumMember] PRICE_FEED,
        [EnumMember] PRICE_GET,
        [EnumMember] PRICEFEED_BROADCAST,
        [EnumMember] PRICEFEED_TOGGLE,
        [EnumMember] QUOTE,
        [EnumMember] QUOTE_PARAMETERS_GET,
        [EnumMember] QUOTE_PARAMETERS_SET,
        [EnumMember] QUOTE_REQUEST,
        [EnumMember] QUOTE_REQUEST_FEED_TOGGLE,
        [EnumMember] QUOTED_PARAMETERS_GET,
        [EnumMember] QUOTEDFEED_TOGGLE,
        [EnumMember] REFERENCE_PRICE_DOWNLOAD,
        [EnumMember] REFERENCE_PRICE_FEED_TOGGLE,
        [EnumMember] REFERENCE_PRICE_GET,
        [EnumMember] REFERENCE_PRICE_SET,
        [EnumMember] SFC_FEED_MAPPING,
        [EnumMember] SPREADTABLE_DOWNLOAD,
        [EnumMember] SPREADTABLE_ENTRIES_DELETE,
        [EnumMember] SPREADTABLE_ENTRIES_INSERT,
        [EnumMember] SPREADTABLE_FEED_TOGGLE,
        [EnumMember] SPREADTABLE_GET,
        [EnumMember] SPREADTABLE_INSERT,
        [EnumMember] STRESSTEST,
        [EnumMember] TEXT_TICKER_FEED_TOGGLE,
        [EnumMember] THEORETICAL_CALCULATION,
        [EnumMember] THEORETICAL_CALCULATION_FEED_STOP,
        [EnumMember] THEORETICAL_CALCULATION_GROUP,
        [EnumMember] TICK_RULE_DELETE,
        [EnumMember] TICK_RULE_DOWNLOAD,
        [EnumMember] TICK_RULE_UPDATE,
        [EnumMember] TRADE_ALLOCATE,
        [EnumMember] TRADE_DELETE,
        [EnumMember] TRADE_FEED,
        [EnumMember] TRADE_FEED_TOGGLE,
        [EnumMember] TRADE_GET,
        [EnumMember] TRADE_HISTORY_GET,
        [EnumMember] TRADE_INSERT,
        [EnumMember] TRADE_MODIFY,
        [EnumMember] TRADE_RANGE_GET,
        [EnumMember] TRADE_VERIFY,
        [EnumMember] TRADETICKER_TOGGLE,
        [EnumMember] TRADING_POWER,
        [EnumMember] UNDERLYING_COVARIANCE_DELETE,
        [EnumMember] UNDERLYING_COVARIANCE_GET,
        [EnumMember] UNDERLYING_COVARIANCE_UPDATE,
        [EnumMember] UNDERLYING_DOWNLOAD,
        [EnumMember] UNDERLYING_FEED_TOGGLE,
        [EnumMember] UNDERLYING_RATECURVE_DELETE,
        [EnumMember] UNDERLYING_RATECURVE_FEED_TOGGLE,
        [EnumMember] UNDERLYING_RATECURVE_GET,
        [EnumMember] UNDERLYING_RATECURVE_UPDATE,
        [EnumMember] UNDERLYING_UPDATE,
        [EnumMember] VOLATILITY_GET,
        [EnumMember] VOLATILITY_MODEL_DOWNLOAD,
        [EnumMember] VOLATILITY_RAW_CURVE_INSERT,
        [EnumMember] VOLATILITY_RAW_SURFACE_FEED_TOGGLE,
        [EnumMember] VOLATILITY_RAW_SURFACE_GET,
        [EnumMember] VOLATILITY_RAW_SURFACE_INSERT,
        [EnumMember] VOLATILITY_SURFACE_DELETE,
        [EnumMember] VOLATILITY_SURFACE_DOWNLOAD,
        [EnumMember] VOLATILITY_SURFACE_GET,
        [EnumMember] VOLATILITY_SURFACE_INSERT,
        [EnumMember] YIELD_CURVE_DEFAULT,
        [EnumMember] YIELD_CURVE_DELETE,
        [EnumMember] YIELD_CURVE_DOWNLOAD,
        [EnumMember] YIELD_CURVE_FEED_TOGGLE,
        [EnumMember] YIELD_CURVE_GET,
        [EnumMember] YIELD_CURVE_INSERT,
        [EnumMember] YIELD_CURVE_UPDATE
    }
}