using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Server.Replies
{

    [DataContract(Name = nameof(MessageType.QUOTE), Namespace = "")]
    public class QuoteReply : ServerMessage
    {
        [DataMember(Name = "instrument_id", Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "action", Order = 2)]
        public QuoteAction? Action { get; set; }
    }


    [DataContract(Name = nameof(MessageType.QUOTE_PARAMETERS_GET), Namespace = "")]
    public class QuoteParametersGetReply : ServerMessage
    {
        [DataMember(Name = "instrument_id", Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "quote_parameters", Order = 2)]
        public QuoteParameters QuoteParameters { get; set; }
    }


    [DataContract(Name = nameof(MessageType.QUOTE_PARAMETERS_SET), Namespace = "")]
    public class QuoteParametersSetReply : ServerMessage
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }
    }


    [DataContract(Name = nameof(MessageType.QUOTE_REQUEST), Namespace = "")]
    public class QuoteRequestReply : ServerMessage
    {
        [DataMember(Name = "instrument_id", Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "buy_or_sell", Order = 2)]
        public BuySell? BuyOrSell { get; set; }
    }


    [DataContract(Name = nameof(MessageType.QUOTED_PARAMETERS_GET), Namespace = "")]
    public class QuotedParametersGetReply : ServerMessage
    {
        [DataMember(Name = "instrument_id", Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "quote_parameters", Order = 2)]
        public QuoteParameters QuoteParameters { get; set; }
    }
}
