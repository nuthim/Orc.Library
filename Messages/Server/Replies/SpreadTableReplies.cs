using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Server.Replies
{
    [DataContract(Name = nameof(MessageType.SPREADTABLE_DOWNLOAD), Namespace = "")]
    public class SpreadTableDownloadReply : ServerMessage
    {
        [DataMember(Name = "spread_tables")]
        public SpreadTables SpreadTables { get; set; }
    }


    [DataContract(Name = nameof(MessageType.SPREADTABLE_ENTRIES_DELETE), Namespace = "")]
    public class SpreadTableEntriesDeleteReply : ServerMessage
    {
        [DataMember(Name = "spreadtable")]
        public string SpreadTable { get; set; }
    }


    [DataContract(Name = nameof(MessageType.SPREADTABLE_ENTRIES_INSERT), Namespace = "")]
    public class SpreadTableEntriesInsertReply : ServerMessage
    {

    }


    [DataContract(Name = nameof(MessageType.SPREADTABLE_GET), Namespace = "")]
    public class SpreadTableGetReply : ServerMessage
    {
        [DataMember(Name = "spreadtable_entries", Order = 1)]
        public SpreadTableEntries SpreadTableEntries { get; set; }

        [DataMember(Name = "boundarymode", Order = 2)]
        public BoundaryMode? BoundaryMode { get; set; }

        [DataMember(Name = "direction", Order = 3)]
        public Direction? Direction { get; set; }
    }


    [DataContract(Name = nameof(MessageType.SPREADTABLE_INSERT), Namespace = "")]
    public class SpreadTableInsertReply : ServerMessage
    {

    }
}
