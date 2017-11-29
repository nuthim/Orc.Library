using System;
using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Client
{

    /// <summary>
    /// Send a quote transaction with the QUOTE message.
    /// </summary>
    [DataContract(Name = "quote", Namespace = "")]
    public class QuoteMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId Instrument { get; set; }

        [DataMember(Name = "action", IsRequired = true, Order = 2)]
        public QuoteAction? QuoteAction { get; set; }

        [DataMember(Name = "asynch", Order = 3)]
        public bool? Asynch { get; set; }

        [DataMember(Name = "additional_data", Order = 4)]
        public AdditionalData AdditionalData { get; set; }

        public QuoteMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.QUOTE);
        }
    }


    /// <summary>
    /// Get quote parameters.
    /// </summary>
    [DataContract(Name = "quote_parameters_get", Namespace = "")]
    public class QuoteParametersGetMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId Instrument { get; set; }

        [DataMember(Name = "asynch", Order = 2)]
        public bool? Asynch { get; set; }

        public QuoteParametersGetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.QUOTE_PARAMETERS_GET);
        }
    }

    /// <summary>
    /// Set quote parameters.
    /// </summary>
    [DataContract(Name = "quote_parameters_set", Namespace = "")]
    public class QuoteParametersSetMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId Instrument { get; set; }

        [DataMember(Name = "quote_parameters", Order = 2)]
        public QuoteParameters QuoteParameters { get; set; }

        [DataMember(Name = "asynch", Order = 3)]
        public bool? Asynch { get; set; }

        public QuoteParametersSetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.QUOTE_PARAMETERS_SET);
        }
    }

    /// <summary>
    /// Use this message to send a quote request.
    /// </summary>
    [DataContract(Name = "quote_request", Namespace = "")]
    public class QuoteRequestMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId Instrument { get; set; }

        [DataMember(Name = "buy_or_sell", Order = 2)]
        public BuySell? TradeSide { get; set; }

        public QuoteRequestMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.QUOTE_REQUEST);
        }
    }


    /// <summary>
    /// Get the quote parameters for quotes that are sent to the market.
    /// </summary>
    [DataContract(Name = "quoted_parameters_get", Namespace = "")]
    public class QuotedParametersGetMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId Instrument { get; set; }

        [DataMember(Name = "asynch", Order = 2)]
        public bool? Asynch { get; set; }

        public QuotedParametersGetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.QUOTED_PARAMETERS_GET);
        }
    }
}
