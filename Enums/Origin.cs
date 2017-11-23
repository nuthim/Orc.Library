using System.Runtime.Serialization;


namespace Orc.Library.Enums
{
    [DataContract(Name = "origin", Namespace = "")]
    public enum Origin
    {
        /// <summary>
        /// The order originates from the Orc Trader client.
        /// </summary>
        [EnumMember(Value = "Orc Trader")]
        OrcTrader,

        /// <summary>
        /// The order originates from the Orc Protocol
        /// </summary>
        [EnumMember(Value = "Orc Protocol")]
        OrcProtocol,

        /// <summary>
        /// The order has been imported to the Orc system
        /// </summary>
        [EnumMember]
        Import,

        /// <summary>
        /// The order originates from Liquidator
        /// </summary>
        [EnumMember]
        Liquidator,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        Other

    }
}
