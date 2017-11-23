using System.Runtime.Serialization;


namespace Orc.Library.Enums
{

    [DataContract(Name = "history_action", Namespace = "")]
    public enum HistoryAction
    {
        /// <summary>
        /// When order is inserted initially in Orc using OP or OT.
        /// </summary>
        [EnumMember(Value = "Order insert")]
        OrderInsert,

        /// <summary>
        /// When any order characteristic is changed e.g.volume, price, comment, portfolio.
        /// </summary>
        [EnumMember(Value = "Order update")]
        OrderUpdate,

        /// <summary>
        /// When any order characteristic of an order on the market is changed (or when an order is initially placed on the market).
        /// </summary>
        [EnumMember(Value = "Marketorder update")]
        MarketOrderUpdate
    }
}