using System;
using System.Runtime.Serialization;
using Orc.Library.Enums;
using Orc.Library.Dictionaries;

namespace Orc.Library.Messages.Client
{
    /// <summary>
    /// Delete a customerid and ALL associated values (information about what portfolios and all other values).
    /// </summary>
    [DataContract(Name = "customer_delete", Namespace = "")]
    public class CustomerDeleteMessage : ClientMessage
    {
        [DataMember(Name = "customer_id", IsRequired = true)]
        public string CustomerId { get; set; }

        public CustomerDeleteMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.CUSTOMER_DELETE);
        }
    }

    /// <summary>
    /// Delete a customer information field AND all existing values for this field.
    /// </summary>
    [DataContract(Name = "customer_field_delete", Namespace = "")]
    public class CustomerFieldDeleteMessage : ClientMessage
    {
        [DataMember(Name = "fieldname", IsRequired = true)]
        public string FieldName { get; set; }

        public CustomerFieldDeleteMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.CUSTOMER_FIELD_DELETE);
        }
    }

    /// <summary>
    /// Get all available customer information fields.
    /// </summary>
    [DataContract(Name = "customer_field_get", Namespace = "")]
    public class CustomerFieldGetMessage : ClientMessage
    {
        public CustomerFieldGetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.CUSTOMER_FIELD_GET);
        }
    }

    /// <summary>
    /// Insert a new customer information field. The mandatory field is not used by the Orc Protocol it is only to store information for a client application.
    /// </summary>
    [DataContract(Name = "customer_field_insert", Namespace = "")]
    public class CustomerFieldInsertMessage : ClientMessage
    {
        [DataMember(Name = "fieldname", IsRequired = true, Order = 1)]
        public string FieldName { get; set; }

        [DataMember(Name = "locked", Order = 2)]
        public bool? Locked { get; set; }

        [DataMember(Name = "order", Order = 3)]
        public int? Order { get; set; }

        public CustomerFieldInsertMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.CUSTOMER_FIELD_INSERT);
        }
    }

    /// <summary>
    /// Update a customer information field.
    /// </summary>
    [DataContract(Name = "customer_field_update", Namespace = "")]
    public class CustomerFieldUpdateMessage : ClientMessage
    {
        [DataMember(Name = "fieldname", IsRequired = true, Order = 1)]
        public string FieldName { get; set; }

        [DataMember(Name = "new_fieldname", Order = 2)]
        public string NewFieldName { get; set; }

        [DataMember(Name = "order", Order = 3)]
        public int? Order { get; set; }

        public CustomerFieldUpdateMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.CUSTOMER_FIELD_UPDATE);
        }
    }

    /// <summary>
    /// Get all customerids.
    /// </summary>
    [DataContract(Name = "customer_get", Namespace = "")]
    public class CustomerGetMessage : ClientMessage
    {
        [DataMember(Name = "customer_id", Order = 1)]
        public string CustomerId { get; set; }

        [DataMember(Name = "ignore_case", Order = 2)]
        public bool IgnoreCase { get; set; }

        public CustomerGetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.CUSTOMER_GET);
        }
    }

    /// <summary>
    /// Add a new customerid.
    /// </summary>
    [DataContract(Name = "customer_insert", Namespace = "")]
    public class CustomerInsertMessage : ClientMessage
    {
        [DataMember(Name = "customer_id", IsRequired = true)]
        public string CustomerId { get; set; }

        public CustomerInsertMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.CUSTOMER_INSERT);
        }
    }

    /// <summary>
    /// Change customerid to a new customerid, but keep all connections to portfolios and values.
    /// </summary>
    [DataContract(Name = "customer_update", Namespace = "")]
    public class CustomerUpdateMessage : ClientMessage
    {
        [DataMember(Name = "customer_id", IsRequired = true, Order = 1)]
        public string CustomerId { get; set; }

        [DataMember(Name = "new_customer_id", IsRequired = true, Order = 2)]
        public string NewCustomerId { get; set; }

        public CustomerUpdateMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.CUSTOMER_UPDATE);
        }
    }

    /// <summary>
    /// Delete all or one value for a customer
    /// </summary>
    [DataContract(Name = "customer_value_delete", Namespace = "")]
    public class CustomerValueDeleteMessage : ClientMessage
    {
        [DataMember(Name = "customer_id", IsRequired = true, Order = 1)]
        public string CustomerId { get; set; }

        [DataMember(Name = "fieldname", Order = 2)]
        public string FieldName { get; set; }

        public CustomerValueDeleteMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.CUSTOMER_VALUE_DELETE);
        }
    }

    /// <summary>
    /// Get all or one value(s) for a customer
    /// </summary>
    [DataContract(Name = "customer_value_get", Namespace = "")]
    public class CustomerValueGetMessage : ClientMessage
    {
        [DataMember(Name = "customer_id", IsRequired = true, Order = 1)]
        public string CustomerId { get; set; }

        [DataMember(Name = "fieldname", Order = 2)]
        public string FieldName { get; set; }

        public CustomerValueGetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.CUSTOMER_VALUE_GET);
        }
    }

    /// <summary>
    /// Search through all values.
    /// </summary>
    [DataContract(Name = "customer_value_search", Namespace = "")]
    public class CustomerValueSearchMessage : ClientMessage
    {
        [DataMember(Name = "customer_id", Order = 1)]
        public string CustomerId { get; set; }

        [DataMember(Name = "fieldname", Order = 2)]
        public string FieldName { get; set; }

        [DataMember(Name = "value", Order = 3)]
        public string Value { get; set; }

        /// <summary>
        /// Default is Containing
        /// </summary>
        [DataMember(Name = "search_mode", Order = 4)]
        public SearchMode Mode { get; set; }

        public CustomerValueSearchMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.CUSTOMER_VALUE_SEARCH);
            Mode = SearchMode.Containing;
        }
    }

    /// <summary>
    /// Update/insert values for a given customer
    /// </summary>
    [DataContract(Name = "customer_value_update", Namespace = "")]
    public class CustomerValueUpdateMessage : ClientMessage
    {
        [DataMember(Name = "customer_id", IsRequired = true, Order = 1)]
        public string CustomerId { get; set; }

        [DataMember(Name = "fieldname_values", IsRequired = true, Order = 2)]
        public FieldnameValues FieldNameValues { get; set; }

        public CustomerValueUpdateMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.CUSTOMER_VALUE_UPDATE);
        }
    }

    /// <summary>
    /// Delete all or one connection(s) between a customer and portfolio(s).
    /// </summary>
    [DataContract(Name = "calendar_portfolio_delete", Namespace = "")]
    public class CustomerPortfolioDeleteMessage : ClientMessage
    {
        [DataMember(Name = "customer_id", IsRequired = true, Order = 1)]
        public string CustomerId { get; set; }

        [DataMember(Name = "portfolio_name", Order = 2)]
        public string PortfolioName { get; set; }

        public CustomerPortfolioDeleteMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.CUSTOMER_PORTFOLIO_DELETE);
        }
    }

    /// <summary>
    /// Get customer/portfolio connections.
    /// </summary>
    [DataContract(Name = "customer_portfolio_get", Namespace = "")]
    public class CustomerPortfolioGetMessage : ClientMessage
    {
        [DataMember(Name = "customer_id", Order = 1)]
        public string CustomerId { get; set; }

        [DataMember(Name = "portfolio_name", Order = 2)]
        public string PortfolioName { get; set; }

        public CustomerPortfolioGetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.CUSTOMER_PORTFOLIO_GET);
        }
    }

    /// <summary>
    /// Insert a connection between a customer and a portfolio.
    /// </summary>
    [DataContract(Name = "customer_portfolio_insert", Namespace = "")]
    public class CustomerPortfolioInsertMessage : ClientMessage
    {
        [DataMember(Name = "customer_id", IsRequired = true, Order = 1)]
        public string CustomerId { get; set; }

        [DataMember(Name = "portfolio_name", IsRequired = true, Order = 2)]
        public string PortfolioName { get; set; }

        public CustomerPortfolioInsertMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.CUSTOMER_PORTFOLIO_INSERT);
        }
    }
}
