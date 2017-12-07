using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Client
{
    /// <summary>
    /// Set specified yield curve as default yield curve for the currency.
    /// </summary>
    [DataContract(Name = "VOLATILITY_GET", Namespace = "")]
    public class VolatilityGetMessage : ClientMessage
    {
        /// <summary>
        /// The name of the volatility surface.
        /// </summary>
        [DataMember(Name = "surface_name", IsRequired = true, Order = 1)]
        [StringLength(128)]
        public string SurfaceName { get; set; }

        /// <summary>
        /// The Orc underlying name. This is needed for the reference price extraction
        /// </summary>
        [DataMember(Name = "underlying", IsRequired = true, Order = 2)]
        [StringLength(32)]
        public string Underlying { get; set; }

        /// <summary>
        /// The expiration date.
        /// </summary>
        [DataMember(Name = "expirydate", IsRequired = true, Order = 3)]
        [StringLength(32)]
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// One of atm_price, base_price or theo_spot needs to be specified. For the Wing model, atm_price should be specified.
        /// </summary>
        [DataMember(Name = "atm_price", Order = 4)]
        public double? AtmPrice { get; set; }

        /// <summary>
        /// One of atm_price, base_price or theo_spot needs to be specified. For the Wing model, atm_price should be specified.
        /// </summary>
        [DataMember(Name = "base_price", Order = 5)]
        public double? BasePrice { get; set; }

        /// <summary>
        /// One of atm_price, base_price or theo_spot needs to be specified. For the Wing model, atm_price should be specified.
        /// </summary>
        [DataMember(Name = "theo_spot", Order = 6)]
        public double? TheoSpot { get; set; }

        /// <summary>
        /// The strike price.
        /// </summary>
        [DataMember(Name = "strikeprice", IsRequired = true, Order = 7)]
        public double? StrikePrice { get; set; }

        public VolatilityGetMessage() : base(MessageType.VOLATILITY_GET)
        {

        }
    }

    /// <summary>
    /// Update a volatility surface in the database by inserting new volatility curves, using the internal format of the Orc System. 
    /// Update of reference prices is optional and new prices specified will replace all previous reference prices.
    /// </summary>
    [DataContract(Name = "VOLATILITY_RAW_CURVE_INSERT", Namespace = "")]
    public class VolatilityRawCurveInsertMessage : ClientMessage
    {
        /// <summary>
        /// The name of the volatility surface. Must be an existing surface.
        /// </summary>
        [DataMember(Name = "surface_name", IsRequired = true, Order = 1)]
        [StringLength(128)]
        public string SurfaceName { get; set; }

        /// <summary>
        /// The expiration date.
        /// </summary>
        [DataMember(Name = "volatility_curves", IsRequired = true, Order = 2)]
        public VolatilityCurves VolatilityCurves { get; set; }

        /// <summary>
        /// The underlying from which the underlying reference price is retrieved.
        /// </summary>
        [DataMember(Name = "underlying", Order = 3)]
        [StringLength(32)]
        public string Underlying { get; set; }


        [DataMember(Name = "reference_price_entries", Order = 4)]
        public ReferencePriceEntries ReferencePriceEntries { get; set; }


        [DataMember(Name = "reference_price_entries_per_underlying", Order = 5)]
        public ReferencePriceEntriesPerUnderlying ReferencePriceEntriesPerUnderlying { get; set; }


        public VolatilityRawCurveInsertMessage() : base(MessageType.VOLATILITY_RAW_CURVE_INSERT)
        {

        }
    }

    /// <summary>
    /// Get a volatility surface using the internal Orc System format.
    /// </summary>
    [DataContract(Name = "VOLATILITY_RAW_SURFACE_GET", Namespace = "")]
    public class VolatilityRawSurfaceGetMessage : ClientMessage
    {
        /// <summary>
        /// The name of the volatility surface. Must be an existing surface.
        /// </summary>
        [DataMember(Name = "surface_name", IsRequired = true, Order = 1)]
        [StringLength(128)]
        public string SurfaceName { get; set; }

        /// <summary>
        /// Default 'true'. Set this key to 'false' in order to remove unassociated underlyings from the reference_price_entries_per_underlying dictionary.
        /// </summary>
        [DataMember(Name = "all_ref_prices", Order = 2)]
        public bool? AllRefPrices { get; set; }

        public VolatilityRawSurfaceGetMessage() : base(MessageType.VOLATILITY_RAW_SURFACE_GET)
        {

        }
    }


    /// <summary>
    /// Insert a volatility surface into the database using the internal format of the Orc System. Refer to the Orc User Manual for more information.
    /// You must specify all curves of the surface (i.e. for all expiries).
    /// </summary>
    [DataContract(Name = "VOLATILITY_RAW_SURFACE_INSERT", Namespace = "")]
    public class VolatilityRawSurfaceInsertMessage : ClientMessage
    {
        /// <summary>
        /// The name of the volatility surface. 
        /// </summary>
        [DataMember(Name = "surface_name", IsRequired = true, Order = 1)]
        [StringLength(128)]
        public string SurfaceName { get; set; }

        /// <summary>
        /// Can be retrieved with <see cref="VolatilityModelDownloadMessage"/>
        /// </summary>
        [DataMember(Name = "model", IsRequired = true, Order = 2)]
        [StringLength(128)]
        public string Model { get; set; }

        [DataMember(Name = "volatility_curves", IsRequired = true, Order = 3)]
        public VolatilityCurves VolatilityCurves { get; set; }

        /// <summary>
        /// The underlying from which the underlying reference price is retrieved.
        /// </summary>
        [DataMember(Name = "underlying", Order = 4)]
        public string Underlying { get; set; }

        [DataMember(Name = "reference_price_entries", Order = 5)]
        public ReferencePriceEntries ReferencePriceEntries { get; set; }

        [DataMember(Name = "reference_price_entries_per_underlying", Order = 6)]
        public ReferencePriceEntriesPerUnderlying ReferencePriceEntriesPerUnderlying { get; set; }


        public VolatilityRawSurfaceInsertMessage() : base(MessageType.VOLATILITY_RAW_SURFACE_INSERT)
        {

        }
    }

    
    /// <summary>
    /// Delete the specified volatility surface.
    /// </summary>
    [DataContract(Name = "VOLATILITY_SURFACE_DELETE", Namespace = "")]
    public class VolatilitySurfaceDeleteMessage : ClientMessage
    {
        /// <summary>
        /// The name of the volatility surface. Must be an existing surface.
        /// </summary>
        [DataMember(Name = "surface_name", IsRequired = true)]
        [StringLength(128)]
        public string SurfaceName { get; set; }

        public VolatilitySurfaceDeleteMessage() : base(MessageType.VOLATILITY_SURFACE_DELETE)
        {

        }
    }

    /// <summary>
    /// Inserts a volatility surface for a specified underlying, which will be auto-fitted against the matrix of strike/volatilities passed in the 
    /// volatility_entries field. You can use this message to trigger an equivalent of the "Fit all implied vol" action in the Volatility Manager, by first 
    /// requesting the implied volatilities using the theoretical_calculation message, then using the volatility_surface_insert message to fit the 
    /// volatility surface.
    /// </summary>
    [DataContract(Name = "VOLATILITY_SURFACE_INSERT", Namespace = "")]
    public class VolatilitySurfaceInsertMessage : ClientMessage
    {
        /// <summary>
        /// Can be retrieved with <see cref="VolatilityModelDownloadMessage"/>
        /// </summary>
        [DataMember(Name = "model", IsRequired = true, Order = 1)]
        public string Model { get; set; }

        /// <summary>
        /// The name of the volatility surface. 
        /// </summary>
        [DataMember(Name = "surface_name", IsRequired = true, Order = 2)]
        [StringLength(128)]
        public string SurfaceName { get; set; }

        /// <summary>
        /// The underlying from which the underlying reference price is retrieved.
        /// </summary>
        [DataMember(Name = "underlying", IsRequired = true, Order = 3)]
        public string Underlying { get; set; }

        /// <summary>
        /// The base price.
        /// </summary>
        [DataMember(Name = "base_price", Order = 4)]
        public double? BasePrice { get; set; }

        /// <summary>
        /// This corresponds to checking "Fit all volatility curve parameters" in the Windows Inspector (Fitting view) 
        /// for the Volatility Manager in the Orc Trader. Default false.
        /// </summary>
        [DataMember(Name = "full_fit", Order = 5)]
        public bool? FullFit { get; set; }

        [DataMember(Name = "reference_price_entries", Order = 6)]
        public ReferencePriceEntries ReferencePriceEntries { get; set; }

        [DataMember(Name = "volatility_entries", IsRequired = true, Order = 7)]
        public VolatilityEntries VolatilityEntries { get; set; }

        public VolatilitySurfaceInsertMessage() : base(MessageType.VOLATILITY_SURFACE_INSERT)
        {

        }
    }

    [DataContract(Name = "REFERENCE_PRICE_SET", Namespace = "")]
    public class ReferencePriceSetMessage : ClientMessage
    {
        /// <summary>
        /// The underlying from which the reference price is to be set.
        /// </summary>
        [DataMember(Name = "underlying", IsRequired = true, Order = 1)]
        [StringLength(32)]
        public string Underlying { get; set; }

        /// <summary>
        /// The name of the surface. 
        /// </summary>
        [DataMember(Name = "surface_name", IsRequired = true, Order = 2)]
        [StringLength(128)]
        public string SurfaceName { get; set; }


        [DataMember(Name = "reference_price_entries", Order = 3)]
        public ReferencePriceEntries ReferencePriceEntries { get; set; }

        public ReferencePriceSetMessage() : base(MessageType.REFERENCE_PRICE_SET)
        {

        }
    }


    [DataContract(Name = "REFERENCE_PRICE_GET", Namespace = "")]
    public class ReferencePriceGetMessage : ClientMessage
    {
        /// <summary>
        /// The underlying for which the reference price is retrieved.
        /// </summary>
        [DataMember(Name = "underlying", IsRequired = true, Order = 1)]
        [StringLength(32)]
        public string Underlying { get; set; }

        /// <summary>
        /// The name of the surface. Note that the key is mandatory (as multiple surfaces are allowed for one underlying).
        /// </summary>
        [DataMember(Name = "surface_name", IsRequired = true, Order = 2)]
        [StringLength(128)]
        public string SurfaceName { get; set; }

        public ReferencePriceGetMessage() : base(MessageType.REFERENCE_PRICE_GET)
        {

        }
    }

    [DataContract(Name = "REFERENCE_PRICE_DOWNLOAD", Namespace = "")]
    public class ReferencePriceDownloadMessage : ClientMessage
    {
        public ReferencePriceDownloadMessage() : base(MessageType.REFERENCE_PRICE_DOWNLOAD)
        {

        }
    }


    [DataContract(Name = "VOLATILITY_SURFACE_DOWNLOAD", Namespace = "")]
    public class VolatilitySurfaceDownloadMessage : ClientMessage
    {
        public VolatilitySurfaceDownloadMessage() : base(MessageType.VOLATILITY_SURFACE_DOWNLOAD)
        {

        }
    }


    [DataContract(Name = "VOLATILITY_MODEL_DOWNLOAD", Namespace = "")]
    public class VolatilityModelDownloadMessage : ClientMessage
    {
        public VolatilityModelDownloadMessage() : base(MessageType.VOLATILITY_MODEL_DOWNLOAD)
        {

        }
    }
}
