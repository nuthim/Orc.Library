using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Server.Replies
{
    [DataContract(Name = nameof(MessageType.SFC_FEED_MAPPING), Namespace = "")]
    public class SfcFeedMappingReply : ServerMessage
    {
        [DataMember(Name = "instrument_id", Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "subscription_tag", Order = 2)]
        public int? SubscriptionTag { get; set; }

        [DataMember(Name = "contribution_tag", Order = 3)]
        public int? ContributionTag { get; set; }
    }
}
