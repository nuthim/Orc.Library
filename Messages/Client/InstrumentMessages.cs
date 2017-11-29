using System;
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
    [DataContract(Name = "instrument_attributes_set", Namespace = "")]
    public class InstrumentAttributesSetMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId Instrument { get; set; }

        [DataMember(Name = "instrument_attributes", IsRequired = true, Order = 2)]
        public InstrumentAttributes InstrumentAttributes { get; set; }

        public InstrumentAttributesSetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.instrument_attributes_set);
        }
    }

    /// <summary>
    /// Cleans-up expired contracts. The message calls the clean-up expired contracts functionality of the CDS and uses the optional expirydate argument.
    /// </summary>
    [DataContract(Name = "instrument_cleanup_expired", Namespace = "")]
    public class InstrumentCleanupExpiredMessage : ClientMessage
    {
        [DataMember(Name = "expirydate")]
        public DateTime? ExpiryDate { get; set; }

        public InstrumentCleanupExpiredMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.instrument_cleanup_expired);
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
    [DataContract(Name = "instrument_create", Namespace = "")]
    public class InstrumentCreateMessage : ClientMessage
    {
        [DataMember(Name = "instrument_attributes", IsRequired = true, Order = 1)]
        public InstrumentAttributes InstrumentAttributes { get; set; }

        [DataMember(Name = "parameters", Order = 2)]
        public Parameters Parameters { get; set; }

        public InstrumentCreateMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.instrument_create);
        }
    }

    /// <summary>
    /// Deletes an instrument. 
    /// <para>If you do not want the instrument resurrected ever, set market to [None] before deleting the instrument. 
    /// This can be done by using the message <see cref="InstrumentParametersSetMessage"/> InstrumentParametersSetMessage.
    /// </para>
    /// </summary>
    [DataContract(Name = "instrument_delete", Namespace = "")]
    public class InstrumentDeleteMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId Instrument { get; set; }

        [DataMember(Name = "error_if_basecontract", Order = 2)]
        public bool? ErrorIfBaseContract { get; set; }

        public InstrumentDeleteMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.instrument_delete);
        }
    }

    /// <summary>
    /// Get all instruments matching the values specified for the keys below. If there is no value for any key, all instruments will be fetched.
    /// <para>Set the items_per_message key to an integer number in order to split up the reply of this request into several messages. The messages 
    /// subsequent to the first reply will only contain the dictionary instrument_list.
    /// </para>
    /// </summary>
    [DataContract(Name = "instrument_download", Namespace = "")]
    public class InstrumentDownloadMessage : ClientMessage
    {
        [DataMember(Name = "basecontract", Order = 1)]
        public int? BaseContract { get; set; }

        [DataMember(Name = "assettype", Order = 2)]
        public AssetType? AssetType { get; set; }

        [DataMember(Name = "currency", Order = 3)]
        public string Currency { get; set; }

        [DataMember(Name = "customer_unique_id", Order = 4)]
        public string CustomerUniqueIdPattern { get; set; }

        [DataMember(Name = "download_mode", Order = 5)]
        public DownloadMode? DownloadMode { get; set; }

        [DataMember(Name = "enforced_customer_unique_id", Order = 6)]
        public string EnforcedCustomerUniqueIdPattern { get; set; }

        [DataMember(Name = "exchange", Order = 7)]
        public string Exchange { get; set; }

        [DataMember(Name = "expirydate_end", Order = 8)]
        public DateTime? ExpirydateEnd { get; set; }

        [DataMember(Name = "expirydate_start", Order = 9)]
        public DateTime? ExpirydateStart { get; set; }

        [DataMember(Name = "feedcode", Order = 10)]
        public string FeedCodePattern { get; set; }

        [DataMember(Name = "ignore_case", Order = 11)]
        public bool? IgnoreCase { get; set; }

        [DataMember(Name = "isincode", Order = 12)]
        public string IsinCodePattern { get; set; }

        [DataMember(Name = "issuer", Order = 13)]
        public string Issuer { get; set; }

        [DataMember(Name = "is_clean_quoted", Order = 14)]
        public bool? IsCleanQuoted { get; set; }

        [DataMember(Name = "items_per_message", Order = 15)]
        public int? ItemsPerMessage { get; set; }

        [DataMember(Name = "kind", Order = 16)]
        public string Kind { get; set; }

        [DataMember(Name = "market", Order = 17)]
        public string Market { get; set; }

        [DataMember(Name = "strikeprice_max", Order = 18)]
        public double? StrikePriceMax { get; set; }

        [DataMember(Name = "strikeprice_min", Order = 19)]
        public double? StrikePriceMin { get; set; }

        [DataMember(Name = "submarket", Order = 20)]
        public string SubMarket { get; set; }

        [DataMember(Name = "suggest_volume_logic", Order = 21)]
        public SuggestVolumeLogic? SuggestVolumeLogic { get; set; }

        [DataMember(Name = "symbol", Order = 22)]
        public string Symbol { get; set; }

        [DataMember(Name = "tick_rule", Order = 23)]
        public string TickRule { get; set; }

        [DataMember(Name = "underlying", Order = 24)]
        public string UnderlyingPattern { get; set; }

        [DataMember(Name = "date_changed_from", Order = 25)]
        public DateTime? DateChangedFrom { get; set; }

        [DataMember(Name = "date_changed_to", Order = 26)]
        public DateTime? DateChangedTo { get; set; }

        [DataMember(Name = "time_changed_from", Order = 27)]
        public TimeSpan? TimeChangedFrom { get; set; }

        [DataMember(Name = "time_changed_to", Order = 28)]
        public TimeSpan? TimeChangedTo { get; set; }

        public InstrumentDownloadMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.instrument_download);
        }
    }

    /// <summary>
    /// Delete dynamic parameters for an instrument.
    /// </summary>
    [DataContract(Name = "instrument_dynamic_parameter_delete", Namespace = "")]
    public class InstrumentDynamicParameterDeleteMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId Instrument { get; set; }

        [DataMember(Name = "name", IsRequired = true, Order = 2)]
        public string ParameterName { get; set; }

        public InstrumentDynamicParameterDeleteMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.instrument_dynamic_parameter_delete);
        }
    }

    /// <summary>
    /// Insert dynamic parameters for an instrument.
    /// </summary>
    [DataContract(Name = "instrument_dynamic_parameters_set", Namespace = "")]
    public class InstrumentDynamicParametersSetMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId Instrument { get; set; }

        [DataMember(Name = "name", IsRequired = true, Order = 2)]
        public DynamicParameters Parameters { get; set; }

        public InstrumentDynamicParametersSetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.instrument_dynamic_parameters_set);
        }
    }

    /// <summary>
    /// Requests all information about a given instrument
    /// </summary>
    [DataContract(Name = "instrument_get", Namespace = "")]
    public class InstrumentGetMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", Order = 1)]
        public InstrumentId Instrument { get; set; }

        [DataMember(Name = "with_orc_description", Order = 2)]
        public bool RequestOrcDescription { get; set; }

        public InstrumentGetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.instrument_get);
        }
    }

    /// <summary>
    /// Get min and max values for all parameters for a selection of instruments.
    /// </summary>
    [DataContract(Name = "instrument_group_parameters_get", Namespace = "")]
    public class InstrumentGroupParametersGetMessage : ClientMessage
    {
        [DataMember(Name = "additional_data", Order = 2)]
        public bool? IgnoreCase { get; set; }

        [DataMember(Name = "assettype", Order = 3)]
        public AssetType? AssetType { get; set; }

        [DataMember(Name = "basecontract", Order = 4)]
        public int? BaseContract { get; set; }

        [DataMember(Name = "currency", Order = 5)]
        public string Currency { get; set; }

        [DataMember(Name = "customer_unique_id", Order = 6)]
        public string CustomerUniqueIdPattern { get; set; }

        [DataMember(Name = "enforced_customer_unique_id", Order = 7)]
        public string EnforcedCustomerUniqueIdPattern { get; set; }

        [DataMember(Name = "expirydate_start", Order = 8)]
        public DateTime? ExpirydateStart { get; set; }

        [DataMember(Name = "expirydate_end", Order = 9)]
        public DateTime? ExpirydateEnd { get; set; }

        [DataMember(Name = "isincode", Order = 10)]
        public string IsinCodePattern { get; set; }

        [DataMember(Name = "symbol", Order = 11)]
        public string Symbol { get; set; }

        [DataMember(Name = "exchange", Order = 12)]
        public string Exchange { get; set; }

        [DataMember(Name = "issuer", Order = 13)]
        public string Issuer { get; set; }

        [DataMember(Name = "kind", Order = 14)]
        public string Kind { get; set; }

        [DataMember(Name = "market", Order = 15)]
        public string Market { get; set; }

        [DataMember(Name = "strikeprice_min", Order = 16)]
        public double? StrikePriceMin { get; set; }

        [DataMember(Name = "strikeprice_max", Order = 17)]
        public double? StrikePriceMax { get; set; }

        [DataMember(Name = "symbol", Order = 18)]
        public string UnderlyingPattern { get; set; }

        public InstrumentGroupParametersGetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.instrument_group_parameters_get);
        }
    }

    /// <summary>
    /// Set parameters for a selection of instruments.
    /// <para>If you need to update contract parameters, it is recommended to use <see cref="InstrumentMultipleParameterSetMessage"/> 
    /// or <see cref="InstrumentMultipleFlagSetMessage"/> for best performance.
    /// </para>
    /// </summary>
    [DataContract(Name = "instrument_group_parameters_set", Namespace = "")]
    public class InstrumentGroupParametersSetMessage : ClientMessage
    {
        [DataMember(Name = "parameters", IsRequired = true, Order = 1)]
        public Parameters Parameters { get; set; }

        [DataMember(Name = "additional_data", Order = 2)]
        public bool? IgnoreCase { get; set; }

        [DataMember(Name = "assettype", Order = 3)]
        public AssetType? AssetType { get; set; }

        [DataMember(Name = "basecontract", Order = 4)]
        public int? BaseContract { get; set; }

        [DataMember(Name = "currency", Order = 5)]
        public string Currency { get; set; }

        [DataMember(Name = "customer_unique_id", Order = 6)]
        public string CustomerUniqueIdPattern { get; set; }

        [DataMember(Name = "enforced_customer_unique_id", Order = 7)]
        public string EnforcedCustomerUniqueIdPattern { get; set; }

        [DataMember(Name = "expirydate_start", Order = 8)]
        public DateTime? ExpirydateStart { get; set; }

        [DataMember(Name = "expirydate_end", Order = 9)]
        public DateTime? ExpirydateEnd { get; set; }

        [DataMember(Name = "isincode", Order = 10)]
        public string IsinCodePattern { get; set; }

        [DataMember(Name = "symbol", Order = 11)]
        public string Symbol { get; set; }

        [DataMember(Name = "exchange", Order = 12)]
        public string Exchange { get; set; }

        [DataMember(Name = "issuer", Order = 13)]
        public string Issuer { get; set; }

        [DataMember(Name = "kind", Order = 14)]
        public string Kind { get; set; }

        [DataMember(Name = "market", Order = 15)]
        public string Market { get; set; }

        [DataMember(Name = "strikeprice_min", Order = 16)]
        public double? StrikePriceMin { get; set; }

        [DataMember(Name = "strikeprice_max", Order = 17)]
        public double? StrikePriceMax { get; set; }

        [DataMember(Name = "underlying", Order = 18)]
        public string UnderlyingPattern { get; set; }

        [DataMember(Name = "date_changed_from", Order = 19)]
        public DateTime? DateChangedFrom { get; set; }

        [DataMember(Name = "date_changed_to", Order = 20)]
        public DateTime? DateChangedTo { get; set; }

        [DataMember(Name = "time_changed_from", Order = 21)]
        public TimeSpan? TimeChangedFrom { get; set; }

        [DataMember(Name = "time_changed_to", Order = 22)]
        public TimeSpan? TimeChangedTo { get; set; }

        public InstrumentGroupParametersSetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.instrument_group_parameters_set);
        }
    }

    /// <summary>
    /// Updates the automated trading settings for a specified list of contracts. 
    /// <para>This message has better performance compared to <see cref="InstrumentParametersSetMessage"/> and <see cref="InstrumentGroupParametersSetMessage"/> when it comes to updating parameters 
    /// for many contracts at the same time. Also note that the contract flags use the value type boolean (true/false) and thus differ from the <see cref="InstrumentMultipleParameterSetMessage"/>.
    /// </para>
    /// </summary>
    [DataContract(Name = "instrument_multiple_flag_set", Namespace = "")]
    public class InstrumentMultipleFlagSetMessage : ClientMessage
    {
        [DataMember(Name = "instrument_list", IsRequired = true, Order = 1)]
        public InstrumentList Instruments { get; set; }

        [DataMember(Name = "flag", IsRequired = true, Order = 2)]
        public Flag Flag { get; set; }

        [DataMember(Name = "value", IsRequired = true, Order = 3)]
        public bool? Value { get; set; }

        public InstrumentMultipleFlagSetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.instrument_multiple_flag_set);
        }
    }

    /// <summary>
    /// Updates one parameter at a time for the specified list of contracts. If one contract is not found, the other contracts are not updated. 
    /// <para>This message is only valid for number fields.This message has better performance compared to <see cref="InstrumentGroupParametersSetMessage"/> 
    /// when it comes to updating parameters for many contracts at the same time.
    /// </para>
    /// </summary>
    [DataContract(Name = "instrument_multiple_parameter_set", Namespace = "")]
    public class InstrumentMultipleParameterSetMessage : ClientMessage
    {
        [DataMember(Name = "instrument_list", IsRequired = true, Order = 1)]
        public InstrumentList Instruments { get; set; }

        [DataMember(Name = "parameter", IsRequired = true, Order = 2)]
        public Parameter Parameter { get; set; }

        [DataMember(Name = "value", IsRequired = true, Order = 3)]
        public double? Value { get; set; }

        [DataMember(Name = "parameter_update_type", Order = 4)]
        public ParameterUpdateType? UpdateType { get; set; }

        public InstrumentMultipleParameterSetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.instrument_multiple_parameter_set);
        }
    }

    /// <summary>
    /// Sets parameters (terms and conditions) for an instrument. 
    /// <para>If you need to update contract parameters, it is recommended to use <see cref="InstrumentMultipleParameterSetMessage"/> 
    /// or <see cref="InstrumentMultipleFlagSetMessage"/> for best performance.
    /// </para>
    /// </summary>
    [DataContract(Name = "instrument_parameters_set", Namespace = "")]
    public class InstrumentParametersSetMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true, Order = 1)]
        public InstrumentId Instrument { get; set; }

        [DataMember(Name = "parameters", IsRequired = true, Order = 2)]
        public Parameters Parameters { get; set; }

        public InstrumentParametersSetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.instrument_parameters_set);
        }
    }

    /// <summary>
    /// Set an instrument as the primary spot for an underlying.
    /// <para>When you create or download a new contract in the underlying, then the base contract of the new contract will be the underlying's primary spot.
    /// Note that setting the primary spot only affects what base contract is used for new contracts. Setting the primary spot does not in any way affect 
    /// already existing contracts in the underlying.
    /// </para>
    /// </summary>
    [DataContract(Name = "instrument_set_as_preferred", Namespace = "")]
    public class InstrumentSetAsPreferredMessage : ClientMessage
    {
        [DataMember(Name = "instrument_id", IsRequired = true)]
        public InstrumentId Instrument { get; set; }

        public InstrumentSetAsPreferredMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.instrument_set_as_preferred);
        }
    }

}