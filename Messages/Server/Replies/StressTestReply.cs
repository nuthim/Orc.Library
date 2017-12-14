using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Server.Replies
{
    [DataContract(Name = nameof(MessageType.STRESSTEST), Namespace = "")]
    public class StressTestReply : ServerMessage
    {
        [DataMember(Name = "portfolio_name", Order = 1)]
        public string PortfolioName { get; set; }
        
        [DataMember(Name = "total_items_count", Order = 2)]
        public int? TotalItemsCount { get; set; }

        [DataMember(Name = "start_item_number", Order = 3)]
        public int? StartItemNumber { get; set; }

        [DataMember(Name = "stress_matrix", Order = 4)]
        public StressMatrix StressMatrix { get; set; }
    }
}