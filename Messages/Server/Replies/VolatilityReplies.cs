using System;
using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Server.Replies
{
    [DataContract(Name = nameof(MessageType.VOLATILITY_GET), Namespace = "")]
    public class VolatilityGetReply : ServerMessage
    {
        [DataMember(Name = "surface_name", Order = 1)]
        public string SurfaceName { get; set; }

        [DataMember(Name = "underlying", Order = 2)]
        public string Underlying { get; set; }

        [DataMember(Name = "expirydate", Order = 3)]
        public DateTime? ExpiryDate { get; set; }

        [DataMember(Name = "atm_price", Order = 4)]
        public double? AtmPrice { get; set; }

        [DataMember(Name = "base_price", Order = 5)]
        public double? BasePrice { get; set; }

        [DataMember(Name = "theo_spot", Order = 6)]
        public double? TheoSpot { get; set; }

        [DataMember(Name = "strikeprice", Order = 7)]
        public double? StrikePrice { get; set; }

        [DataMember(Name = "volatility", Order = 8)]
        public double? Volatility { get; set; }
    }

    [DataContract(Name = nameof(MessageType.VOLATILITY_RAW_CURVE_INSERT), Namespace = "")]
    public class VolatilityRawCurveInsertReply : ServerMessage
    {
        [DataMember(Name = "surface_name")]
        public string SurfaceName { get; set; }
    }


    [DataContract(Name = nameof(MessageType.VOLATILITY_RAW_SURFACE_GET), Namespace = "")]
    public class VolatilityRawSurfaceGetReply : ServerMessage
    {
        [DataMember(Name = "surface_name", Order = 1)]
        public string SurfaceName { get; set; }

        [DataMember(Name = "model", Order = 2)]
        public string Model { get; set; }

        [DataMember(Name = "volatility_curves", Order = 3)]
        public VolatilityCurves VolatilityCurves { get; set; }

        [DataMember(Name = "reference_price_entries_per_underlying", Order = 4)]
        public ReferencePriceEntriesPerUnderlying ReferencePriceEntriesPerUnderlying { get; set; }
    }


    [DataContract(Name = nameof(MessageType.VOLATILITY_RAW_SURFACE_INSERT), Namespace = "")]
    public class VolatilityRawSurfaceInsertReply : ServerMessage
    {
        [DataMember(Name = "surface_name")]
        public string SurfaceName { get; set; }
    }

    
    [DataContract(Name = nameof(MessageType.VOLATILITY_SURFACE_DELETE), Namespace = "")]
    public class VolatilitySurfaceDeleteReply : ServerMessage
    {
        [DataMember(Name = "surface_name")]
        public string SurfaceName { get; set; }
    }

    [DataContract(Name = nameof(MessageType.VOLATILITY_SURFACE_INSERT), Namespace = "")]
    public class VolatilitySurfaceInsertReply : ServerMessage
    {
        [DataMember(Name = "surface_name")]
        public string SurfaceName { get; set; }
    }

    [DataContract(Name = nameof(MessageType.REFERENCE_PRICE_SET), Namespace = "")]
    public class ReferencePriceSetReply : ServerMessage
    {
        [DataMember(Name = "underlying", Order = 1)]
        public string Underlying { get; set; }

        [DataMember(Name = "surface_name", Order = 2)]
        public string SurfaceName { get; set; }
    }


    [DataContract(Name = nameof(MessageType.REFERENCE_PRICE_GET), Namespace = "")]
    public class ReferencePriceGetReply : ServerMessage
    {
        [DataMember(Name = "underlying", Order = 1)]
        public string Underlying { get; set; }

        [DataMember(Name = "surface_name", Order = 2)]
        public string SurfaceName { get; set; }

        [DataMember(Name = "reference_price_entries", Order = 3)]
        public ReferencePriceEntries ReferencePriceEntries { get; set; }
    }

    [DataContract(Name = nameof(MessageType.REFERENCE_PRICE_DOWNLOAD), Namespace = "")]
    public class ReferencePriceDownloadReply : ServerMessage
    {
        [DataMember(Name = "reference_price_downloads")]
        public ReferencePriceDownloads ReferencePriceDownloads { get; set; }
    }


    [DataContract(Name = nameof(MessageType.VOLATILITY_SURFACE_DOWNLOAD), Namespace = "")]
    public class VolatilitySurfaceDownloadReply : ServerMessage
    {
        [DataMember(Name = "surface_entries")]
        public SurfaceEntries SurfaceEntries { get; set; }
    }


    [DataContract(Name = nameof(MessageType.VOLATILITY_MODEL_DOWNLOAD), Namespace = "")]
    public class VolatilityModelDownloadReply : ServerMessage
    {
        [DataMember(Name = "volatility_models")]
        public VolatilityModels VolatilityModels { get; set; }
    }
}
