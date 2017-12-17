using System;
using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Server.Replies
{
    [DataContract(Name = nameof(MessageType.UNDERLYING_COVARIANCE_DELETE), Namespace = "")]
    public class UnderlyingCovarianceDeleteReply : ServerMessage
    {
        [DataMember(Name = "underlying1", Order = 1)]
        public string Underlying1 { get; set; }

        [DataMember(Name = "underlying2", Order = 2)]
        public string Underlying2 { get; set; }

        [DataMember(Name = "days", Order = 3)]
        public int? Days { get; set; }
    }


    [DataContract(Name = nameof(MessageType.UNDERLYING_COVARIANCE_GET), Namespace = "")]
    public class UnderlyingCovarianceGetReply : ServerMessage
    {
        [DataMember(Name = "underlying_covariances")]
        public UnderlyingCovariances UnderlyingCovariances { get; set; }
    }


    [DataContract(Name = nameof(MessageType.UNDERLYING_COVARIANCE_UPDATE), Namespace = "")]
    public class UnderlyingCovarianceUpdateReply : ServerMessage
    {
        [DataMember(Name = "underlying1", Order = 1)]
        public string Underlying1 { get; set; }

        [DataMember(Name = "underlying2", Order = 2)]
        public string Underlying2 { get; set; }

        [DataMember(Name = "days", Order = 3)]
        public int? Days { get; set; }
    }


    [DataContract(Name = nameof(MessageType.UNDERLYING_DOWNLOAD), Namespace = "")]
    public class UnderlyingDownloadReply : ServerMessage
    {
        [DataMember(Name = "underlyings")]
        public Underlyings Underlyings { get; set; }
    }


    [DataContract(Name = nameof(MessageType.UNDERLYING_RATECURVE_DELETE), Namespace = "")]
    public class UnderlyingRateCurveDeleteReply : ServerMessage
    {
        [DataMember(Name = "underlying", Order = 1)]
        public string Underlying { get; set; }

        [DataMember(Name = "type", Order = 2)]
        public DateOrDays? Type { get; set; }

        [DataMember(Name = "date", Order = 3)]
        public DateTime? Date { get; set; }

        [DataMember(Name = "days", Order = 4)]
        public int? Days { get; set; }
    }


    [DataContract(Name = nameof(MessageType.UNDERLYING_RATECURVE_GET), Namespace = "")]
    public class UnderlyingRateCurveGetReply : ServerMessage
    {
        [DataMember(Name = "underlying", Order = 1)]
        public string Underlying { get; set; }

        [DataMember(Name = "type", Order = 2)]
        public DateOrDays? Type { get; set; }

        [DataMember(Name = "underlying_ratecurve_entries", Order = 3)]
        public UnderlyingRateCurveEntries UnderlyingRateCurveEntries { get; set; }
    }


    [DataContract(Name = nameof(MessageType.UNDERLYING_RATECURVE_UPDATE), Namespace = "")]
    public class UnderlyingRateCurveUpdateReply : ServerMessage
    {
        [DataMember(Name = "underlying", Order = 1)]
        public string Underlying { get; set; }

        [DataMember(Name = "type", Order = 2)]
        public DateOrDays? Type { get; set; }
    }


    [DataContract(Name = nameof(MessageType.UNDERLYING_UPDATE), Namespace = "")]
    public class UnderlyingUpdateReply : ServerMessage
    {
        [DataMember(Name = "underlying")]
        public string Underlying { get; set; }
    }

}
