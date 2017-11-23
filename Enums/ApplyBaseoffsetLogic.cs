using System.Runtime.Serialization;


namespace Orc.Library.Enums
{
    [DataContract(Name = "apply_baseoffset_logic", Namespace = "")]
    public enum ApplyBaseOffsetLogic
    {
        /// <summary>
        /// No base offset logic
        /// </summary>
        [EnumMember]
        None,

        /// <summary>
        /// When using simple offset to spots, forwards or futures; the theoretical price is simply the sum of the base price and the offset. 
        /// For options, the Orc calculates a synthetic dividend yield, which results in a theoretical forward price which is the sum of the base price and the offset.
        /// The option is then valued according to the base price and the synthetic yield. No dividends are used.
        /// </summary>
        [EnumMember(Value = "Simple price offset")]
        SimplePriceOffset,

        /// <summary>
        /// In the synthetic spot offset alternative, a theoretical spot price is calculated as the sum of base price and the offset of the base contract. 
        /// The theoretical forward price is then given by the theoretical spot price, the financing rate and dividend yield. No dividends are used.
        /// </summary>
        [EnumMember(Value = "Synthetic spot")]
        SyntheticSpot,

        /// <summary>
        /// The forward adjustment is a correction to the theoretical forward price. Thus if the offset is zero this will affect the value as if there was no offset. 
        /// When the offset is non-zero, a synthetic yield is calculated and as a result the offset is added to the theoretical forward price. 
        /// This yield as well as dividends are then used in future-, forward- and option calculations.
        /// </summary>
        [EnumMember(Value = "Forward adjustment")]
        ForwardAdjustment,

        /// <summary>
        /// For bond contracts. The offset is added to base ytm (or corresponding base ytm if the base contract is price quoted), to obtain the theoretical ytm of the contract. 
        /// The theoretical clean price is then calculated from the theoretical ytm.
        /// </summary>
        [EnumMember(Value = "Simple ytm offset")]
        SimpleYtmOffset,

        /// <summary>
        /// Used for valuing derivatives whose underlying has no cost of carry. A typical application is when the underlying is a future. 
        /// When applied, the calculation always uses zero cost of carry for the underlying. Dividends are not taken into account.
        /// </summary>
        [EnumMember(Value = "No cost carry")]
        NoCostCarry
    }
}
