

using System.Runtime.Serialization;

namespace Orc.Library.Enums
{
    [DataContract(Name = "parameter", Namespace = "")]
    public enum Parameter
    {
        [EnumMember(Value = "askbaseoffset")]
        AskBaseOffset,

        [EnumMember(Value = "askoffset")]
        AskOffset,

        [EnumMember(Value = "askrateoffset")]
        AskRateOffset,

        [EnumMember(Value = "auto_traded_volume_ask")]
        AutoTradedVolumeAsk,

        [EnumMember(Value = "auto_traded_volume_bid")]
        AutoTradedVolumeBid,

        [EnumMember(Value = "baseoffset")]
        BaseOffset,

        [EnumMember(Value = "bidbaseoffset")]
        BidBaseOffset,

        [EnumMember(Value = "bidoffset")]
        BidOffset,

        [EnumMember(Value = "bidrateoffset")]
        BidRateOffset,

        [EnumMember(Value = "quote_askbaseoffset")]
        QuoteAskBaseOffset,

        [EnumMember(Value = "quote_askoffset")]
        QuoteAskOffset,

        [EnumMember(Value = "quote_bidbaseoffset")]
        QuoteBidBaseOffset,

        [EnumMember(Value = "quote_bidoffset")]
        QuoteBidOffset,

        [EnumMember(Value = "quote_traded_volume_ask")]
        QuoteTradedVolumeAsk,

        [EnumMember(Value = "quote_traded_volume_bid")]
        QuoteTradedVolumeBid,

        [EnumMember(Value = "quotelot_multiplier")]
        QuoteLotMultiplier,

        [EnumMember(Value = "quotevolatility")]
        QuoteVolatility,

        [EnumMember(Value = "quotevolatility_askoffset")]
        QuoteVolatilityAskOffset,

        [EnumMember(Value = "quotevolatility_bidoffset")]
        QuoteVolatilityBidOffset,

        [EnumMember(Value = "spread")]
        Spread,

        [EnumMember(Value = "spread_bias")]
        SpreadBias,

        [EnumMember(Value = "volatility")]
        Volatility,

        [EnumMember(Value = "volatility_askoffset")]
        VolatilityAskOffset,

        [EnumMember(Value = "volatility_bidoffset")]
        VolatilityBidOffset,
    }
}
