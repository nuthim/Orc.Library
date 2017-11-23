using System.Runtime.Serialization;


namespace Orc.Library.Enums
{

    [DataContract(Name = "market_service", Namespace = "")]
    public enum MarketService
    {
        [EnumMember(Value = "News feed")]
        NewsFeed,

        [EnumMember(Value = "Order handling")]
        OrderHandling,

        [EnumMember(Value = "Price feed")]
        PriceFeed,

        [EnumMember(Value = "Price feed broadcasts")]
        PriceFeedBroadcasts,

        [EnumMember(Value = "Quoted feed")]
        QuotedFeed,

        [EnumMember(Value = "Quote handling")]
        QuoteHandling,

        [EnumMember(Value = "SFC mapping")]
        SFCMapping,

        [EnumMember(Value = "Theoretical calculations")]
        TheoreticalCalculations,

        [EnumMember(Value = "Trade feed")]
        TradeFeed,

        [EnumMember(Value = "Tradeticker feed broadcasts")]
        TradetickerFeedBroadcasts
    }
}