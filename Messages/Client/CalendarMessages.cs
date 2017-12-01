using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Orc.Library.Enums;
using Orc.Library.Dictionaries;

namespace Orc.Library.Messages.Client
{

    [DataContract(Name = "CALENDAR_DELETE", Namespace = "")]
    public class CalendarDeleteMessage : ClientMessage
    {
        /// <summary>
        /// The name of the calendar
        /// </summary>
        [DataMember(Name = "calendar", IsRequired = true)]
        [StringLength(64)]
        public string Calendar { get; set; }

        public CalendarDeleteMessage() : base(MessageType.CALENDAR_DELETE)
        {

        }
    }

    [DataContract(Name = "CALENDAR_DOWNLOAD", Namespace = "")]
    public class CalendarDownloadMessage : ClientMessage
    {
        public CalendarDownloadMessage() : base(MessageType.CALENDAR_DOWNLOAD)
        {

        }
    }

    [DataContract(Name = "CALENDAR_ENTRIES_DELETE", Namespace = "")]
    public class CalendarEntriesDeleteMessage : ClientMessage
    {
        /// <summary>
        /// The name of the calendar
        /// </summary>
        [DataMember(Name = "calendar", IsRequired = true, Order = 1)]
        [StringLength(64)]
        public string Calendar { get; set; }

        [DataMember(Name = "calendar_entries", IsRequired = true, Order = 2)]
        public CalendarEntries Entries { get; set; }

        public CalendarEntriesDeleteMessage() : base(MessageType.CALENDAR_ENTRIES_DELETE)
        {

        }
    }

    [DataContract(Name = "CALENDAR_ENTRIES_INSERT", Namespace = "")]
    public class CalendarEntriesInsertMessage : ClientMessage
    {
        /// <summary>
        /// The name of the calendar
        /// </summary>
        [DataMember(Name = "calendar", IsRequired = true, Order = 1)]
        [StringLength(64)]
        public string Calendar { get; set; }

        [DataMember(Name = "calendar_entries", IsRequired = true, Order = 2)]
        public CalendarEntries Entries { get; set; }

        public CalendarEntriesInsertMessage() : base(MessageType.CALENDAR_ENTRIES_INSERT)
        {

        }
    }

    [DataContract(Name = "CALENDAR_GET", Namespace = "")]
    public class CalendarGetMessage : ClientMessage
    {
        /// <summary>
        /// The name of the calendar
        /// </summary>
        [DataMember(Name = "calendar", IsRequired = true)]
        [StringLength(64)]
        public string Calendar { get; set; }

        public CalendarGetMessage() : base(MessageType.CALENDAR_GET)
        {
            
        }
    }

    [DataContract(Name = "CALENDAR_INSERT", Namespace = "")]
    public class CalendarInsertMessage : ClientMessage
    {
        /// <summary>
        /// The name of the calendar
        /// </summary>
        [DataMember(Name = "calendar", IsRequired = true)]
        [StringLength(64)]
        public string Calendar { get; set; }

        public CalendarInsertMessage() : base(MessageType.CALENDAR_INSERT)
        {
            
        }
    }

    [DataContract(Name = "CALENDAR_SET_DEFAULT", Namespace = "")]
    public class CalendarSetDefaultMessage : ClientMessage
    {
        /// <summary>
        /// The name of the calendar
        /// </summary>
        [DataMember(Name = "calendar", IsRequired = true)]
        [StringLength(64)]
        public string Calendar { get; set; }

        public CalendarSetDefaultMessage() : base(MessageType.CALENDAR_SET_DEFAULT)
        {

        }
    }

    [DataContract(Name = "CALENDAR_UPDATE", Namespace = "")]
    public class CalendarUpdateMessage : ClientMessage
    {
        /// <summary>
        /// The name of the calendar
        /// </summary>
        [DataMember(Name = "calendar", IsRequired = true, Order = 1)]
        [StringLength(64)]
        public string Calendar { get; set; }

        /// <summary>
        /// The name of the new calendar
        /// </summary>
        [DataMember(Name = "new_calendar", IsRequired = true, Order = 2)]
        [StringLength(64)]
        public string NewCalendar { get; set; }

        public CalendarUpdateMessage() : base(MessageType.CALENDAR_UPDATE)
        {
           
        }
    }


}
