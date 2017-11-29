using System;
using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;


namespace Orc.Library.Messages.Client
{
    /// <summary>
    /// Get all spread tables.
    /// </summary>
    [DataContract(Name = "spreadtable_download", Namespace = "")]
    public class SpreadtableDownloadMessage : ClientMessage
    {
        [DataMember(Name = "name", IsRequired = true, Order = 1)]
        public string name { get; set; }

        [DataMember(Name = "boundarymode", IsRequired = true, Order = 2)]
        public BoundaryMode? BoundaryMode { get; set; }

        [DataMember(Name = "direction", IsRequired = true, Order = 3)]
        public Direction? Direction { get; set; }

        public SpreadtableDownloadMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.SPREADTABLE_DOWNLOAD);
        }
    }

    /// <summary>
    /// Delete spread table entries.
    /// </summary>
    [DataContract(Name = "spreadtable_entries_delete", Namespace = "")]
    public class SpreadtableEntriesDeleteMessage : ClientMessage
    {
        [DataMember(Name = "spreadtable", IsRequired = true, Order = 1)]
        public string Spreadtable { get; set; }

        [DataMember(Name = "spreadtable_entries", IsRequired = true, Order = 2)]
        public SpreadtableEntries SpreadtableEntries { get; set; }

        public SpreadtableEntriesDeleteMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.SPREADTABLE_ENTRIES_DELETE);
        }
    }


    /// <summary>
    /// Insert spread table entries.
    /// </summary>
    [DataContract(Name = "spreadtable_entries_insert", Namespace = "")]
    public class SpreadtableEntriesInsertMessage : ClientMessage
    {
        [DataMember(Name = "spreadtable", IsRequired = true, Order = 1)]
        public string Spreadtable { get; set; }

        [DataMember(Name = "spreadtable_entries", IsRequired = true, Order = 2)]
        public SpreadtableEntries SpreadtableEntries { get; set; }

        public SpreadtableEntriesInsertMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.SPREADTABLE_ENTRIES_INSERT);
        }
    }


    /// <summary>
    /// Get the values for a specified spread table.
    /// </summary>
    [DataContract(Name = "spreadtable_get", Namespace = "")]
    public class SpreadtableGetMessage : ClientMessage
    {
        [DataMember(Name = "spreadtable", IsRequired = true, Order = 1)]
        public string Spreadtable { get; set; }

        [DataMember(Name = "spreadtable_entries", IsRequired = true, Order = 2)]
        public SpreadtableEntries SpreadtableEntries { get; set; }

        [DataMember(Name = "boundarymode", IsRequired = true, Order = 3)]
        public BoundaryMode? BoundaryMode { get; set; }

        [DataMember(Name = "direction", IsRequired = true, Order = 4)]
        public Direction? Direction { get; set; }

        public SpreadtableGetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.SPREADTABLE_GET);
        }
    }


    /// <summary>
    /// Insert a spread table.
    /// </summary>
    [DataContract(Name = "spreadtable_insert", Namespace = "")]
    public class SpreadtableInsertMessage : ClientMessage
    {
        [DataMember(Name = "spreadtable", IsRequired = true, Order = 1)]
        public string Spreadtable { get; set; }

        [DataMember(Name = "boundarymode", IsRequired = true, Order = 2)]
        public BoundaryMode? BoundaryMode { get; set; }

        [DataMember(Name = "direction", IsRequired = true, Order = 3)]
        public Direction? Direction { get; set; }

        public SpreadtableInsertMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.SPREADTABLE_INSERT);
        }
    }
}
