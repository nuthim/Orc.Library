using System;
using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;


namespace Orc.Library.Messages.Server
{
    [DataContract(Name = nameof(MessageType.INSTRUMENT_ATTRIBUTES_SET), Namespace = "")]
    public class InstrumentAttributesSetReply : ServerMessage
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }
    }

    [DataContract(Name = nameof(MessageType.INSTRUMENT_CLEANUP_EXPIRED), Namespace = "")]
    public class InstrumentCleanupExpiredReply : ServerMessage
    {
        [DataMember(Name = "expirydate")]
        public DateTime? ExpiryDate { get; set; }
    }

    [DataContract(Name = nameof(MessageType.INSTRUMENT_CREATE), Namespace = "")]
    public class InstrumentCreateReply : ServerMessage
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }
    }

    [DataContract(Name = nameof(MessageType.INSTRUMENT_DELETE), Namespace = "")]
    public class InstrumentDeleteReply : ServerMessage
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }
    }

    [DataContract(Name = nameof(MessageType.INSTRUMENT_DOWNLOAD), Namespace = "")]
    public class InstrumentDownloadReply : ServerMessage
    {
        [DataMember(Name = "assettype", Order = 1)]
        public AssetType? AssetType { get; set; }

        [DataMember(Name = "basecontract", Order = 2)]
        public int? BaseContract { get; set; }

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

        [DataMember(Name = "full_instrument_list", Order = 10)]
        public FullInstrumentList FullInstrumentList { get; set; }

        [DataMember(Name = "instrument_list", Order = 11)]
        public InstrumentList InstrumentList { get; set; }

        [DataMember(Name = "isincode", Order = 12)]
        public string IsinCodePattern { get; set; }

        [DataMember(Name = "issuer", Order = 13)]
        public string Issuer { get; set; }

        /// <summary>
        /// The number of items per received message. Only for replies that are split up. If the reply is split up, 
        /// this will also be indicated by the boolean flag MoreReplies in <see cref="ReplyInfo"/>.
        /// </summary>
        [DataMember(Name = "items_per_message", Order = 14)]
        public int? ItemsPerMessage { get; set; }
        
        [DataMember(Name = "kind", Order = 15)]
        public string Kind { get; set; }

        [DataMember(Name = "market", Order = 16)]
        public string Market { get; set; }

        /// <summary>
        /// If ItemsPerMessage is set to 100, the first reply will start at 1 and second at 101 and so on
        /// </summary>
        [DataMember(Name = "start_item_number", Order = 17)]
        public int? StartItemNumber { get; set; }

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

        /// <summary>
        /// The name of a tick rule. This key will only be returned when download_mode = full and if a subscription request has 
        /// already been sent for that instrument (either from OP with <see cref="Client.PriceFeedToggleMessage"/> or from the Orc Trader).
        /// </summary>
        [DataMember(Name = "tick_rule", Order = 23)]
        public string TickRule { get; set; }

        /// <summary>
        /// This is contained in the first reply message and corresponds to the total number of instruments to be downloaded.
        /// </summary>
        [DataMember(Name = "total_items_count", Order = 24)]
        public DateTime? TotalItemsCount { get; set; }

        [DataMember(Name = "underlying", Order = 25)]
        public string UnderlyingPattern { get; set; }
    }

    [DataContract(Name = nameof(MessageType.INSTRUMENT_DYNAMIC_PARAMETER_DELETE), Namespace = "")]
    public class InstrumentDynamicParameterDeleteReply : ServerMessage
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }
    }

    [DataContract(Name = nameof(MessageType.INSTRUMENT_DYNAMIC_PARAMETERS_SET), Namespace = "")]
    public class InstrumentDynamicParametersSetReply : ServerMessage
    {
        [DataMember(Name = "instrument_id", Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "dynamic_parameters", Order = 2)]
        public DynamicParameters Parameters { get; set; }
    }

    [DataContract(Name = nameof(MessageType.INSTRUMENT_GET), Namespace = "")]
    public class InstrumentGetReply : ServerMessage
    {
        [DataMember(Name = "instrument_id", Order = 1)]
        public InstrumentId InstrumentId { get; set; }

        [DataMember(Name = "instrument_attributes", Order = 2)]
        public InstrumentAttributes InstrumentAttributes { get; set; }

        [DataMember(Name = "parameters", Order = 3)]
        public Parameters Parameters { get; set; }

        /// <summary>
        /// The Orcs description of the contract. 
        /// </summary>
        [DataMember(Name = "orc_description", Order = 4)]
        public bool OrcDescription { get; set; }

        /// <summary>
        /// The name of a tick rule. This key will only be returned if a subscription request has 
        /// already been sent for that instrument (either from OP with <see cref="Client.PriceFeedToggleMessage"/> or from the Orc Trader).
        /// </summary>
        [DataMember(Name = "tick_rule", Order = 5)]
        public string TickRule { get; set; }
    }

    [DataContract(Name = nameof(MessageType.INSTRUMENT_GROUP_PARAMETERS_GET), Namespace = "")]
    public class InstrumentGroupParametersGetReply : ServerMessage
    {
        [DataMember(Name = "market", Order = 1)]
        public string Market { get; set; }

        [DataMember(Name = "enforced_customer_unique_id", Order = 2)]
        public string EnforcedCustomerUniqueIdPattern { get; set; }

        [DataMember(Name = "customer_unique_id", Order = 3)]
        public string CustomerUniqueIdPattern { get; set; }

        [DataMember(Name = "isincode", Order = 4)]
        public string IsinCodePattern { get; set; }

        [DataMember(Name = "symbol", Order = 5)]
        public string Symbol { get; set; }

        [DataMember(Name = "exchange", Order = 6)]
        public string Exchange { get; set; }

        [DataMember(Name = "issuer", Order = 7)]
        public string Issuer { get; set; }

        [DataMember(Name = "underlying", Order = 8)]
        public string UnderlyingPattern { get; set; }

        [DataMember(Name = "kind", Order = 9)]
        public string Kind { get; set; }

        [DataMember(Name = "strikeprice_min", Order = 10)]
        public double? StrikePriceMin { get; set; }

        [DataMember(Name = "strikeprice_max", Order = 11)]
        public double? StrikePriceMax { get; set; }

        [DataMember(Name = "expirydate_start", Order = 12)]
        public DateTime? ExpirydateStart { get; set; }

        [DataMember(Name = "expirydate_end", Order = 13)]
        public DateTime? ExpirydateEnd { get; set; }

        [DataMember(Name = "basecontract", Order = 14)]
        public int? BaseContract { get; set; }

        [DataMember(Name = "parameters_min", Order = 15)]
        public Parameters ParametersMin { get; set; }

        [DataMember(Name = "parameters_max", Order = 16)]
        public Parameters ParametersMax { get; set; }

        [DataMember(Name = "instrument_attributes_min", Order = 17)]
        public InstrumentAttributes InstrumentAttributesMin { get; set; }

        [DataMember(Name = "instrument_attributes_max", Order = 18)]
        public InstrumentAttributes InstrumentAttributesMax { get; set; }

        [DataMember(Name = "currency", Order = 19)]
        public string Currency { get; set; }

        [DataMember(Name = "assettype", Order = 20)]
        public AssetType? AssetType { get; set; }

        [DataMember(Name = "date_changed_from", Order = 21)]
        public DateTime? DateChangedFrom { get; set; }

        [DataMember(Name = "date_changed_to", Order = 22)]
        public DateTime? DateChangedTo { get; set; }

        [DataMember(Name = "time_changed_from", Order = 23)]
        public TimeSpan? TimeChangedFrom { get; set; }

        [DataMember(Name = "time_changed_to", Order = 24)]
        public TimeSpan? TimeChangedTo { get; set; }
    }

    [DataContract(Name = nameof(MessageType.INSTRUMENT_GROUP_PARAMETERS_SET), Namespace = "")]
    public class InstrumentGroupParametersSetReply : ServerMessage
    {
        [DataMember(Name = "market", Order = 1)]
        public string Market { get; set; }

        [DataMember(Name = "enforced_customer_unique_id", Order = 2)]
        public string EnforcedCustomerUniqueIdPattern { get; set; }

        [DataMember(Name = "customer_unique_id", Order = 3)]
        public string CustomerUniqueIdPattern { get; set; }

        [DataMember(Name = "isincode", Order = 4)]
        public string IsinCodePattern { get; set; }

        [DataMember(Name = "symbol", Order = 5)]
        public string Symbol { get; set; }

        [DataMember(Name = "exchange", Order = 6)]
        public string Exchange { get; set; }

        [DataMember(Name = "issuer", Order = 7)]
        public string Issuer { get; set; }

        [DataMember(Name = "underlying", Order = 8)]
        public string UnderlyingPattern { get; set; }

        [DataMember(Name = "kind", Order = 9)]
        public string Kind { get; set; }

        [DataMember(Name = "strikeprice_min", Order = 10)]
        public double? StrikePriceMin { get; set; }

        [DataMember(Name = "strikeprice_max", Order = 11)]
        public double? StrikePriceMax { get; set; }

        [DataMember(Name = "expirydate_start", Order = 12)]
        public DateTime? ExpirydateStart { get; set; }

        [DataMember(Name = "expirydate_end", Order = 13)]
        public DateTime? ExpirydateEnd { get; set; }

        [DataMember(Name = "basecontract", Order = 14)]
        public int? BaseContract { get; set; }

        [DataMember(Name = "parameters", Order = 15)]
        public Parameters Parameters { get; set; }

        [DataMember(Name = "currency", Order = 16)]
        public string Currency { get; set; }

        [DataMember(Name = "assettype", Order = 17)]
        public AssetType? AssetType { get; set; }
    }

    [DataContract(Name = nameof(MessageType.INSTRUMENT_MULTIPLE_FLAG_SET), Namespace = "")]
    public class InstrumentMultipleFlagSetReply : ServerMessage
    {
        [DataMember(Name = "flag", Order = 1)]
        public Flag? Flag { get; set; }

        [DataMember(Name = "value", Order = 2)]
        public bool? Value { get; set; }
    }

    [DataContract(Name = nameof(MessageType.INSTRUMENT_MULTIPLE_PARAMETER_SET), Namespace = "")]
    public class InstrumentMultipleParameterSetReply : ServerMessage
    {
        [DataMember(Name = "value", Order = 1)]
        public double? Value { get; set; }

        [DataMember(Name = "parameter", Order = 2)]
        public Parameter? Parameter { get; set; }

        [DataMember(Name = "parameter_update_type", Order = 3)]
        public ParameterUpdateType? UpdateType { get; set; }
    }


    [DataContract(Name = nameof(MessageType.INSTRUMENT_PARAMETERS_SET), Namespace = "")]
    public class InstrumentParametersSetReply : ServerMessage
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }
    }

    [DataContract(Name = nameof(MessageType.INSTRUMENT_SET_AS_PREFERRED), Namespace = "")]
    public class InstrumentSetAsPreferredReply : ServerMessage
    {
        [DataMember(Name = "instrument_id")]
        public InstrumentId InstrumentId { get; set; }
    }

}