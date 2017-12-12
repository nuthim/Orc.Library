using Orc.Library.Dictionaries;
using System.Runtime.Serialization;


namespace Orc.Library.Messages.Server
{

    [DataContract(Name = "DIVIDEND_DELETE", Namespace = "")]
    public class DividendDeleteReply : ServerMessage
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }
    }


    [DataContract(Name = "DIVIDEND_GET", Namespace = "")]
    public class DividendGetReply : ServerMessage
    {
        [DataMember(Name = "instrument_id", Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "dividends", Order = 2)]
        public Dividends Dividendss { get; set; }
    }


    [DataContract(Name = "DIVIDEND_INSERT", Namespace = "")]
    public class DividendInsertReply : ServerMessage
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }
    }


    [DataContract(Name = "DIVIDEND_UPDATE", Namespace = "")]
    public class DividendUpdateReply : ServerMessage
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }
    }
}