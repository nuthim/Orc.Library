using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using Orc.Library.Enums;
using Orc.Library.Dictionaries;

namespace Orc.Library.Messages.Client
{

    /// <summary>
    /// This message removes all positions for deleted contracts for the specified portfolio.
    /// </summary>
    [DataContract(Name = "PORTFOLIO_CLEANUP", Namespace = "")]
    public class PortfolioCleanupMessage : ClientMessage
    {
        /// <summary>
        /// The name of the portfolio in Orc
        /// </summary>
        [DataMember(Name = "portfolio_name", IsRequired = true)]
        [StringLength(51)]
        public string PortfolioName { get; set; }

        public PortfolioCleanupMessage() : base(MessageType.PORTFOLIO_CLEANUP)
        {

        }
    }

    /// <summary>
    /// Add a portfolio to a summation portfolio.
    /// </summary>
    [DataContract(Name = "PORTFOLIO_COMPONENT_ADD", Namespace = "")]
    public class PortfolioComponentAddMessage : ClientMessage
    {
        /// <summary>
        /// The name of the Orc summation portfolio
        /// </summary>
        [DataMember(Name = "portfolio_name", IsRequired = true, Order = 1)]
        [StringLength(51)]
        public string PortfolioName { get; set; }

        /// <summary>
        /// The name of the portfolio in Orc which currently is a component.
        /// </summary>
        [DataMember(Name = "component_name", IsRequired = true, Order = 2)]
        [StringLength(51)]
        public string ComponentName { get; set; }

        public PortfolioComponentAddMessage() : base(MessageType.PORTFOLIO_COMPONENT_ADD)
        {

        }
    }

    /// <summary>
    /// Remove a portfolio from a summation portfolio.
    /// </summary>
    [DataContract(Name = "PORTFOLIO_COMPONENT_REMOVE", Namespace = "")]
    public class PortfolioComponentRemoveMessage : ClientMessage
    {
        /// <summary>
        /// The name of the Orc summation portfolio
        /// </summary>
        [DataMember(Name = "portfolio_name", IsRequired = true, Order = 1)]
        [StringLength(51)]
        public string PortfolioName { get; set; }

        /// <summary>
        /// The name of the portfolio in Orc which currently is a component.
        /// </summary>
        [DataMember(Name = "component_name", IsRequired = true, Order = 2)]
        [StringLength(51)]
        public string ComponentName { get; set; }

        public PortfolioComponentRemoveMessage() : base(MessageType.PORTFOLIO_COMPONENT_REMOVE)
        {

        }
    }

    /// <summary>
    /// Create a new empty portfolio.
    /// </summary>
    [DataContract(Name = "PORTFOLIO_CREATE", Namespace = "")]
    public class PortfolioCreateMessage : ClientMessage
    {
        /// <summary>
        /// The name of the portfolio in Orc.
        /// </summary>
        [DataMember(Name = "portfolio_name", IsRequired = true, Order = 1)]
        [StringLength(51)]
        public string PortfolioName { get; set; }

        /// <summary>
        /// Default currency for portfolio positions in this portfolio. A three letter currency identifier.
        /// </summary>
        [DataMember(Name = "currency", Order = 2)]
        [StringLength(3, MinimumLength = 3)]
        public string DefaultCurrency { get; set; }

        /// <summary>
        /// Default: Allow orders.
        /// </summary>
        [DataMember(Name = "ordervalidate", Order = 3)]
        public OrderValidate? OrderValidate { get; set; }

        public PortfolioCreateMessage() : base(MessageType.PORTFOLIO_CREATE)
        {

        }
    }


    /// <summary>
    /// Delete a portfolio and its positions.
    /// </summary>
    [DataContract(Name = "PORTFOLIO_DELETE", Namespace = "")]
    public class PortfolioDeleteMessage : ClientMessage
    {
        /// <summary>
        /// The name of the portfolio in Orc.
        /// </summary>
        [DataMember(Name = "portfolio_name", IsRequired = true)]
        [StringLength(51)]
        public string PortfolioName { get; set; }

        public PortfolioDeleteMessage() : base(MessageType.PORTFOLIO_DELETE)
        {

        }
    }

    /// <summary>
    /// Get a portfolio and if it is a summation portfolio, also its portfolio components. 
    /// If the summation portfolio contains summation portfolios, you will not get these components, only the top level portfolio's components.
    /// </summary>
    [DataContract(Name = "PORTFOLIO_DESCRIBE", Namespace = "")]
    public class PortfolioDescribeMessage : ClientMessage
    {
        /// <summary>
        /// The name of the Orc portfolio
        /// </summary>
        [DataMember(Name = "portfolio_name", IsRequired = true)]
        [StringLength(51)]
        public string PortfolioName { get; set; }

        public PortfolioDescribeMessage() : base(MessageType.PORTFOLIO_DESCRIBE)
        {

        }
    }

    /// <summary>
    /// Get all portfolios.
    /// </summary>
    [DataContract(Name = "PORTFOLIO_DOWNLOAD", Namespace = "")]
    public class PortfolioDownloadMessage : ClientMessage
    {
        [DataMember(Name = "portfolio_name", Order = 1)]
        public string PortfolioNamePattern { get; set; }

        /// <summary>
        /// Default 'false'. Set this key to true in order to ignore the case of the string key in this message.
        /// </summary>
        [DataMember(Name = "ignore_case", Order = 2)]
        public bool? IgnoreCase { get; set; }

        /// <summary>
        /// Default 'false'. If set to true, you will not download deleted portfolios.
        /// </summary>
        [DataMember(Name = "ignore_deleted", Order = 3)]
        public bool? IgnoreDeleted { get; set; }

        public PortfolioDownloadMessage() : base(MessageType.PORTFOLIO_DOWNLOAD)
        {

        }
    }

    /// <summary>
    /// Remove all positions from a portfolio and leave the portfolio empty.
    /// </summary>
    [DataContract(Name = "PORTFOLIO_EMPTY", Namespace = "")]
    public class PortfolioEmptyMessage : ClientMessage
    {
        /// <summary>
        /// The name of the portfolio in Orc
        /// </summary>
        [DataMember(Name = "portfolio_name", IsRequired = true)]
        [StringLength(51)]
        public string PortfolioName { get; set; }

        public PortfolioEmptyMessage() : base(MessageType.PORTFOLIO_EMPTY)
        {

        }
    }


    /// <summary>
    /// Get all positions for a given portfolio.
    /// </summary>
    [DataContract(Name = "PORTFOLIO_GET", Namespace = "")]
    public class PortfolioGetMessage : ClientMessage
    {
        /// <summary>
        /// The name of the portfolio in Orc
        /// </summary>
        [DataMember(Name = "portfolio_name", IsRequired = true, Order = 1)]
        [StringLength(51)]
        public string PortfolioName { get; set; }

        /// <summary>
        /// Default false. If true, separates positions by settlement date.
        /// </summary>
        [DataMember(Name = "settlement_date_separate", Order = 2)]
        public bool? SeparateBySettlementDate { get; set; }

        /// <summary>
        /// Default false. If true, separates positions by buy/sell.
        /// </summary>
        [DataMember(Name = "buy_or_sell_separate", Order = 3)]
        public bool? SeparateByTradeSide { get; set; }

        /// <summary>
        /// When specified, only the position for that instrument will be fetched.
        /// </summary>
        [DataMember(Name = "instrument_id", Order = 4)]
        public InstrumentId InstrumentId { get; set; }

        /// <summary>
        /// Set this key in order to receive replies in several messages. Default behavior is that the Orc Protocol sends all replies in one message.
        /// If the reply is split up, this will also be indicated by the boolean flag more_replies in the reply_to dictionary.
        /// </summary>
        [DataMember(Name = "items_per_message", Order = 5)]
        public int? ItemsPerMessage { get; set; }

        public PortfolioGetMessage() : base(MessageType.PORTFOLIO_GET)
        {

        }
    }


    /// <summary>
    /// Remove the kind restrictions for a portfolio.
    /// </summary>
    [DataContract(Name = "PORTFOLIO_KIND_RESTRICTION_DELETE", Namespace = "")]
    public class PortfolioKindRestrictionDeleteMessage : ClientMessage
    {
        /// <summary>
        /// Name of portfolio with kind restrictions
        /// </summary>
        [DataMember(Name = "portfolio_name", IsRequired = true, Order = 1)]
        [StringLength(51)]
        public string PortfolioName { get; set; }

        [DataMember(Name = "kind", Order = 2)]
        public string Kind { get; set; }

        public PortfolioKindRestrictionDeleteMessage() : base(MessageType.PORTFOLIO_KIND_RESTRICTION_DELETE)
        {

        }
    }

    /// <summary>
    /// Get kind restrictions for a portfolio.
    /// </summary>
    [DataContract(Name = "PORTFOLIO_KIND_RESTRICTION_GET", Namespace = "")]
    public class PortfolioKindRestrictionGetMessage : ClientMessage
    {
        /// <summary>
        /// Name of portfolio to get kind restrictions
        /// </summary>
        [DataMember(Name = "portfolio_name")]
        [StringLength(51)]
        public string PortfolioName { get; set; }

        public PortfolioKindRestrictionGetMessage() : base(MessageType.PORTFOLIO_KIND_RESTRICTION_GET)
        {

        }
    }

    /// <summary>
    /// Insert a kind restriction for a portfolio.
    /// </summary>
    [DataContract(Name = "PORTFOLIO_KIND_RESTRICTION_INSERT", Namespace = "")]
    public class PortfolioKindRestrictionInsertMessage : ClientMessage
    {
        /// <summary>
        /// Portfolio for which the restriction is added.
        /// </summary>
        [DataMember(Name = "portfolio_name", IsRequired = true, Order = 1)]
        [StringLength(51)]
        public string PortfolioName { get; set; }

        [DataMember(Name = "kind", IsRequired = true, Order = 2)]
        public string Kind { get; set; }

        public PortfolioKindRestrictionInsertMessage() : base(MessageType.PORTFOLIO_KIND_RESTRICTION_INSERT)
        {

        }
    }

    /// <summary>
    /// Update a money/bookkeeping position for a portfolio (without having to add a transaction, which you have to if you use <see cref="MoneyInsertMessage"/>). 
    /// <para>This message will only update the sell side of the money position. Doing an absolute change, the sell side will be set to the specified 
    /// amount and the buy side will be zeroed.
    /// </para>
    /// </summary>
    [DataContract(Name = "PORTFOLIO_MONEY_POSITION_UPDATE", Namespace = "")]
    public class PortfolioMoneyPositionUpdateMessage : ClientMessage
    {
        [DataMember(Name = "kind", IsRequired = true, Order = 1)]
        public string Kind { get; set; }

        /// <summary>
        /// The name of the portfolio in Orc.
        /// </summary>
        [DataMember(Name = "portfolio_name", IsRequired = true, Order = 2)]
        [StringLength(51)]
        public string PortfolioName { get; set; }

        /// <summary>
        /// Have to be set if kind is "Carry", "Balance", "Lending" or "Coupon".
        /// </summary>
        [DataMember(Name = "underlying", Order = 3)]
        [StringLength(32)]
        public string Underlying { get; set; }

        [DataMember(Name = "amount", IsRequired = true, Order = 4)]
        public double? Amount { get; set; }

        /// <summary>
        /// A three letter currency identifier.
        /// </summary>
        [DataMember(Name = "currency", IsRequired = true, Order = 5)]
        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; }

        /// <summary>
        /// Set money position to the given amount. Default: false (Do delta change). When set to true, the buy side will be set to zero.
        /// </summary>
        [DataMember(Name = "absolute_change", Order = 6)]
        public bool? AbsoluteChange { get; set; }

        [DataMember(Name = "settlement_date", Order = 7)]
        public DateTime? SettlementDate { get; set; }

        public PortfolioMoneyPositionUpdateMessage() : base(MessageType.PORTFOLIO_MONEY_POSITION_UPDATE)
        {

        }
    }

    /// <summary>
    /// Update a portfolio position given by the portfolio_name and the instrument_id part of the portfolio_position directory
    /// </summary>
    [DataContract(Name = "PORTFOLIO_POSITION_UPDATE", Namespace = "")]
    public class PortfolioPositionUpdateMessage : ClientMessage
    {
        /// <summary>
        /// The name of the portfolio in Orc.
        /// </summary>
        [DataMember(Name = "portfolio_name", IsRequired = true, Order = 1)]
        [StringLength(51)]
        public string PortfolioName { get; set; }

        [DataMember(Name = "portfolio_position", IsRequired = true, Order = 2)]
        public PortfolioPosition PortfolioPosition { get; set; }

        /// <summary>
        /// false - Delta change (default). true - Absolute value update.
        /// </summary>
        [DataMember(Name = "absolute_change", Order = 3)]
        public bool? AbsoluteChange { get; set; }

        /// <summary>
        /// Default value is 'true', that is, to update cash. The key is automatically treated as set to 'true' if Trade Handling Service is used.
        /// </summary>
        [DataMember(Name = "update_cash", Order = 4)]
        public bool? UpdateCash { get; set; }

        public PortfolioPositionUpdateMessage() : base(MessageType.PORTFOLIO_POSITION_UPDATE)
        {

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
    [DataContract(Name = "PORTFOLIO_RESET", Namespace = "")]
    public class PortfolioResetMessage : ClientMessage
    {
        /// <summary>
        /// The name of the portfolio in Orc.
        /// </summary>
        [DataMember(Name = "portfolio_name", IsRequired = true, Order = 1)]
        [StringLength(51)]
        public string PortfolioName { get; set; }

        public PortfolioResetMessage() : base(MessageType.PORTFOLIO_RESET)
        {

        }
    }

    /// <summary>
    /// Get information on previously performed portfolio resets. The message allows returning the position snapshots for a particular portfolio.
    /// </summary>
    [DataContract(Name = "PORTFOLIO_RESET_GET", Namespace = "")]
    public class PortfolioResetGetMessage : ClientMessage
    {
        /// <summary>
        /// The name of the portfolio in Orc.
        /// </summary>
        [DataMember(Name = "portfolio", IsRequired = true)]
        [StringLength(51)]
        public string PortfolioName { get; set; }

        public PortfolioResetGetMessage() : base(MessageType.PORTFOLIO_RESET_GET)
        {

        }
    }

    /// <summary>
    /// Create a new empty summation portfolio.
    /// </summary>
    [DataContract(Name = "PORTFOLIO_SUMMATION_CREATE", Namespace = "")]
    public class PortfolioSummationCreateMessage : ClientMessage
    {
        /// <summary>
        /// The name of the portfolio in Orc.
        /// </summary>
        [DataMember(Name = "portfolio_name", IsRequired = true)]
        [StringLength(51)]
        public string PortfolioName { get; set; }

        public PortfolioSummationCreateMessage() : base(MessageType.PORTFOLIO_SUMMATION_CREATE)
        {

        }
    }


    /// <summary>
    /// Update an existing portfolio.
    /// </summary>
    [DataContract(Name = "PORTFOLIO_UPDATE", Namespace = "")]
    public class PortfolioUpdateMessage : ClientMessage
    {
        /// <summary>
        /// The name of the portfolio in Orc.
        /// </summary>
        [DataMember(Name = "portfolio_name", IsRequired = true, Order = 1)]
        [StringLength(51)]
        public string PortfolioName { get; set; }

        /// <summary>
        /// New name of the portfolio in Orc.
        /// </summary>
        [DataMember(Name = "new_portfolio_name", Order = 2)]
        public string NewPortfolioName { get; set; }

        /// <summary>
        /// Default currency for portfolio positions in this portfolio.
        /// </summary>
        [DataMember(Name = "currency", Order = 3)]
        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; }

        [DataMember(Name = "ordervalidate", Order = 4)]
        public OrderValidate? OrderValidate { get; set; }

        public PortfolioUpdateMessage() : base(MessageType.PORTFOLIO_UPDATE)
        {

        }
    }

    /// <summary>
    /// Zero the change_in_accrued, change_in_commission, change_in_invested, change_in_volume values of a portfolio. To also store values 
    /// of theoretical values needed to calculate profit/loss per day the message <see cref="PortfolioResetMessage"/> should be used instead.
    /// </summary>
    [DataContract(Name = "PORTFOLIO_ZERO_CHANGE_VALUES", Namespace = "")]
    public class PortfolioZeroChangeValuesMessage : ClientMessage
    {
        /// <summary>
        /// The name of the portfolio in Orc.
        /// </summary>
        [DataMember(Name = "portfolio_name", IsRequired = true)]
        [StringLength(51)]
        public string PortfolioName { get; set; }

        public PortfolioZeroChangeValuesMessage() : base(MessageType.PORTFOLIO_ZERO_CHANGE_VALUES)
        {

        }
    }
}