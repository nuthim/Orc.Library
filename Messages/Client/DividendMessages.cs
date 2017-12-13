using Orc.Library.Enums;
using Orc.Library.Dictionaries;
using System.Runtime.Serialization;


namespace Orc.Library.Messages.Client
{

    /// <summary>
    /// Delete all dividends for a given instrument.
    /// </summary>
    [DataContract(Name = nameof(MessageType.DIVIDEND_DELETE), Namespace = "")]
    public class DividendDeleteMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true)]
        public InstrumentId InstrumentId { get; set; }

        public DividendDeleteMessage() : base(MessageType.DIVIDEND_DELETE)
        {

        }
    }

    /// <summary>
    /// Get all dividends for an instrument
    /// </summary>
    [DataContract(Name = nameof(MessageType.DIVIDEND_GET), Namespace = "")]
    public class DividendGetMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "dividendkinds", IsRequired = true, Order = 2)]
        public DividendKinds DividendKinds { get; set; }

        public DividendGetMessage() : base(MessageType.DIVIDEND_GET)
        {

        }
    }


    /// <summary>
    /// Add a single dividend for an instrument
    /// <para>Should only be used when adding a single dividend for an instrument. If you are adding several dividends, 
    /// <see cref="DividendUpdateMessage"/>(possibly together with <see cref="DividendGetMessage"/>) should be used instead. 
    /// <see cref="DividendUpdateMessage"/> is more efficient regarding to performance.
    /// </para>
    /// </summary>
    [DataContract(Name = nameof(MessageType.DIVIDEND_INSERT), Namespace = "")]
    public class DividendInsertMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "dividend", IsRequired = true, Order = 2)]
        public Dividend Dividend { get; set; }

        public DividendInsertMessage() : base(MessageType.DIVIDEND_INSERT)
        {

        }
    }

    /// <summary>
    /// Update (replace) dividends and/or operations for a given instrument. The type to be replaced depends on the dividend message, 
    /// if the message includes both types, both types are replaced.
    /// </summary>
    [DataContract(Name = nameof(MessageType.DIVIDEND_UPDATE), Namespace = "")]
    public class DividendUpdateMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "dividends", IsRequired = true, Order = 2)]
        public Dividends Dividends { get; set; }

        /// <summary>
        /// Set to true to replace both dividends and observations regardless of type to be replaced.
        /// </summary>
        [DataMember(Name = "update_for_all_kinds", IsRequired = true, Order = 3)]
        public bool UpdateAllKinds { get; set; }

        public DividendUpdateMessage() : base(MessageType.DIVIDEND_UPDATE)
        {

        }
    }
}