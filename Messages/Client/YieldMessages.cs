using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Client
{
    /// <summary>
    /// Set specified yield curve as default yield curve for the currency.
    /// </summary>
    [DataContract(Name = nameof(MessageType.YIELD_CURVE_DEFAULT), Namespace = "")]
    public class YieldCurveDefaultMessage : ClientMessage
    {
        /// <summary>
        /// The Orc name of the yield curve. Default: The default yield curve for the given currency.
        /// </summary>
        [DataMember(Name = "yield_name", IsRequired = true, Order = 1)]
        [StringLength(64)]
        public string YieldName { get; set; }

        /// <summary>
        /// A three letter currency identifier.
        /// </summary>
        [DataMember(Name = "currency", Order = 2)]
        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; }

        public YieldCurveDefaultMessage() : base(MessageType.YIELD_CURVE_DEFAULT)
        {

        }
    }

    /// <summary>
    /// Delete a given yield curve.
    /// </summary>
    [DataContract(Name = nameof(MessageType.YIELD_CURVE_DELETE), Namespace = "")]
    public class YieldCurveDeteteMessage : ClientMessage
    {
        /// <summary>
        /// The Orc name of the yield curve. 
        /// </summary>
        [DataMember(Name = "yield_name", IsRequired = true, Order = 1)]
        [StringLength(64)]
        public string YieldName { get; set; }

        /// <summary>
        /// A three letter currency identifier.
        /// </summary>
        [DataMember(Name = "currency", IsRequired = true, Order = 2)]
        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; }

        public YieldCurveDeteteMessage() : base(MessageType.YIELD_CURVE_DELETE)
        {

        }
    }

    /// <summary>
    /// Download all yield curves.
    /// </summary>
    [DataContract(Name = nameof(MessageType.YIELD_CURVE_DOWNLOAD), Namespace = "")]
    public class YieldCurveDownloadMessage : ClientMessage
    {
        public YieldCurveDownloadMessage() : base(MessageType.YIELD_CURVE_DOWNLOAD)
        {

        }
    }

    /// <summary>
    /// Get a specified yield curve.
    /// </summary>
    [DataContract(Name = nameof(MessageType.YIELD_CURVE_GET), Namespace = "")]
    public class YieldCurveGetMessage : ClientMessage
    {
        /// <summary>
        /// The Orc name of the yield curve. Default: The default yield curve for the given currency.
        /// </summary>
        [DataMember(Name = "yield_name", Order = 1)]
        [StringLength(64)]
        public string YieldName { get; set; }

        /// <summary>
        /// A three letter currency identifier.
        /// </summary>
        [DataMember(Name = "currency", IsRequired = true, Order = 2)]
        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; }

        public YieldCurveGetMessage() : base(MessageType.YIELD_CURVE_GET)
        {

        }
    }

    /// <summary>
    /// Inserts a new yield curve (identified by its name) into the Orc.
    /// </summary>
    [DataContract(Name = nameof(MessageType.YIELD_CURVE_INSERT), Namespace = "")]
    public class YieldCurveInsertMessage : ClientMessage
    {
        /// <summary>
        /// The Orc name of the yield curve. Default: The default yield curve for the given currency.
        /// </summary>
        [DataMember(Name = "yield_name", IsRequired = true, Order = 1)]
        [StringLength(64)]
        public string YieldName { get; set; }

        /// <summary>
        /// A three letter currency identifier.
        /// </summary>
        [DataMember(Name = "currency", IsRequired = true, Order = 2)]
        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; }

        [DataMember(Name = "yield_curve", IsRequired = true, Order = 3)]
        public YieldCurve YieldCurve { get; set; }

        public YieldCurveInsertMessage() : base(MessageType.YIELD_CURVE_INSERT)
        {

        }
    }

    /// <summary>
    /// Update a yield curve.
    /// </summary>
    [DataContract(Name = nameof(MessageType.YIELD_CURVE_UPDATE), Namespace = "")]
    public class YieldCurveUpdateMessage : ClientMessage
    {
        /// <summary>
        /// The Orc name of the yield curve. Default: The default yield curve for the given currency.
        /// </summary>
        [DataMember(Name = "yield_name", IsRequired = true, Order = 1)]
        [StringLength(64)]
        public string YieldName { get; set; }

        /// <summary>
        /// A three letter currency identifier.
        /// </summary>
        [DataMember(Name = "currency", IsRequired = true, Order = 2)]
        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; }

        [DataMember(Name = "yield_curve", IsRequired = true, Order = 3)]
        public YieldCurve YieldCurve { get; set; }

        public YieldCurveUpdateMessage() : base(MessageType.YIELD_CURVE_UPDATE)
        {

        }
    }
}
