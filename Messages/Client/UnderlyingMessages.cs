using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Client
{
    /// <summary>
    /// Removes one or more underlying covariance entries.
    /// </summary>
    [DataContract(Name = "UNDERLYING_COVARIANCE_DELETE", Namespace = "")]
    public class UnderlyingCovarianceDeleteMessage : ClientMessage
    {
        /// <summary>
        /// Less than or equal to Underlying2
        /// </summary>
        [DataMember(Name = "underlying1", IsRequired = true, Order = 1)]
        [StringLength(32)]
        public string Underlying1 { get; set; }

        [DataMember(Name = "underlying2", IsRequired = true, Order = 2)]
        [StringLength(32)]
        public string Underlying2 { get; set; }

        [DataMember(Name = "days", Order = 3)]
        public int? Days { get; set; }

        public UnderlyingCovarianceDeleteMessage() : base(MessageType.UNDERLYING_COVARIANCE_DELETE)
        {

        }
    }


    /// <summary>
    /// Queries underlying covariance entries. 
    /// <param>Either specify no underlying(requesting all), two underlyings, or one underlying(underlying1). If only underlying1 is specified, all entries 
    /// where either underlying1 or underlying2 matches the specified underlying1 are returned.
    /// </param>
    /// </summary>
    [DataContract(Name = "UNDERLYING_COVARIANCE_GET", Namespace = "")]
    public class UnderlyingCovarianceGetMessage : ClientMessage
    {
        /// <summary>
        /// Less than or equal to Underlying2
        /// </summary>
        [DataMember(Name = "underlying1", Order = 1)]
        [StringLength(32)]
        public string Underlying1 { get; set; }

        [DataMember(Name = "underlying2", Order = 2)]
        [StringLength(32)]
        public string Underlying2 { get; set; }

        public UnderlyingCovarianceGetMessage() : base(MessageType.UNDERLYING_COVARIANCE_GET)
        {

        }
    }


    /// <summary>
    /// Updates (or adds if new) an underlying covariance entry.
    /// </summary>
    [DataContract(Name = "UNDERLYING_COVARIANCE_UPDATE", Namespace = "")]
    public class UnderlyingCovarianceUpdateMessage : ClientMessage
    {
        /// <summary>
        /// Less than or equal to Underlying2
        /// </summary>
        [DataMember(Name = "underlying1", IsRequired = true, Order = 1)]
        [StringLength(32)]
        public string Underlying1 { get; set; }

        [DataMember(Name = "underlying2", IsRequired = true, Order = 2)]
        [StringLength(32)]
        public string Underlying2 { get; set; }

        [DataMember(Name = "days", Order = 3)]
        public int? Days { get; set; }

        [DataMember(Name = "covariance", IsRequired = true, Order = 4)]
        public double? Covariance { get; set; }

        public UnderlyingCovarianceUpdateMessage() : base(MessageType.UNDERLYING_COVARIANCE_UPDATE)
        {

        }
    }


    /// <summary>
    /// Download underlyings
    /// </summary>
    [DataContract(Name = "UNDERLYING_DOWNLOAD", Namespace = "")]
    public class UnderlyingDownloadMessage : ClientMessage
    {
        /// <summary>
        /// This key enables selective download of underlyings of one currency.
        /// </summary>
        [DataMember(Name = "currency", Order = 1)]
        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; }

        /// <summary>
        /// This key enables selective download of instruments of one asset type.
        /// </summary>
        [DataMember(Name = "assettype", IsRequired = true, Order = 2)]
        public AssetType? AssetType { get; set; }

        public UnderlyingDownloadMessage() : base(MessageType.UNDERLYING_DOWNLOAD)
        {

        }
    }


    /// <summary>
    /// Delete an underlying rate curve.
    /// </summary>
    [DataContract(Name = "UNDERLYING_RATECURVE_DELETE", Namespace = "")]
    public class UnderlyingRateCurveDeleteMessage : ClientMessage
    {
        /// <summary>
        /// Name of underlying
        /// </summary>
        [DataMember(Name = "underlying", IsRequired = true, Order = 1)]
        [StringLength(32)]
        public string Underlying { get; set; }


        [DataMember(Name = "type", IsRequired = true, Order = 2)]
        public DateOrDays? Type { get; set; }

        /// <summary>
        /// Only the key matching the Type will be read. i.e. if Type is "Date" the Date key is read, if it is set.
        /// </summary>
        [DataMember(Name = "date", Order = 3)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Only the key matching the Type will be read. i.e. if Type is "Days" the Days key is read, if it is set.
        /// </summary>
        [DataMember(Name = "days", Order = 4)]
        public int? Days { get; set; }

        public UnderlyingRateCurveDeleteMessage() : base(MessageType.UNDERLYING_RATECURVE_DELETE)
        {

        }
    }

    /// <summary>
    /// Delete an underlying rate curve.
    /// </summary>
    [DataContract(Name = "UNDERLYING_RATECURVE_GET", Namespace = "")]
    public class UnderlyingRateCurveGetMessage : ClientMessage
    {
        /// <summary>
        /// Name of underlying
        /// </summary>
        [DataMember(Name = "underlying", IsRequired = true, Order = 1)]
        [StringLength(32)]
        public string Underlying { get; set; }

        /// <summary>
        /// Specify which curve to fetch. For each underlying there can be two curves in the CDS, one days and one date based.
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, Order = 2)]
        public DateOrDays? Type { get; set; }

        public UnderlyingRateCurveGetMessage() : base(MessageType.UNDERLYING_RATECURVE_GET)
        {

        }
    }


    /// <summary>
    /// Update an underlying rate curve.
    /// </summary>
    [DataContract(Name = "UNDERLYING_RATECURVE_UPDATE", Namespace = "")]
    public class UnderlyingRateCurveUpdateMessage : ClientMessage
    {
        /// <summary>
        /// Name of underlying
        /// </summary>
        [DataMember(Name = "underlying", IsRequired = true, Order = 1)]
        [StringLength(32)]
        public string Underlying { get; set; }

        [DataMember(Name = "type", IsRequired = true, Order = 2)]
        public DateOrDays? Type { get; set; }

        [DataMember(Name = "underlying_ratecurve_entries", IsRequired = true, Order = 3)]
        public UnderlyingRateCurveEntries UnderlyingRateCurveEntries { get; set; }

        public UnderlyingRateCurveUpdateMessage() : base(MessageType.UNDERLYING_RATECURVE_UPDATE)
        {

        }
    }

    /// <summary>
    /// This message enables you to set the beta and betabase of an underlying.
    /// </summary>
    [DataContract(Name = "UNDERLYING_UPDATE", Namespace = "")]
    public class UnderlyingUpdateMessage : ClientMessage
    {
        /// <summary>
        /// Name of underlying
        /// </summary>
        [DataMember(Name = "underlying", IsRequired = true, Order = 1)]
        [StringLength(32)]
        public string Underlying { get; set; }

        /// <summary>
        /// Value 'None' (default) or 'Black'.
        /// </summary>
        [DataMember(Name = "restriction", Order = 2)]
        public UnderlyingRestriction? Restriction { get; set; }

        [DataMember(Name = "betabase", Order = 3)]
        public InstrumentId BetaBase { get; set; }

        [DataMember(Name = "beta_logic", Order = 4)]
        public BetaLogic? BetaLogic { get; set; }

        /// <summary>
        /// A three letter currency identifier. Must be specified if the underlying do not exist.
        /// </summary>
        [DataMember(Name = "currency", Order = 5)]
        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; }

        [DataMember(Name = "riskunderlying", Order = 6)]
        [StringLength(32)]
        public string RiskUnderlying { get; set; }

        /// <summary>
        /// To set an underlying to not have a volatility surface, set this key to "[none]".
        /// </summary>
        [DataMember(Name = "quote_volatility_surface", Order = 7)]
        [StringLength(128)]
        public string QuoteVolatilitySurface { get; set; }

        /// <summary>
        /// To set an underlying to not have a volatility surface, set this key to "[none]".
        /// </summary>
        [DataMember(Name = "risk_volatility_surface", Order = 8)]
        [StringLength(128)]
        public string RiskVolatilitySurface { get; set; }

        [DataMember(Name = "strike_conversion", Order = 9)]
        public StrikeConversion? StrikeConversion { get; set; }

        [DataMember(Name = "beta", Order = 10)]
        public double? Beta { get; set; }

        public UnderlyingUpdateMessage() : base(MessageType.UNDERLYING_UPDATE)
        {

        }
    }

}
