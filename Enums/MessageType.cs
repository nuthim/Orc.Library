// ReSharper disable InconsistentNaming
namespace Orc.Library.Enums
{
    public enum MessageType
    {
        unknown = 0,
        enum_get,
        login,
        logout,
        login_reply,
        reply,
        trade_feed_toggle,
        trade_feed,
        trade_insert,
        trade_modify,
        trade_delete,
        trade_get,
        trade_verify,
        trade_history_get,
        trade_range_get,
        instrument_feed_toggle,
        instrument_feed,
        instrument_download,
        instrument_get,
        instrument_update,
        instrument_create,
        instrument_delete,
        instrument_attributes_set,
        instrument_parameters_set,
        volatility_raw_surface_get,
        volatility_raw_surface_insert,
        volatility_surface_get,
        volatility_surface_insert,
        volatility_surface_delete,
        volatility_surface_download,
        volatility_model_download,
        underlying_download,
        underlying_update,
        reference_price_set,
        reference_price_get,
        portfolio_position_feed_toggle,
        portfolio_position_feed,
        portfolio_download,
        portfolio_get,
        portfolio_create,
        portfolio_delete,
        portfolio_update,
        portfolio_position_update,
        portfolio_reset,
        yield_curve_get,
        yield_curve_insert,
        yield_curve_update,
        yield_curve_delete,
        yield_curve_download,
        dividend_delete,
        dividend_get,
        dividend_insert,
        dividend_update,
        dividend_feed_toggle,
        theoretical_calculation,
        theoretical_calculation_feed_stop,
        theoretical_calculation_group,
        pricefeed_broadcast,
        currency_create,
        tick_rule_delete,
        tick_rule_download,
        tick_rule_update,
        calendar_download,
        calendar_entries_delete,
        calendar_entries_insert,
        CUSTOMER_GET,
        calendar_insert,
        calendar_set_default,
        CUSTOMER_UPDATE,
        money_feed_toggle,
        money_feed,
        money_insert,
        money_delete,
        money_range_get,
        news_feed_toggle,
        stresstest,
        volatility_get,
        portfolio_empty,
        price_get,
        pricefeed_toggle,
        price_feed,
        order_feed_toggle,
        order_feed,
        order_range_get,
        order_history_get,
        underlying_feed_toggle,
        ping,
        order_get,
        COUNTERPART_ADD,
        COUNTERPART_REMOVE,
        COUNTERPART_DOWNLOAD,
        CUSTOMER_DELETE,
        CUSTOMER_FIELD_DELETE,
        CUSTOMER_FIELD_GET,
        CUSTOMER_FIELD_INSERT,
        CUSTOMER_FIELD_UPDATE,
        CUSTOMER_INSERT,
        CUSTOMER_VALUE_DELETE,
        CUSTOMER_VALUE_UPDATE,
        CUSTOMER_PORTFOLIO_DELETE,
        CUSTOMER_PORTFOLIO_GET,
        CUSTOMER_PORTFOLIO_INSERT,
        CUSTOMER_VALUE_GET,
        CUSTOMER_VALUE_SEARCH,
        portfolio_cleanup,
        portfolio_component_add,
        portfolio_component_remove,
        portfolio_describe,
        PORTFOLIO_KIND_RESTRICTION_DELETE,
        PORTFOLIO_KIND_RESTRICTION_GET,
        PORTFOLIO_KIND_RESTRICTION_INSERT,
        PORTFOLIO_MONEY_POSITION_UPDATE,
        PORTFOLIO_POSITION_UPDATE,
        PORTFOLIO_RESET,
        PORTFOLIO_RESET_GET,
        PORTFOLIO_SUMMATION_CREATE,
        PORTFOLIO_ZERO_CHANGE_VALUES,
        trade_allocate,
        trading_power
    }
}