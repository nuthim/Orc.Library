using System;
using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Client
{

    [DataContract(Name = "sfc_feed_mapping", Namespace = "")]
    public class SfcFeedMappingMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId Instrument { get; set; }

        [DataMember(Name = "subscription_tag", IsRequired = true, Order = 2)]
        public int? SubscriptionTag { get; set; }

        [DataMember(Name = "contribution_tag", IsRequired = true, Order = 3)]
        public int? ContributionTag { get; set; }

        public SfcFeedMappingMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.SFC_FEED_MAPPING);
        }
    }
}
