using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;


namespace Orc.Library.Messages.Client
{
    /// <summary>
    /// Get all spread tables.
    /// </summary>
    [DataContract(Name = nameof(MessageType.SPREADTABLE_DOWNLOAD), Namespace = "")]
    public class SpreadTableDownloadMessage : ClientMessage
    {
        /// <summary>
        /// Name of the spreadtable.
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, Order = 1)]
        public string Name { get; set; }

        [DataMember(Name = "boundarymode", IsRequired = true, Order = 2)]
        public BoundaryMode? BoundaryMode { get; set; }

        [DataMember(Name = "direction", IsRequired = true, Order = 3)]
        public Direction? Direction { get; set; }

        public SpreadTableDownloadMessage() : base(MessageType.SPREADTABLE_DOWNLOAD)
        {

        }
    }

    /// <summary>
    /// Delete spread table entries.
    /// </summary>
    [DataContract(Name = nameof(MessageType.SPREADTABLE_ENTRIES_DELETE), Namespace = "")]
    public class SpreadTableEntriesDeleteMessage : ClientMessage
    {
        /// <summary>
        /// Name of the spreadtable.
        /// </summary>
        [DataMember(Name = "spreadtable", IsRequired = true, Order = 1)]
        public string SpreadTable { get; set; }

        [DataMember(Name = "spreadtable_entries", IsRequired = true, Order = 2)]
        public SpreadTableEntries SpreadTableEntries { get; set; }

        public SpreadTableEntriesDeleteMessage() : base(MessageType.SPREADTABLE_ENTRIES_DELETE)
        {

        }
    }


    /// <summary>
    /// Insert spread table entries.
    /// </summary>
    [DataContract(Name = nameof(MessageType.SPREADTABLE_ENTRIES_INSERT), Namespace = "")]
    public class SpreadTableEntriesInsertMessage : ClientMessage
    {
        /// <summary>
        /// Name of the spreadtable.
        /// </summary>
        [DataMember(Name = "spreadtable", IsRequired = true, Order = 1)]
        public string SpreadTable { get; set; }

        [DataMember(Name = "spreadtable_entries", IsRequired = true, Order = 2)]
        public SpreadTableEntries SpreadTableEntries { get; set; }

        public SpreadTableEntriesInsertMessage() : base(MessageType.SPREADTABLE_ENTRIES_INSERT)
        {

        }
    }


    /// <summary>
    /// Get the values for a specified spread table.
    /// </summary>
    [DataContract(Name = nameof(MessageType.SPREADTABLE_GET), Namespace = "")]
    public class SpreadTableGetMessage : ClientMessage
    {
        /// <summary>
        /// Name of the spreadtable.
        /// </summary>
        [DataMember(Name = "spreadtable", IsRequired = true, Order = 1)]
        public string SpreadTable { get; set; }

        [DataMember(Name = "spreadtable_entries", IsRequired = true, Order = 2)]
        public SpreadTableEntries SpreadTableEntries { get; set; }

        [DataMember(Name = "boundarymode", IsRequired = true, Order = 3)]
        public BoundaryMode? BoundaryMode { get; set; }

        [DataMember(Name = "direction", IsRequired = true, Order = 4)]
        public Direction? Direction { get; set; }

        public SpreadTableGetMessage() : base(MessageType.SPREADTABLE_GET)
        {

        }
    }


    /// <summary>
    /// Insert a spread table.
    /// </summary>
    [DataContract(Name = nameof(MessageType.SPREADTABLE_INSERT), Namespace = "")]
    public class SpreadTableInsertMessage : ClientMessage
    {
        /// <summary>
        /// Name of the spreadtable.
        /// </summary>
        [DataMember(Name = "spreadable", IsRequired = true, Order = 1)]
        public string SpreadTable { get; set; }

        [DataMember(Name = "boundarymode", IsRequired = true, Order = 2)]
        public BoundaryMode? BoundaryMode { get; set; }

        [DataMember(Name = "direction", IsRequired = true, Order = 3)]
        public Direction? Direction { get; set; }

        public SpreadTableInsertMessage() : base(MessageType.SPREADTABLE_INSERT)
        {

        }
    }
}
