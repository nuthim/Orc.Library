using System.Runtime.Serialization;
using Orc.Library.Dictionaries;

namespace Orc.Library.Messages.Server
{
    [DataContract(Name = "CUSTOMER_DELETE", Namespace = "")]
    public class CustomerDeleteReply : ServerMessage
    {
        [DataMember(Name = "customer_id")]
        public string CustomerId { get; set; }
    }

    [DataContract(Name = "CUSTOMER_FIELD_DELETE", Namespace = "")]
    public class CustomerFieldDeleteReply : ServerMessage
    {
        [DataMember(Name = "fieldname")]
        public string FieldName { get; set; }
    }

    [DataContract(Name = "CUSTOMER_FIELD_GET", Namespace = "")]
    public class CustomerFieldGetReply : ServerMessage
    {
        [DataMember(Name = "customer_fields")]
        public CustomerFields CustomerFields { get; set; }
    }

    [DataContract(Name = "CUSTOMER_FIELD_INSERT", Namespace = "")]
    public class CustomerFieldInsertReply : ServerMessage
    {
        [DataMember(Name = "fieldname")]
        public string FieldName { get; set; }
    }

    [DataContract(Name = "CUSTOMER_FIELD_UPDATE", Namespace = "")]
    public class CustomerFieldUpdateReply : ServerMessage
    {
        [DataMember(Name = "fieldname", Order = 1)]
        public string FieldName { get; set; }

        [DataMember(Name = "new_fieldname", Order = 2)]
        public string NewFieldName { get; set; }
    }

    [DataContract(Name = "CUSTOMER_GET", Namespace = "")]
    public class CustomerGetReply : ServerMessage
    {
        [DataMember(Name = "customer_ids")]
        public CustomerIds CustomerIds { get; set; }
    }

    [DataContract(Name = "CUSTOMER_INSERT", Namespace = "")]
    public class CustomerInsertReply : ServerMessage
    {
        [DataMember(Name = "customer_id")]
        public string CustomerId { get; set; }
    }

    [DataContract(Name = "CUSTOMER_UPDATE", Namespace = "")]
    public class CustomerUpdateReply : ServerMessage
    {
        [DataMember(Name = "customer_id", Order = 1)]
        public string CustomerId { get; set; }

        [DataMember(Name = "new_customer_id", Order = 2)]
        public string NewCustomerId { get; set; }
    }

    [DataContract(Name = "CUSTOMER_VALUE_DELETE", Namespace = "")]
    public class CustomerValueDeleteReply : ServerMessage
    {
        [DataMember(Name = "customer_id", Order = 1)]
        public string CustomerId { get; set; }

        [DataMember(Name = "fieldname", Order = 2)]
        public string FieldName { get; set; }
    }

    [DataContract(Name = "CUSTOMER_VALUE_GET", Namespace = "")]
    public class CustomerValueGetReply : ServerMessage
    {
        [DataMember(Name = "customer_id", Order = 1)]
        public string CustomerId { get; set; }

        [DataMember(Name = "fieldname_values", Order = 2)]
        public FieldNameValues FieldNameValues { get; set; }
    }

    [DataContract(Name = "CUSTOMER_VALUE_SEARCH", Namespace = "")]
    public class CustomerValueSearchReply : ServerMessage
    {
        [DataMember(Name = "customer_values")]
        public CustomerValues CustomerValues { get; set; }
    }

    [DataContract(Name = "CUSTOMER_VALUE_UPDATE", Namespace = "")]
    public class CustomerValueUpdateReply : ServerMessage
    {
        [DataMember(Name = "customer_id")]
        public string CustomerId { get; set; }
    }

    [DataContract(Name = "CUSTOMER_PORTFOLIO_DELETE", Namespace = "")]
    public class CustomerPortfolioDeleteReply : ServerMessage
    {
        [DataMember(Name = "customer_id", Order = 1)]
        public string CustomerId { get; set; }

        [DataMember(Name = "portfolio_name", Order = 2)]
        public string PortfolioName { get; set; }
    }

    [DataContract(Name = "CUSTOMER_PORTFOLIO_GET", Namespace = "")]
    public class CustomerPortfolioGetReply : ServerMessage
    {
        [DataMember(Name = "customer_portfolios")]
        public CustomerPortfolios CustomerPortfolios { get; set; }
    }

    [DataContract(Name = "CUSTOMER_PORTFOLIO_INSERT", Namespace = "")]
    public class CustomerPortfolioInsertReply : ServerMessage
    {
        [DataMember(Name = "customer_id", Order = 1)]
        public string CustomerId { get; set; }

        [DataMember(Name = "portfolio_name", Order = 2)]
        public string PortfolioName { get; set; }
    }
}
