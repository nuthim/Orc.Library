using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Server.Replies
{

    [DataContract(Name = nameof(MessageType.DIVIDEND_DELETE), Namespace = "")]
    public class DividendDeleteReply : ServerMessage
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }
    }


    [DataContract(Name = nameof(MessageType.DIVIDEND_GET), Namespace = "")]
    public class DividendGetReply : ServerMessage
    {
        [DataMember(Name = "instrument_id", Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "dividends", Order = 2)]
        public Dividends Dividendss { get; set; }
    }


    [DataContract(Name = nameof(MessageType.DIVIDEND_INSERT), Namespace = "")]
    public class DividendInsertReply : ServerMessage
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }
    }


    [DataContract(Name = nameof(MessageType.DIVIDEND_UPDATE), Namespace = "")]
    public class DividendUpdateReply : ServerMessage
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }
    }
}