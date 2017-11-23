using System.Runtime.Serialization;


namespace Orc.Library.Enums
{

    [DataContract(Name = "simulation_mode", Namespace = "")]
    public enum SimulationMode
    {
        /// <summary>
        /// Let simulated price or volatility represent an offset.
        /// </summary>
        [EnumMember]
        Offset,

        /// <summary>
        /// Use simulated price or volatility directly.
        /// </summary>
        [EnumMember]
        Fixed,

        /// <summary>
        /// Simulated price or volatility represent a percentage. Note that 1% is specified as "1" (and not 0.01).
        /// </summary>
        [EnumMember]
        Percentage
    }
}
