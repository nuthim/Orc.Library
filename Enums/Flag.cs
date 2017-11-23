using System.Runtime.Serialization;

namespace Orc.Library.Enums
{
    [DataContract(Name = "flag", Namespace = "")]
    public enum Flag
    {
        [EnumMember(Value = "auto_quote_flag")]
        AutoQuoteFlag,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "auto_mass_quote_ask_flag")]
        AutoMassQuoteAskFlag,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "auto_mass_quote_bid_flag")]
        AutoMassQuoteBidFlag,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "auto_responding_ask_flag")]
        AutoRespondingAskFlag,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "auto_responding_bid_flag")]
        AutoRespondingBidFlag,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "auto_diming_ask_flag")]
        AutoDimingAskFlag,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "auto_diming_bid_flag")]
        AutoDimingBidFlag,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "auto_trading_ask_flag")]
        AutoTradingAskFlag,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "auto_trading_bid_flag")]
        AutoTradingBidFlag,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "auto_hedging_ask_flag")]
        AutoHedgingAskFlag,


        [EnumMember(Value = "auto_hedging_bid_flag")]
        AutoHedgingBidFlag
    }

}