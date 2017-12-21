using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Client
{
    /// <summary>
    /// Set attributes (some special terms and conditions) for an instrument.
    /// <para>This command should be used with extreme care. Changing attributes for instruments that are traded or exist in portfolios can 
    /// have unwanted effects. If this instrument is not used it should be safe to change attributes. You cannot change the asset type of an instrument.
    /// </para>
    /// </summary>
    [DataContract(Name = nameof(MessageType.INSTRUMENT_ATTRIBUTES_SET), Namespace = "")]
    public class InstrumentAttributesSetMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        /// <summary>
        /// All keys in the instrument_attributes dictionary are optional for this request.
        /// </summary>
        [DataMember(Name = "instrument_attributes", IsRequired = true, Order = 2)]
        public InstrumentAttributes InstrumentAttributes { get; set; }

        public InstrumentAttributesSetMessage() : base(MessageType.INSTRUMENT_ATTRIBUTES_SET)
        {

        }
    }

    /// <summary>
    /// Cleans-up expired contracts. The message calls the clean-up expired contracts functionality of the CDS and uses the optional expirydate argument.
    /// </summary>
    [DataContract(Name = nameof(MessageType.INSTRUMENT_CLEANUP_EXPIRED), Namespace = "")]
    public class InstrumentCleanupExpiredMessage : ClientMessage
    {
        /// <summary>
        /// The expiration date of the instrument
        /// </summary>
        [DataMember(Name = "expirydate")]
        public DateTime? ExpiryDate { get; set; }

        public InstrumentCleanupExpiredMessage() : base(MessageType.INSTRUMENT_CLEANUP_EXPIRED)
        {

        }
    }


    /// <summary>
    /// Create a new instrument with the given parameters. 
    /// <para>Deleted instruments still exist in the database. If you create an instrument which has a market and feedcode combination that 
    /// matches that of an already deleted instrument, no new instrument is created, but the existing deleted one is resurrected instead. 
    /// The following parameters and attributes will be updated for the resurrected instrument: strikeprice, expirydate, underlying, kind, 
    /// multiplier, price_multiplier, price_display, issuer, expirytype, isincode, cusip, valoren, sedol, symbol and exchange.
    /// </para>
    /// </summary>
    [DataContract(Name = nameof(MessageType.INSTRUMENT_CREATE), Namespace = "")]
    public class InstrumentCreateMessage : ClientMessage
    {
        [DataMember(Name = "instrument_attributes", IsRequired = true, Order = 1)]
        public InstrumentAttributes InstrumentAttributes { get; set; }

        [DataMember(Name = "parameters", Order = 2)]
        public Parameters Parameters { get; set; }

        public InstrumentCreateMessage() : base(MessageType.INSTRUMENT_CREATE)
        {

        }
    }

    /// <summary>
    /// Deletes an instrument. 
    /// <para>If you do not want the instrument resurrected ever, set market to [None] before deleting the instrument. 
    /// This can be done by using the message <see cref="InstrumentParametersSetMessage"/> InstrumentParametersSetMessage.
    /// </para>
    /// </summary>
    [DataContract(Name = nameof(MessageType.INSTRUMENT_DELETE), Namespace = "")]
    public class InstrumentDeleteMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        /// <summary>
        /// Specify if you should get an error if the contract you want to delete is used as basecontract. Default: false.
        /// </summary>
        [DataMember(Name = "error_if_basecontract", Order = 2)]
        public bool? ErrorIfBaseContract { get; set; }

        public InstrumentDeleteMessage() : base(MessageType.INSTRUMENT_DELETE)
        {

        }
    }

    /// <summary>
    /// Get all instruments matching the values specified for the keys below. If there is no value for any key, all instruments will be fetched.
    /// <para>Set the items_per_message key to an integer number in order to split up the reply of this request into several messages. The messages 
    /// subsequent to the first reply will only contain the dictionary instrument_list.
    /// </para>
    /// </summary>
    [DataContract(Name = nameof(MessageType.INSTRUMENT_DOWNLOAD), Namespace = "")]
    public class InstrumentDownloadMessage : ClientMessage
    {
        /// <summary>
        /// Tag of basecontract to match.
        /// </summary>
        [DataMember(Name = "basecontract", Order = 1)]
        public int? BaseContract { get; set; }

        /// <summary>
        /// This key enables selective download of instruments of one asset type.
        /// </summary>
        [DataMember(Name = "assettype", Order = 2)]
        public AssetType? AssetType { get; set; }

        /// <summary>
        /// This key enables selective download of instruments of one currency
        /// </summary>
        [DataMember(Name = "currency", Order = 3)]
        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; }

        [DataMember(Name = "customer_unique_id", Order = 4)]
        [StringLength(64)]
        public string CustomerUniqueIdPattern { get; set; }

        [DataMember(Name = "download_mode", Order = 5)]
        public DownloadMode? DownloadMode { get; set; }

        [DataMember(Name = "enforced_customer_unique_id", Order = 6)]
        public string EnforcedCustomerUniqueIdPattern { get; set; }

        /// <summary>
        /// Reuters Exchange Mnemonic.
        /// </summary>
        [DataMember(Name = "exchange", Order = 7)]
        [StringLength(3, MinimumLength = 3)]
        public string Exchange { get; set; }

        /// <summary>
        /// Last expirydate to match
        /// </summary>
        [DataMember(Name = "expirydate_end", Order = 8)]
        public DateTime? ExpiryDateEnd { get; set; }

        /// <summary>
        /// First expirydate to match
        /// </summary>
        [DataMember(Name = "expirydate_start", Order = 9)]
        public DateTime? ExpiryDateStart { get; set; }

        [DataMember(Name = "feedcode", Order = 10)]
        [StringLength(32)]
        public string FeedCodePattern { get; set; }

        /// <summary>
        /// Set this key to 'true' in order to download instruments ignoring the case for the string based keys. Default is 'false'.
        /// </summary>
        [DataMember(Name = "ignore_case", Order = 11)]
        public bool? IgnoreCase { get; set; }

        [DataMember(Name = "isincode", Order = 12)]
        [StringLength(16)]
        public string IsinCodePattern { get; set; }

        [DataMember(Name = "issuer", Order = 13)]
        public string Issuer { get; set; }

        /// <summary>
        /// If true, quote the contract selection in clean price. Else, include the accrued interest rate of the contract in the quoted price.
        /// </summary>
        [DataMember(Name = "is_clean_quoted", Order = 14)]
        public bool? IsCleanQuoted { get; set; }

        /// <summary>
        /// Set this key in order to receive replies in several messages. Default behaviour is that the Orc Protocol sends all replies in one message.
        /// The recommended value for this key is 1000. If the reply is split up, this will also be indicated by the boolean flag more_replies in the reply_to dictionary.
        /// </summary>
        [DataMember(Name = "items_per_message", Order = 15)]
        public int? ItemsPerMessage { get; set; }

        [DataMember(Name = "kind", Order = 16)]
        public string Kind { get; set; }

        [DataMember(Name = "market", Order = 17)]
        public string Market { get; set; }

        /// <summary>
        /// Max strikeprice to match
        /// </summary>
        [DataMember(Name = "strikeprice_max", Order = 18)]
        public double? StrikePriceMax { get; set; }

        /// <summary>
        /// Min strikeprice to match
        /// </summary>
        [DataMember(Name = "strikeprice_min", Order = 19)]
        public double? StrikePriceMin { get; set; }

        /// <summary>
        /// Applicable on markets with submarkets. Use this key to limit the downloaded information to only one submarket.
        /// </summary>
        [DataMember(Name = "submarket", Order = 20)]
        public string SubMarket { get; set; }

        [DataMember(Name = "suggest_volume_logic", Order = 21)]
        public SuggestVolumeLogic? SuggestVolumeLogic { get; set; }

        [DataMember(Name = "symbol", Order = 22)]
        [StringLength(32)]
        public string Symbol { get; set; }

        /// <summary>
        /// The name of a tick rule.
        /// </summary>
        [DataMember(Name = "tick_rule", Order = 23)]
        public string TickRule { get; set; }

        [DataMember(Name = "underlying", Order = 24)]
        [StringLength(32)]
        public string UnderlyingPattern { get; set; }

        /// <summary>
        /// To only download instruments that have been created or modified within the specified time period.
        /// _to defaults to now and _from defaults to include the first created instrument.
        /// </summary>
        [DataMember(Name = "date_changed_from", Order = 25)]
        public DateTime? DateChangedFrom { get; set; }

        [DataMember(Name = "date_changed_to", Order = 26)]
        public DateTime? DateChangedTo { get; set; }

        [DataMember(Name = "time_changed_from", Order = 27)]
        public TimeSpan? TimeChangedFrom { get; set; }

        [DataMember(Name = "time_changed_to", Order = 28)]
        public TimeSpan? TimeChangedTo { get; set; }

        public InstrumentDownloadMessage() : base(MessageType.INSTRUMENT_DOWNLOAD)
        {

        }
    }

    /// <summary>
    /// Delete dynamic parameters for an instrument.
    /// </summary>
    [DataContract(Name = nameof(MessageType.INSTRUMENT_DYNAMIC_PARAMETER_DELETE), Namespace = "")]
    public class InstrumentDynamicParameterDeleteMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        /// <summary>
        /// The name of the dynamic parameter.
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, Order = 2)]
        public string Name { get; set; }

        public InstrumentDynamicParameterDeleteMessage() : base(MessageType.INSTRUMENT_DYNAMIC_PARAMETER_DELETE)
        {

        }
    }

    /// <summary>
    /// Insert dynamic parameters for an instrument.
    /// </summary>
    [DataContract(Name = nameof(MessageType.INSTRUMENT_DYNAMIC_PARAMETERS_SET), Namespace = "")]
    public class InstrumentDynamicParametersSetMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "dynamic_parameters", IsRequired = true, Order = 2)]
        public DynamicParameters DynamicParameters { get; set; }

        public InstrumentDynamicParametersSetMessage() : base(MessageType.INSTRUMENT_DYNAMIC_PARAMETERS_SET)
        {

        }
    }

    /// <summary>
    /// Requests all information about a given instrument
    /// </summary>
    [DataContract(Name = nameof(MessageType.INSTRUMENT_GET), Namespace = "")]
    public class InstrumentGetMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        /// <summary>
        /// Request the Orcs description of the contract from the connected Orc. Default: false
        /// </summary>
        [DataMember(Name = "with_orc_description", Order = 2)]
        public bool? WithOrcDescription { get; set; }

        public InstrumentGetMessage() : base( MessageType.INSTRUMENT_GET)
        {

        }
    }

    /// <summary>
    /// Get min and max values for all parameters for a selection of instruments.
    /// </summary>
    [DataContract(Name = nameof(MessageType.INSTRUMENT_GROUP_PARAMETERS_GET), Namespace = "")]
    public class InstrumentGroupParametersGetMessage : ClientMessage
    {
        /// <summary>
        /// Set this key to 'true' in order to ignore the case for string based keys in this message. Default is 'false'.
        /// </summary>
        [DataMember(Name = "additional_data", Order = 2)]
        public bool? AdditionalData { get; set; }

        /// <summary>
        /// Set this string in order to get parameters for instruments of one single asset type.
        /// </summary>
        [DataMember(Name = "assettype", Order = 3)]
        public AssetType? AssetType { get; set; }

        /// <summary>
        /// Tag of basecontract to match.
        /// </summary>
        [DataMember(Name = "basecontract", Order = 4)]
        public int? BaseContract { get; set; }

        /// <summary>
        /// Set this string in order to get parameters for instruments of one single currency
        /// </summary>
        [DataMember(Name = "currency", Order = 5)]
        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; }

        [DataMember(Name = "customer_unique_id", Order = 6)]
        [StringLength(64)]
        public string CustomerUniqueIdPattern { get; set; }

        [DataMember(Name = "enforced_customer_unique_id", Order = 7)]
        public string EnforcedCustomerUniqueIdPattern { get; set; }

        /// <summary>
        /// First expirydate to match
        /// </summary>
        [DataMember(Name = "expirydate_start", Order = 8)]
        public DateTime? ExpiryDateStart { get; set; }

        /// <summary>
        /// Last expirydate to match
        /// </summary>
        [DataMember(Name = "expirydate_end", Order = 9)]
        public DateTime? ExpiryDateEnd { get; set; }

        [DataMember(Name = "isincode", Order = 10)]
        [StringLength(16)]
        public string IsinCodePattern { get; set; }

        [DataMember(Name = "symbol", Order = 11)]
        [StringLength(32)]
        public string Symbol { get; set; }
        
        /// <summary>
        /// Reuters Exchange Mnemonic.
        /// </summary>
        [DataMember(Name = "exchange", Order = 12)]
        [StringLength(3, MinimumLength = 3)]
        public string Exchange { get; set; }

        [DataMember(Name = "issuer", Order = 13)]
        public string Issuer { get; set; }

        [DataMember(Name = "kind", Order = 14)]
        public string Kind { get; set; }

        [DataMember(Name = "market", Order = 15)]
        public string Market { get; set; }

        /// <summary>
        /// Min strikeprice to match
        /// </summary>
        [DataMember(Name = "strikeprice_min", Order = 16)]
        public double? StrikePriceMin { get; set; }

        /// <summary>
        /// Max strikeprice to match
        /// </summary>
        [DataMember(Name = "strikeprice_max", Order = 17)]
        public double? StrikePriceMax { get; set; }

        [DataMember(Name = "underlying", Order = 18)]
        [StringLength(32)]
        public string UnderlyingPattern { get; set; }

        public InstrumentGroupParametersGetMessage() : base(MessageType.INSTRUMENT_GROUP_PARAMETERS_GET)
        {

        }
    }

    /// <summary>
    /// Set parameters for a selection of instruments.
    /// <para>If you need to update contract parameters, it is recommended to use <see cref="InstrumentMultipleParameterSetMessage"/> 
    /// or <see cref="InstrumentMultipleFlagSetMessage"/> for best performance.
    /// </para>
    /// </summary>
    [DataContract(Name = nameof(MessageType.INSTRUMENT_GROUP_PARAMETERS_SET), Namespace = "")]
    public class InstrumentGroupParametersSetMessage : ClientMessage
    {
        [DataMember(Name = "parameters", IsRequired = true, Order = 1)]
        public Parameters Parameters { get; set; }

        /// <summary>
        /// Set this key to 'true' in order to ignore the case for string based keys in this message. Default is 'false'.
        /// </summary>
        [DataMember(Name = "additional_data", Order = 2)]
        public bool? AdditionalData { get; set; }

        /// <summary>
        /// Set this string in order to set parameters for instruments of one single asset type.
        /// </summary>
        [DataMember(Name = "assettype", Order = 3)]
        public AssetType? AssetType { get; set; }

        /// <summary>
        /// Tag of basecontract to match.
        /// </summary>
        [DataMember(Name = "basecontract", Order = 4)]
        public int? BaseContract { get; set; }

        /// <summary>
        /// Set this string in order to set parameters for instruments of one single currency.
        /// </summary>
        [DataMember(Name = "currency", Order = 5)]
        [StringLength(3, MinimumLength = 3)]
        public string Currency { get; set; }

        [DataMember(Name = "customer_unique_id", Order = 6)]
        [StringLength(64)]
        public string CustomerUniqueIdPattern { get; set; }

        [DataMember(Name = "enforced_customer_unique_id", Order = 7)]
        public string EnforcedCustomerUniqueIdPattern { get; set; }

        /// <summary>
        /// First expirydate to match
        /// </summary>
        [DataMember(Name = "expirydate_start", Order = 8)]
        public DateTime? ExpiryDateStart { get; set; }

        /// <summary>
        /// Last expirydate to match
        /// </summary>
        [DataMember(Name = "expirydate_end", Order = 9)]
        public DateTime? ExpiryDateEnd { get; set; }

        [DataMember(Name = "isincode", Order = 10)]
        [StringLength(16)]
        public string IsinCodePattern { get; set; }

        /// <summary>
        /// A symbol string.
        /// </summary>
        [DataMember(Name = "symbol", Order = 11)]
        [StringLength(32)]
        public string Symbol { get; set; }

        /// <summary>
        /// Reuters Exchange Mnemonic
        /// </summary>
        [DataMember(Name = "exchange", Order = 12)]
        [StringLength(3, MinimumLength = 3)]
        public string Exchange { get; set; }

        [DataMember(Name = "issuer", Order = 13)]
        public string Issuer { get; set; }

        [DataMember(Name = "kind", Order = 14)]
        public string Kind { get; set; }

        [DataMember(Name = "market", Order = 15)]
        public string Market { get; set; }

        /// <summary>
        /// Min strikeprice to match
        /// </summary>
        [DataMember(Name = "strikeprice_min", Order = 16)]
        public double? StrikePriceMin { get; set; }

        /// <summary>
        /// Max strikeprice to match
        /// </summary>
        [DataMember(Name = "strikeprice_max", Order = 17)]
        public double? StrikePriceMax { get; set; }

        [DataMember(Name = "underlying", Order = 18)]
        [StringLength(32)]
        public string UnderlyingPattern { get; set; }

        /// <summary>
        /// To only include instruments that have been created or modified within the specified time period. 
        /// _to defaults to now and _from defaults to include the first created instrument.
        /// </summary>
        [DataMember(Name = "date_changed_from", Order = 19)]
        public DateTime? DateChangedFrom { get; set; }

        [DataMember(Name = "date_changed_to", Order = 20)]
        public DateTime? DateChangedTo { get; set; }

        [DataMember(Name = "time_changed_from", Order = 21)]
        public TimeSpan? TimeChangedFrom { get; set; }

        [DataMember(Name = "time_changed_to", Order = 22)]
        public TimeSpan? TimeChangedTo { get; set; }

        public InstrumentGroupParametersSetMessage() : base(MessageType.INSTRUMENT_GROUP_PARAMETERS_SET)
        {

        }
    }

    /// <summary>
    /// Updates the automated trading settings for a specified list of contracts. 
    /// <para>This message has better performance compared to <see cref="InstrumentParametersSetMessage"/> and <see cref="InstrumentGroupParametersSetMessage"/> when it comes to updating parameters 
    /// for many contracts at the same time. Also note that the contract flags use the value type boolean (true/false) and thus differ from the <see cref="InstrumentMultipleParameterSetMessage"/>.
    /// </para>
    /// </summary>
    [DataContract(Name = nameof(MessageType.INSTRUMENT_MULTIPLE_FLAG_SET), Namespace = "")]
    public class InstrumentMultipleFlagSetMessage : ClientMessage
    {
        /// <summary>
        /// List of the instruments to be updated. The maximum number of instruments for the instrument list is 1024.
        /// </summary>
        [DataMember(Name = "instrument_list", IsRequired = true, Order = 1)]
        public InstrumentList InstrumentList { get; set; }

        /// <summary>
        /// Name of the contract flag to be updated.
        /// </summary>
        [DataMember(Name = "flag", IsRequired = true, Order = 2)]
        public Flag? Flag { get; set; }

        /// <summary>
        /// Value of the flag to be updated.
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, Order = 3)]
        public bool? Value { get; set; }

        public InstrumentMultipleFlagSetMessage() : base(MessageType.INSTRUMENT_MULTIPLE_FLAG_SET)
        {

        }
    }

    /// <summary>
    /// Updates one parameter at a time for the specified list of contracts. If one contract is not found, the other contracts are not updated. 
    /// <para>This message is only valid for number fields.This message has better performance compared to <see cref="InstrumentGroupParametersSetMessage"/> 
    /// when it comes to updating parameters for many contracts at the same time.
    /// </para>
    /// </summary>
    [DataContract(Name = nameof(MessageType.INSTRUMENT_MULTIPLE_PARAMETER_SET), Namespace = "")]
    public class InstrumentMultipleParameterSetMessage : ClientMessage
    {
        /// <summary>
        /// List of the instruments to be updated. The maximum number of instruments for the instrument list is 1024.
        /// </summary>
        [DataMember(Name = "instrument_list", IsRequired = true, Order = 1)]
        public InstrumentList InstrumentList { get; set; }

        /// <summary>
        /// Name of the contract parameter to be updated.
        /// </summary>
        [DataMember(Name = "parameter", IsRequired = true, Order = 2)]
        public Parameter? Parameter { get; set; }

        /// <summary>
        /// Value of the parameter to be updated.
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, Order = 3)]
        public double? Value { get; set; }

        /// <summary>
        /// Update type. Default is "Absolute"
        /// </summary>
        [DataMember(Name = "parameter_update_type", Order = 4)]
        public ParameterUpdateType? UpdateType { get; set; }

        public InstrumentMultipleParameterSetMessage() : base(MessageType.INSTRUMENT_MULTIPLE_PARAMETER_SET)
        {

        }
    }

    /// <summary>
    /// Sets parameters (terms and conditions) for an instrument. 
    /// <para>If you need to update contract parameters, it is recommended to use <see cref="InstrumentMultipleParameterSetMessage"/> 
    /// or <see cref="InstrumentMultipleFlagSetMessage"/> for best performance.
    /// </para>
    /// </summary>
    [DataContract(Name = nameof(MessageType.INSTRUMENT_PARAMETERS_SET), Namespace = "")]
    public class InstrumentParametersSetMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "parameters", IsRequired = true, Order = 2)]
        public Parameters Parameters { get; set; }

        public InstrumentParametersSetMessage() : base(MessageType.INSTRUMENT_PARAMETERS_SET)
        {

        }
    }

    /// <summary>
    /// Set an instrument as the primary spot for an underlying.
    /// <para>When you create or download a new contract in the underlying, then the base contract of the new contract will be the underlying's primary spot.
    /// Note that setting the primary spot only affects what base contract is used for new contracts. Setting the primary spot does not in any way affect 
    /// already existing contracts in the underlying.
    /// </para>
    /// </summary>
    [DataContract(Name = nameof(MessageType.INSTRUMENT_SET_AS_PREFERRED), Namespace = "")]
    public class InstrumentSetAsPreferredMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true)]
        public InstrumentId InstrumentId { get; set; }

        public InstrumentSetAsPreferredMessage() : base(MessageType.INSTRUMENT_SET_AS_PREFERRED)
        {
            
        }
    }

}