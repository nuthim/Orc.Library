using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Client
{

    /// <summary>
    /// Send a quote transaction
    /// </summary>
    [DataContract(Name = nameof(MessageType.QUOTE), Namespace = "")]
    public class QuoteMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "action", IsRequired = true, Order = 2)]
        public QuoteAction? Action { get; set; }

        /// <summary>
        /// If set to "true", quoting will be handled asynchronously. Default is "false".
        /// </summary>
        [DataMember(Name = "asynch", Order = 3)]
        public bool? Asynch { get; set; }

        [DataMember(Name = "additional_data", Order = 4)]
        public AdditionalData AdditionalData { get; set; }

        public QuoteMessage() : base(MessageType.QUOTE)
        {

        }
    }


    /// <summary>
    /// Get quote parameters.
    /// </summary>
    [DataContract(Name = nameof(MessageType.QUOTE_PARAMETERS_GET), Namespace = "")]
    public class QuoteParametersGetMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        /// <summary>
        /// If set to "true", this message will be handled asynchronously. Default is "false".
        /// </summary>
        [DataMember(Name = "asynch", Order = 2)]
        public bool? Asynch { get; set; }

        public QuoteParametersGetMessage() : base(MessageType.QUOTE_PARAMETERS_GET)
        {

        }
    }

    /// <summary>
    /// Set quote parameters.
    /// </summary>
    [DataContract(Name = nameof(MessageType.QUOTE_PARAMETERS_SET), Namespace = "")]
    public class QuoteParametersSetMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "quote_parameters", IsRequired = true, Order = 2)]
        public QuoteParameters QuoteParameters { get; set; }

        /// <summary>
        /// If set to "true", this message will be handled asynchronously. Default is "false".
        /// </summary>
        [DataMember(Name = "asynch", Order = 3)]
        public bool? Asynch { get; set; }

        public QuoteParametersSetMessage() : base(MessageType.QUOTE_PARAMETERS_SET)
        {

        }
    }

    /// <summary>
    /// Use this message to send a quote request.
    /// </summary>
    [DataContract(Name = nameof(MessageType.QUOTE_REQUEST), Namespace = "")]
    public class QuoteRequestMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "buy_or_sell", Order = 2)]
        public BuySell? BuyOrSell { get; set; }

        public QuoteRequestMessage() : base(MessageType.QUOTE_REQUEST)
        {

        }
    }


    /// <summary>
    /// Get the quote parameters for quotes that are sent to the market.
    /// </summary>
    [DataContract(Name = nameof(MessageType.QUOTED_PARAMETERS_GET), Namespace = "")]
    public class QuotedParametersGetMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        /// <summary>
        /// If set to "true", this message will be handled asynchronously. Default is "false".
        /// </summary>
        [DataMember(Name = "asynch", Order = 2)]
        public bool? Asynch { get; set; }

        public QuotedParametersGetMessage() : base(MessageType.QUOTED_PARAMETERS_GET)
        {

        }
    }
}
