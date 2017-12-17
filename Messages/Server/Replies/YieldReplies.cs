using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Server.Replies
{
    [DataContract(Name = nameof(MessageType.YIELD_CURVE_DEFAULT), Namespace = "")]
    public class YieldCurveDefaultReply : ServerMessage
    {
        [DataMember(Name = "yield_name", Order = 1)]
        public string YieldName { get; set; }

        [DataMember(Name = "currency", Order = 2)]
        public string Currency { get; set; }
    }


    [DataContract(Name = nameof(MessageType.YIELD_CURVE_DELETE), Namespace = "")]
    public class YieldCurveDeteteReply : ServerMessage
    {
        [DataMember(Name = "yield_name", Order = 1)]
        public string YieldName { get; set; }

        [DataMember(Name = "currency", Order = 2)]
        public string Currency { get; set; }
    }


    [DataContract(Name = nameof(MessageType.YIELD_CURVE_DOWNLOAD), Namespace = "")]
    public class YieldCurveDownloadReply : ServerMessage
    {
        [DataMember(Name = "yield_curve_downloads")]
        public YieldCurveDownloads YieldCurveDownloads { get; set; }
    }


    [DataContract(Name = nameof(MessageType.YIELD_CURVE_GET), Namespace = "")]
    public class YieldCurveGetReply : ServerMessage
    {
        [DataMember(Name = "yield_name", Order = 1)]
        public string YieldName { get; set; }

        [DataMember(Name = "currency", Order = 2)]
        public string Currency { get; set; }

        [DataMember(Name = "yield_curve", Order = 3)]
        public YieldCurve YieldCurve { get; set; }
    }


    [DataContract(Name = nameof(MessageType.YIELD_CURVE_INSERT), Namespace = "")]
    public class YieldCurveInsertReply : ServerMessage
    {
        [DataMember(Name = "yield_name", Order = 1)]
        public string YieldName { get; set; }

        [DataMember(Name = "currency", Order = 2)]
        public string Currency { get; set; }
    }


    [DataContract(Name = nameof(MessageType.YIELD_CURVE_UPDATE), Namespace = "")]
    public class YieldCurveUpdateReply : ServerMessage
    {
        [DataMember(Name = "yield_name", Order = 1)]
        public string YieldName { get; set; }

        [DataMember(Name = "currency", Order = 2)]
        public string Currency { get; set; }
    }
}
