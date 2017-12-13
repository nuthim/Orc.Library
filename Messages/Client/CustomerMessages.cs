using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Orc.Library.Enums;
using Orc.Library.Dictionaries;

namespace Orc.Library.Messages.Client
{
    /// <summary>
    /// Delete a customerid and ALL associated values (information about what portfolios and all other values).
    /// </summary>
    [DataContract(Name = nameof(MessageType.CUSTOMER_DELETE), Namespace = "")]
    public class CustomerDeleteMessage : ClientMessage
    {
        [DataMember(Name = "customer_id", IsRequired = true)]
        [StringLength(64)]
        public string CustomerId { get; set; }

        public CustomerDeleteMessage() : base(MessageType.CUSTOMER_DELETE)
        {
            
        }
    }

    /// <summary>
    /// Delete a customer information field AND all existing values for this field.
    /// </summary>
    [DataContract(Name = nameof(MessageType.CUSTOMER_FIELD_DELETE), Namespace = "")]
    public class CustomerFieldDeleteMessage : ClientMessage
    {
        [DataMember(Name = "fieldname", IsRequired = true)]
        [StringLength(64)]
        public string FieldName { get; set; }

        public CustomerFieldDeleteMessage() : base(MessageType.CUSTOMER_FIELD_DELETE)
        {

        }
    }

    /// <summary>
    /// Get all available customer information fields.
    /// </summary>
    [DataContract(Name = nameof(MessageType.CUSTOMER_FIELD_GET), Namespace = "")]
    public class CustomerFieldGetMessage : ClientMessage
    {
        public CustomerFieldGetMessage() : base(MessageType.CUSTOMER_FIELD_GET)
        {

        }
    }

    /// <summary>
    /// Insert a new customer information field. 
    /// </summary>
    [DataContract(Name = nameof(MessageType.CUSTOMER_FIELD_INSERT), Namespace = "")]
    public class CustomerFieldInsertMessage : ClientMessage
    {
        [DataMember(Name = "fieldname", IsRequired = true, Order = 1)]
        [StringLength(64)]
        public string FieldName { get; set; }

        /// <summary>
        /// Default: false
        /// </summary>
        [DataMember(Name = "locked", Order = 2)]
        public bool? Locked { get; set; }

        /// <summary>
        /// Order of appearance in GUI. Default: 0
        /// </summary>
        [DataMember(Name = "order", Order = 3)]
        public int? Order { get; set; }

        public CustomerFieldInsertMessage() : base(MessageType.CUSTOMER_FIELD_INSERT)
        {

        }
    }

    /// <summary>
    /// Update a customer information field.
    /// </summary>
    [DataContract(Name = nameof(MessageType.CUSTOMER_FIELD_UPDATE), Namespace = "")]
    public class CustomerFieldUpdateMessage : ClientMessage
    {
        [DataMember(Name = "fieldname", IsRequired = true, Order = 1)]
        [StringLength(64)]
        public string FieldName { get; set; }

        [DataMember(Name = "new_fieldname", Order = 2)]
        [StringLength(64)]
        public string NewFieldName { get; set; }

        /// <summary>
        /// Order of appearance in GUI; 0 is first. Default: 0
        /// </summary>
        [DataMember(Name = "order", Order = 3)]
        public int? Order { get; set; }

        public CustomerFieldUpdateMessage() : base(MessageType.CUSTOMER_FIELD_UPDATE)
        {

        }
    }

    /// <summary>
    /// Get all customerids.
    /// </summary>
    [DataContract(Name = nameof(MessageType.CUSTOMER_GET), Namespace = "")]
    public class CustomerGetMessage : ClientMessage
    {
        /// <summary>
        /// This string accepts wild cards and other regular expressions, e.g. customer_id=jp*.
        /// </summary>
        [DataMember(Name = "customer_id", Order = 1)]
        [StringLength(64)]
        public string CustomerIdPattern { get; set; }

        /// <summary>
        /// Default 'false'. Set this key to true in order to ignore the case of the string key in this message.
        /// </summary>
        [DataMember(Name = "ignore_case", Order = 2)]
        public bool IgnoreCase { get; set; }

        public CustomerGetMessage() : base(MessageType.CUSTOMER_GET)
        {

        }
    }

    /// <summary>
    /// Add a new customerid.
    /// </summary>
    [DataContract(Name = nameof(MessageType.CUSTOMER_INSERT), Namespace = "")]
    public class CustomerInsertMessage : ClientMessage
    {
        [DataMember(Name = "customer_id", IsRequired = true)]
        [StringLength(64)]
        public string CustomerId { get; set; }

        public CustomerInsertMessage() : base(MessageType.CUSTOMER_INSERT)
        {

        }
    }

    /// <summary>
    /// Change customerid to a new customerid, but keep all connections to portfolios and values.
    /// </summary>
    [DataContract(Name = nameof(MessageType.CUSTOMER_UPDATE), Namespace = "")]
    public class CustomerUpdateMessage : ClientMessage
    {
        [DataMember(Name = "customer_id", IsRequired = true, Order = 1)]
        [StringLength(64)]
        public string CustomerId { get; set; }

        [DataMember(Name = "new_customer_id", IsRequired = true, Order = 2)]
        [StringLength(64)]
        public string NewCustomerId { get; set; }

        public CustomerUpdateMessage() : base(MessageType.CUSTOMER_UPDATE)
        {

        }
    }

    /// <summary>
    /// Delete all or one value for a customer
    /// </summary>
    [DataContract(Name = nameof(MessageType.CUSTOMER_VALUE_DELETE), Namespace = "")]
    public class CustomerValueDeleteMessage : ClientMessage
    {
        [DataMember(Name = "customer_id", IsRequired = true, Order = 1)]
        [StringLength(64)]
        public string CustomerId { get; set; }

        [DataMember(Name = "fieldname", Order = 2)]
        [StringLength(64)]
        public string FieldName { get; set; }

        public CustomerValueDeleteMessage() : base(MessageType.CUSTOMER_VALUE_DELETE)
        {

        }
    }

    /// <summary>
    /// Get all or one value(s) for a customer
    /// </summary>
    [DataContract(Name = nameof(MessageType.CUSTOMER_VALUE_GET), Namespace = "")]
    public class CustomerValueGetMessage : ClientMessage
    {
        [DataMember(Name = "customer_id", IsRequired = true, Order = 1)]
        [StringLength(64)]
        public string CustomerId { get; set; }

        [DataMember(Name = "fieldname", Order = 2)]
        [StringLength(64)]
        public string FieldName { get; set; }

        public CustomerValueGetMessage() : base(MessageType.CUSTOMER_VALUE_GET)
        {

        }
    }

    /// <summary>
    /// Search through all values.
    /// </summary>
    [DataContract(Name = nameof(MessageType.CUSTOMER_VALUE_SEARCH), Namespace = "")]
    public class CustomerValueSearchMessage : ClientMessage
    {
        [DataMember(Name = "customer_id", Order = 1)]
        [StringLength(64)]
        public string CustomerId { get; set; }

        [DataMember(Name = "fieldname", Order = 2)]
        [StringLength(64)]
        public string FieldName { get; set; }

        [DataMember(Name = "value", Order = 3)]
        [StringLength(128)]
        public string Value { get; set; }

        /// <summary>
        /// Default is Containing
        /// </summary>
        [DataMember(Name = "search_mode", Order = 4)]
        public SearchMode? Mode { get; set; }

        public CustomerValueSearchMessage() : base(MessageType.CUSTOMER_VALUE_SEARCH)
        {

        }
    }

    /// <summary>
    /// Update/insert values for a given customer
    /// </summary>
    [DataContract(Name = nameof(MessageType.CUSTOMER_VALUE_UPDATE), Namespace = "")]
    public class CustomerValueUpdateMessage : ClientMessage
    {
        [DataMember(Name = "customer_id", IsRequired = true, Order = 1)]
        [StringLength(64)]
        public string CustomerId { get; set; }

        [DataMember(Name = "fieldname_values", IsRequired = true, Order = 2)]
        public FieldNameValues FieldNameValues { get; set; }

        public CustomerValueUpdateMessage() : base(MessageType.CUSTOMER_VALUE_UPDATE)
        {

        }
    }

    /// <summary>
    /// Delete all or one connection(s) between a customer and portfolio(s).
    /// </summary>
    [DataContract(Name = nameof(MessageType.CUSTOMER_PORTFOLIO_DELETE), Namespace = "")]
    public class CustomerPortfolioDeleteMessage : ClientMessage
    {
        [DataMember(Name = "customer_id", IsRequired = true, Order = 1)]
        [StringLength(64)]
        public string CustomerId { get; set; }

        /// <summary>
        /// The name of the portfolio in the Orc
        /// </summary>
        [DataMember(Name = "portfolio_name", Order = 2)]
        [StringLength(51)]
        public string PortfolioName { get; set; }

        public CustomerPortfolioDeleteMessage() : base(MessageType.CUSTOMER_PORTFOLIO_DELETE)
        {

        }
    }

    /// <summary>
    /// Get customer/portfolio connections.
    /// </summary>
    [DataContract(Name = nameof(MessageType.CUSTOMER_PORTFOLIO_GET), Namespace = "")]
    public class CustomerPortfolioGetMessage : ClientMessage
    {
        [DataMember(Name = "customer_id", Order = 1)]
        [StringLength(64)]
        public string CustomerId { get; set; }

        /// <summary>
        /// The name of the portfolio in the Orc
        /// </summary>
        [DataMember(Name = "portfolio_name", Order = 2)]
        [StringLength(51)]
        public string PortfolioName { get; set; }

        public CustomerPortfolioGetMessage() : base(MessageType.CUSTOMER_PORTFOLIO_GET)
        {

        }
    }

    /// <summary>
    /// Insert a connection between a customer and a portfolio.
    /// </summary>
    [DataContract(Name = nameof(MessageType.CUSTOMER_PORTFOLIO_INSERT), Namespace = "")]
    public class CustomerPortfolioInsertMessage : ClientMessage
    {
        [DataMember(Name = "customer_id", IsRequired = true, Order = 1)]
        [StringLength(64)]
        public string CustomerId { get; set; }

        /// <summary>
        /// The name of the portfolio in the Orc
        /// </summary>
        [DataMember(Name = "portfolio_name", IsRequired = true, Order = 2)]
        [StringLength(51)]
        public string PortfolioName { get; set; }

        public CustomerPortfolioInsertMessage() : base(MessageType.CUSTOMER_PORTFOLIO_INSERT)
        {

        }
    }
}
