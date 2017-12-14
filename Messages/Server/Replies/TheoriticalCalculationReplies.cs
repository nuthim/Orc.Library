using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Server.Replies
{
    [DataContract(Name = nameof(MessageType.THEORETICAL_CALCULATION), Namespace = "")]
    public class TheoreticalCalculationReply : ServerMessage
    {
        [DataMember(Name = "instrument_id", Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "action", Order = 2)]
        public string Action { get; set; }

        [DataMember(Name = "underlying", Order = 3)]
        public string Underlying { get; set; }

        [DataMember(Name = "yield_name", Order = 4)]
        public string YieldName { get; set; }

        [DataMember(Name = "result_currency", Order = 5)]
        public string ResultCurrency { get; set; }

        [DataMember(Name = "result", Order = 6)]
        public double? Result { get; set; }

        [DataMember(Name = "feed_tag", Order = 7)]
        public int? FeedTag { get; set; }
    }


    [DataContract(Name = nameof(MessageType.THEORETICAL_CALCULATION_FEED_STOP), Namespace = "")]
    public class TheoreticalCalculationFeedStopReply : ServerMessage
    {
        [DataMember(Name = "feed_tag")]
        public int? FeedTag { get; set; }
    }


    [DataContract(Name = nameof(MessageType.THEORETICAL_CALCULATION_GROUP), Namespace = "")]
    public class TheoreticalCalculationGroupReply : ServerMessage
    {
        [DataMember(Name = "instrument_id", Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "result_currency", Order = 2)]
        public string ResultCurrency { get; set; }

        [DataMember(Name = "calculation_results", Order = 3)]
        public CalculationResults CalculationResults { get; set; }

        [DataMember(Name = "feed_tag", Order = 4)]
        public int? FeedTag { get; set; }
    }

}
