using System.Runtime.Serialization;


namespace Orc.Library.Enums
{

    [DataContract(Name = "order_request", Namespace = "")]
    public enum OrderRequest
    {
        /// <summary>
        /// Default
        /// </summary>
        [EnumMember]
        None,

        /// <summary>
        /// Activate request
        /// </summary>
        [EnumMember]
        Activate,

        /// <summary>
        /// Inactivate request
        /// </summary>
        [EnumMember]
        Inactivate,

        /// <summary>
        /// Option to send modify request for volume, price, portfolio, and validity keys instead of modifying them directly. This
        /// modification request can be accepted/rejected by Orc. Accepted means that the order is modified with new values.
        /// Rejected means that the order is not modified and keeps old values.
        /// </summary>
        [EnumMember]
        Modify,

        /// <summary>
        /// Delete request
        /// </summary>
        [EnumMember]
        Delete,

        /// <summary>
        /// Acknowledge request (order request)
        /// </summary>
        [EnumMember]
        Acknowledge
    }

}