using System;
using Orc.Library.Enums;
using System.Runtime.Serialization;
using Orc.Library.Dictionaries;

namespace Orc.Library.Messages.Client
{

    /// <summary>
    /// This message removes all positions for deleted contracts for the specified portfolio.
    /// </summary>
    [DataContract(Name = "portfolio_cleanup", Namespace = "")]
    public class PortfolioCleanupMessage : ClientMessage
    {
        [DataMember(Name = "portfolio_name", IsRequired = true)]
        public string PortfolioName { get; set; }

        public PortfolioCleanupMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.PORTFOLIO_CLEANUP);
        }
    }

    /// <summary>
    /// Add a portfolio to a summation portfolio.
    /// </summary>
    [DataContract(Name = "portfolio_component_add", Namespace = "")]
    public class PortfolioComponentAddMessage : ClientMessage
    {
        /// <summary>
        /// The name of the Orc summation portfolio
        /// </summary>
        [DataMember(Name = "portfolio_name", IsRequired = true, Order = 1)]
        public string PortfolioName { get; set; }

        /// <summary>
        /// The name of the portfolio in Orc which currently is a component.
        /// </summary>
        [DataMember(Name = "component_name", IsRequired = true, Order = 2)]
        public string ComponentName { get; set; }

        public PortfolioComponentAddMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.PORTFOLIO_COMPONENT_ADD);
        }
    }

    /// <summary>
    /// Remove a portfolio from a summation portfolio.
    /// </summary>
    [DataContract(Name = "portfolio_component_remove", Namespace = "")]
    public class PortfolioComponentRemoveMessage : ClientMessage
    {
        /// <summary>
        /// The name of the Orc summation portfolio
        /// </summary>
        [DataMember(Name = "portfolio_name", IsRequired = true, Order = 1)]
        public string PortfolioName { get; set; }

        /// <summary>
        /// The name of the portfolio in Orc which currently is a component.
        /// </summary>
        [DataMember(Name = "component_name", IsRequired = true, Order = 2)]
        public string ComponentName { get; set; }

        public PortfolioComponentRemoveMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.PORTFOLIO_COMPONENT_REMOVE);
        }
    }

    /// <summary>
    /// Create a new empty portfolio.
    /// </summary>
    [DataContract(Name = "portfolio_create", Namespace = "")]
    public class PortfolioCreateMessage : ClientMessage
    {
        [DataMember(Name = "portfolio_name", IsRequired = true, Order = 1)]
        public string PortfolioName { get; set; }

        /// <summary>
        /// Default currency for portfolio positions in this portfolio
        /// </summary>
        [DataMember(Name = "currency", Order = 2)]
        public string DefaultCurrency { get; set; }

        [DataMember(Name = "ordervalidate", Order = 3)]
        public OrderValidate? OrderValidate { get; set; }

        public PortfolioCreateMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.PORTFOLIO_CREATE);
        }
    }


    /// <summary>
    /// Delete a portfolio and its positions.
    /// </summary>
    [DataContract(Name = "portfolio_delete", Namespace = "")]
    public class PortfolioDeleteMessage : ClientMessage
    {
        [DataMember(Name = "portfolio_name", IsRequired = true)]
        public string PortfolioName { get; set; }

        public PortfolioDeleteMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.PORTFOLIO_DELETE);
        }
    }

    /// <summary>
    /// Get a portfolio and if it is a summation portfolio, also its portfolio components. 
    /// If the summation portfolio contains summation portfolios, you will not get these components, only the top level portfolio's components.
    /// </summary>
    [DataContract(Name = "portfolio_describe", Namespace = "")]
    public class PortfolioDescribeMessage : ClientMessage
    {
        [DataMember(Name = "portfolio_name", IsRequired = true)]
        public string PortfolioName { get; set; }

        public PortfolioDescribeMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.PORTFOLIO_DESCRIBE);
        }
    }

    /// <summary>
    /// Get all portfolios.
    /// </summary>
    [DataContract(Name = "portfolio_download", Namespace = "")]
    public class PortfolioDownloadMessage : ClientMessage
    {
        [DataMember(Name = "portfolio_name", Order = 1)]
        public string PortfolioNamePattern { get; set; }

        [DataMember(Name = "ignore_case", Order = 2)]
        public bool? IgnoreCase { get; set; }

        [DataMember(Name = "ignore_deleted", Order = 3)]
        public bool? IgnoreDeleted { get; set; }

        public PortfolioDownloadMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.PORTFOLIO_DOWNLOAD);
        }
    }

    /// <summary>
    /// Remove all positions from a portfolio and leave the portfolio empty.
    /// </summary>
    [DataContract(Name = "portfolio_empty", Namespace = "")]
    public class PortfolioEmptyMessage : ClientMessage
    {
        [DataMember(Name = "portfolio_name", IsRequired = true)]
        public string PortfolioName { get; set; }

        public PortfolioEmptyMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.PORTFOLIO_EMPTY);
        }
    }


    /// <summary>
    /// Get all positions for a given portfolio.
    /// </summary>
    [DataContract(Name = "portfolio_get", Namespace = "")]
    public class PortfolioGetMessage : ClientMessage
    {
        [DataMember(Name = "portfolio_name", IsRequired = true, Order = 1)]
        public string PortfolioName { get; set; }

        [DataMember(Name = "settlement_date_separate", Order = 2)]
        public bool? SeparateBySettlementDate { get; set; }

        [DataMember(Name = "buy_or_sell_separate", Order = 3)]
        public bool? SeparateByTradeSide { get; set; }

        [DataMember(Name = "instrument_id", Order = 4)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "items_per_message", Order = 5)]
        public int? ItemsPerMessage { get; set; }

        public PortfolioGetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.PORTFOLIO_GET);
        }
    }


    /// <summary>
    /// Remove the kind restrictions for a portfolio.
    /// </summary>
    [DataContract(Name = "portfolio_kind_restriction_delete", Namespace = "")]
    public class PortfolioKindRestrictionDeleteMessage : ClientMessage
    {
        [DataMember(Name = "portfolio_name", IsRequired = true, Order = 1)]
        public string PortfolioName { get; set; }

        [DataMember(Name = "kind", Order = 2)]
        public string Kind { get; set; }

        public PortfolioKindRestrictionDeleteMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.PORTFOLIO_KIND_RESTRICTION_DELETE);
        }
    }

    /// <summary>
    /// Get kind restrictions for a portfolio.
    /// </summary>
    [DataContract(Name = "portfolio_kind_restriction_get", Namespace = "")]
    public class PortfolioKindRestrictionGetMessage : ClientMessage
    {
        [DataMember(Name = "portfolio_name")]
        public string PortfolioName { get; set; }

        public PortfolioKindRestrictionGetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.PORTFOLIO_KIND_RESTRICTION_GET);
        }
    }

    /// <summary>
    /// Insert a kind restriction for a portfolio.
    /// </summary>
    [DataContract(Name = "portfolio_kind_restriction_insert", Namespace = "")]
    public class PortfolioKindRestrictionInsertMessage : ClientMessage
    {
        [DataMember(Name = "portfolio_name", IsRequired = true, Order = 1)]
        public string PortfolioName { get; set; }

        [DataMember(Name = "kind", IsRequired = true, Order = 2)]
        public string Kind { get; set; }

        public PortfolioKindRestrictionInsertMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.PORTFOLIO_KIND_RESTRICTION_INSERT);
        }
    }

    /// <summary>
    /// Update a money/bookkeeping position for a portfolio (without having to add a transaction, which you have to if you use <see cref="MoneyInsertMessage"/>). 
    /// <para>This message will only update the sell side of the money position. Doing an absolute change, the sell side will be set to the specified 
    /// amount and the buy side will be zeroed.
    /// </para>
    /// </summary>
    [DataContract(Name = "portfolio_money_position_update", Namespace = "")]
    public class PortfolioMoneyPositionUpdateMessage : ClientMessage
    {
        [DataMember(Name = "kind", IsRequired = true, Order = 1)]
        public string Kind { get; set; }

        [DataMember(Name = "portfolio_name", IsRequired = true, Order = 2)]
        public string PortfolioName { get; set; }

        [DataMember(Name = "underlying", Order = 3)]
        public string Underlying { get; set; }

        [DataMember(Name = "amount", IsRequired = true, Order = 4)]
        public double? Amount { get; set; }

        [DataMember(Name = "currency", IsRequired = true, Order = 5)]
        public string Currency { get; set; }

        [DataMember(Name = "absolute_change", Order = 6)]
        public bool? IsAbsoluteChange { get; set; }

        [DataMember(Name = "settlement_date", Order = 7)]
        public DateTime? SettlementDate { get; set; }

        public PortfolioMoneyPositionUpdateMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.PORTFOLIO_MONEY_POSITION_UPDATE);
        }
    }

    /// <summary>
    /// Update a portfolio position given by the portfolio_name and the instrument_id part of the portfolio_position directory
    /// </summary>
    [DataContract(Name = "portfolio_position_update", Namespace = "")]
    public class PortfolioPositionUpdateMessage : ClientMessage
    {
        [DataMember(Name = "portfolio_name", IsRequired = true, Order = 1)]
        public string PortfolioName { get; set; }

        [DataMember(Name = "portfolio_position", IsRequired = true, Order = 2)]
        public PortfolioPosition PortfolioPosition { get; set; }

        [DataMember(Name = "absolute_change", Order = 3)]
        public bool? IsAbsoluteChange { get; set; }

        [DataMember(Name = "update_cash", Order = 4)]
        public bool? UpdateCash { get; set; }

        public PortfolioPositionUpdateMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.PORTFOLIO_POSITION_UPDATE);
        }
    }

    /// <summary>
    /// Use to reset a portfolio. When resetting a portfolio, the values in the following fields of the portfolio positions are set to zero: 
    /// change_in_accrued, change_in_commission, change_in_invested and change_in_volume. In addition the current market and theoretical values are stored. 
    /// <para>Reset the portfolio every day to view your profit/loss per day. If a summation portfolio is specified reset is done for each of the normal 
    /// portfolios that the summation portfolio consists of. To only set change_in_accrued, change_in_commission, change_in_invested and change_in_volume 
    /// values to zero the message <see cref="PortfolioZeroChangeValuesMessage"/> can be used instead.
    /// </para>
    /// </summary>
    [DataContract(Name = "portfolio_reset", Namespace = "")]
    public class PortfolioResetMessage : ClientMessage
    {
        [DataMember(Name = "portfolio_name", IsRequired = true)]
        public string PortfolioName { get; set; }

        public PortfolioResetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.PORTFOLIO_RESET);
        }
    }

    /// <summary>
    /// Get information on previously performed portfolio resets. The message allows returning the position snapshots for a particular portfolio.
    /// </summary>
    [DataContract(Name = "portfolio_reset_get", Namespace = "")]
    public class PortfolioResetGetMessage : ClientMessage
    {
        [DataMember(Name = "portfolio", IsRequired = true)]
        public string PortfolioName { get; set; }

        public PortfolioResetGetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.PORTFOLIO_RESET_GET);
        }
    }

    /// <summary>
    /// Create a new empty summation portfolio.
    /// </summary>
    [DataContract(Name = "portfolio_summation_create", Namespace = "")]
    public class PortfolioSummationCreateMessage : ClientMessage
    {
        [DataMember(Name = "portfolio_name", IsRequired = true)]
        public string PortfolioName { get; set; }

        public PortfolioSummationCreateMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.PORTFOLIO_SUMMATION_CREATE);
        }
    }


    /// <summary>
    /// Update an existing portfolio.
    /// </summary>
    [DataContract(Name = "portfolio_update", Namespace = "")]
    public class PortfolioUpdateMessage : ClientMessage
    {
        [DataMember(Name = "portfolio_name", IsRequired = true, Order = 1)]
        public string PortfolioName { get; set; }

        [DataMember(Name = "new_portfolio_name", Order = 2)]
        public string NewPortfolioName { get; set; }

        [DataMember(Name = "currency", Order = 3)]
        public string Currency { get; set; }

        [DataMember(Name = "ordervalidate", Order = 4)]
        public OrderValidate? OrderValidate { get; set; }

        public PortfolioUpdateMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.PORTFOLIO_UPDATE);
        }
    }

    /// <summary>
    /// Zero the change_in_accrued, change_in_commission, change_in_invested, change_in_volume values of a portfolio. To also store values 
    /// of theoretical values needed to calculate profit/loss per day the message <see cref="PortfolioResetMessage"/> should be used instead.
    /// </summary>
    [DataContract(Name = "portfolio_zero_change_values", Namespace = "")]
    public class PortfolioZeroChangeValuesMessage : ClientMessage
    {
        [DataMember(Name = "portfolio_name", IsRequired = true)]
        public string PortfolioName { get; set; }

        public PortfolioZeroChangeValuesMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.PORTFOLIO_ZERO_CHANGE_VALUES);
        }
    }
}