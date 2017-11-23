using System;
using Orc.Library.Enums;
using Orc.Library.Dictionaries;
using System.Runtime.Serialization;


namespace Orc.Library.Messages.Client
{

    /// <summary>
    /// Delete all dividends for a given instrument.
    /// </summary>
    [DataContract(Name = "dividend_delete", Namespace = "")]
    public class DividendDeleteMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true)]
        public InstrumentId InstrumentId { get; set; }

        public DividendDeleteMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.dividend_delete);
        }
    }

    /// <summary>
    /// Get all dividends for an instrument
    /// </summary>
    [DataContract(Name = "dividend_get", Namespace = "")]
    public class DividendGetMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "dividendkinds", IsRequired = true, Order = 2)]
        public DividendKinds DividendKinds { get; set; }

        public DividendGetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.dividend_get);
        }
    }


    /// <summary>
    /// Add a single dividend for an instrument
    /// </summary>
    [DataContract(Name = "dividend_insert", Namespace = "")]
    public class DividendInsertMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "dividend", IsRequired = true, Order = 2)]
        public Dividend Dividend { get; set; }

        public DividendInsertMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.dividend_insert);
        }
    }

    /// <summary>
    /// Update (replace) dividends and/or operations for a given instrument. The type to be replaced depends on the dividend message, if the message includes both types, both types are replaced.
    /// </summary>
    [DataContract(Name = "dividend_update", Namespace = "")]
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

        public DividendUpdateMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.dividend_update);
        }
    }
}