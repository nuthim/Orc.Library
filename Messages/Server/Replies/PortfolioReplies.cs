using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Server.Replies
{
    [DataContract(Name = nameof(MessageType.PORTFOLIO_CLEANUP), Namespace = "")]
    public class PortfolioCleanupReply : ServerMessage
    {
        [DataMember(Name = "portfolio_name")]
        public string PortfolioName { get; set; }
    }

    [DataContract(Name = nameof(MessageType.PORTFOLIO_COMPONENT_ADD), Namespace = "")]
    public class PortfolioComponentAddReply : ServerMessage
    {
        [DataMember(Name = "portfolio_name", Order = 1)]
        public string PortfolioName { get; set; }

        [DataMember(Name = "component_name", Order = 2)]
        public string ComponentName { get; set; }
    }

    [DataContract(Name = nameof(MessageType.PORTFOLIO_COMPONENT_REMOVE), Namespace = "")]
    public class PortfolioComponentRemoveReply : ServerMessage
    {
        [DataMember(Name = "portfolio_name", Order = 1)]
        public string PortfolioName { get; set; }

        [DataMember(Name = "component_name", Order = 2)]
        public string ComponentName { get; set; }
    }

    [DataContract(Name = nameof(MessageType.PORTFOLIO_CREATE), Namespace = "")]
    public class PortfolioCreateReply : ServerMessage
    {
        [DataMember(Name = "portfolio_name", Order = 1)]
        public string PortfolioName { get; set; }

        [DataMember(Name = "currency", Order = 2)]
        public string Currency { get; set; }
    }

    [DataContract(Name = nameof(MessageType.PORTFOLIO_DELETE), Namespace = "")]
    public class PortfolioDeleteReply : ServerMessage
    {
        [DataMember(Name = "portfolio_name")]
        public string PortfolioName { get; set; }
    }

    [DataContract(Name = nameof(MessageType.PORTFOLIO_DESCRIBE), Namespace = "")]
    public class PortfolioDescribeReply : ServerMessage
    {
        [DataMember(Name = "portfolio_name", Order = 1)]
        public string PortfolioName { get; set; }

        [DataMember(Name = "summation_type", Order = 2)]
        public bool? SummationType { get; set; }

        [DataMember(Name = "portfolio_components", Order = 3)]
        public PortfolioComponents PortfolioComponents { get; set; }
    }

    [DataContract(Name = nameof(MessageType.PORTFOLIO_DOWNLOAD), Namespace = "")]
    public class PortfolioDownloadReply : ServerMessage
    {
        [DataMember(Name = "portfolios")]
        public Portfolios Portfolios { get; set; }
    }

    [DataContract(Name = nameof(MessageType.PORTFOLIO_EMPTY), Namespace = "")]
    public class PortfolioEmptyReply : ServerMessage
    {
        [DataMember(Name = "portfolio_name")]
        public string PortfolioName { get; set; }
    }

    [DataContract(Name = nameof(MessageType.PORTFOLIO_GET), Namespace = "")]
    public class PortfolioGetReply : ServerMessage
    {
        [DataMember(Name = "portfolio_name", Order = 1)]
        public string PortfolioName { get; set; }

        [DataMember(Name = "ordervalidate", Order = 2)]
        public OrderValidate? OrderValidate { get; set; }

        [DataMember(Name = "currency", Order = 3)]
        public string Currency { get; set; }

        [DataMember(Name = "portfolio_positions", Order = 4)]
        public PortfolioPositions PortfolioPositions { get; set; }

        [DataMember(Name = "instrument_id", Order = 5)]
        public InstrumentId InstrumentId { get; set; }

        /// <summary>
        /// If ItemsPerMessage is set to 100, the first reply will start at 1 and second at 101 and so on
        /// </summary>
        [DataMember(Name = "start_item_number", Order = 6)]
        public int? StartItemNumber { get; set; }

        /// <summary>
        /// This is contained in the first reply message and corresponds to the total number of portfolio positions to be downloaded.
        /// </summary>
        [DataMember(Name = "total_items_count", Order = 7)]
        public int? TotalItemsCount { get; set; }
    }

    [DataContract(Name = nameof(MessageType.PORTFOLIO_KIND_RESTRICTION_DELETE), Namespace = "")]
    public class PortfolioKindRestrictionDeleteReply : ServerMessage
    {
        [DataMember(Name = "portfolio_name")]
        public string PortfolioName { get; set; }
    }

    [DataContract(Name = nameof(MessageType.PORTFOLIO_KIND_RESTRICTION_GET), Namespace = "")]
    public class PortfolioKindRestrictionGetReply : ServerMessage
    {
        [DataMember(Name = "kind_restrictions")]
        public KindRestrictions KindRestrictions { get; set; }
    }

    [DataContract(Name = nameof(MessageType.PORTFOLIO_KIND_RESTRICTION_INSERT), Namespace = "")]
    public class PortfolioKindRestrictionInsertReply : ServerMessage
    {
        [DataMember(Name = "portfolio_name", Order = 1)]
        public string PortfolioName { get; set; }

        [DataMember(Name = "kind", Order = 2)]
        public string Kind { get; set; }
    }

    [DataContract(Name = nameof(MessageType.PORTFOLIO_MONEY_POSITION_UPDATE), Namespace = "")]
    public class PortfolioMoneyPositionUpdateReply : ServerMessage
    {
        [DataMember(Name = "kind", Order = 1)]
        public string Kind { get; set; }

        [DataMember(Name = "portfolio_name", Order = 2)]
        public string PortfolioName { get; set; }

        [DataMember(Name = "absolute_change", Order = 3)]
        public bool? AbsoluteChange { get; set; }
    }

    [DataContract(Name = nameof(MessageType.PORTFOLIO_POSITION_UPDATE), Namespace = "")]
    public class PortfolioPositionUpdateReply : ServerMessage
    {
        [DataMember(Name = "portfolio_name", Order = 1)]
        public string PortfolioName { get; set; }

        [DataMember(Name = "portfolio_position", Order = 2)]
        public PortfolioPosition PortfolioPosition { get; set; }

        [DataMember(Name = "update_cash", Order = 3)]
        public bool? UpdateCash { get; set; }
    }

    [DataContract(Name = nameof(MessageType.PORTFOLIO_RESET), Namespace = "")]
    public class PortfolioResetReply : ServerMessage
    {
        [DataMember(Name = "portfolio_name")]
        public string PortfolioName { get; set; }
    }

    [DataContract(Name = nameof(MessageType.PORTFOLIO_RESET_GET), Namespace = "")]
    public class PortfolioResetGetReply : ServerMessage
    {
        [DataMember(Name = "portfolio", Order = 1)]
        public string PortfolioName { get; set; }

        [DataMember(Name = "positionsnapshots", Order = 2)]
        public PositionSnapshots PositionSnapshots { get; set; }
    }

    [DataContract(Name = nameof(MessageType.PORTFOLIO_SUMMATION_CREATE), Namespace = "")]
    public class PortfolioSummationCreateReply : ServerMessage
    {
        [DataMember(Name = "portfolio_name")]
        public string PortfolioName { get; set; }
    }

    [DataContract(Name = nameof(MessageType.PORTFOLIO_UPDATE), Namespace = "")]
    public class PortfolioUpdateReply : ServerMessage
    {
        [DataMember(Name = "portfolio_name", Order = 1)]
        public string PortfolioName { get; set; }

        [DataMember(Name = "new_portfolio_name", Order = 2)]
        public string NewPortfolioName { get; set; }

        [DataMember(Name = "currency", Order = 3)]
        public string Currency { get; set; }
    }

    [DataContract(Name = nameof(MessageType.PORTFOLIO_ZERO_CHANGE_VALUES), Namespace = "")]
    public class PortfolioZeroChangeValuesReply : ServerMessage
    {
        [DataMember(Name = "portfolio_name")]
        public string PortfolioName { get; set; }
    }
}