using System.Runtime.Serialization;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;

namespace Orc.Library.Messages.Server
{

    [DataContract(Name = nameof(MessageType.CALENDAR_DELETE), Namespace = "")]
    public class CalendarDeleteReply : ServerMessage
    {
        /// <summary>
        /// The name of the calendar
        /// </summary>
        [DataMember(Name = "calendar")]
        public string Calendar { get; set; }
    }

    [DataContract(Name = nameof(MessageType.CALENDAR_DOWNLOAD), Namespace = "")]
    public class CalendarDownloadReply : ServerMessage
    {
        /// <summary>
        /// The name of the calendar
        /// </summary>
        [DataMember(Name = "calendars", Order = 1)]
        public Calendars Calendars { get; set; }

        /// <summary>
        /// Name of the default calendar.
        /// </summary>
        [DataMember(Name = "default_calendar", Order = 2)]
        public string DefaultCalendar { get; set; }
    }

    [DataContract(Name = nameof(MessageType.CALENDAR_ENTRIES_DELETE), Namespace = "")]
    public class CalendarEntriesDeleteReply : ServerMessage
    {
        /// <summary>
        /// The name of the calendar
        /// </summary>
        [DataMember(Name = "calendar")]
        public string Calendar { get; set; }
    }

    [DataContract(Name = nameof(MessageType.CALENDAR_ENTRIES_INSERT), Namespace = "")]
    public class CalendarEntriesInsertReply : ServerMessage
    {
        /// <summary>
        /// The name of the calendar
        /// </summary>
        [DataMember(Name = "calendar")]
        public string Calendar { get; set; }
    }

    [DataContract(Name = nameof(MessageType.CALENDAR_GET), Namespace = "")]
    public class CalendarGetReply : ServerMessage
    {
        /// <summary>
        /// The name of the calendar
        /// </summary>
        [DataMember(Name = "calendar", Order = 1)]
        public string Calendar { get; set; }

        [DataMember(Name = "calendar_entries", Order = 2)]
        public CalendarEntries CalendarEntries { get; set; }
    }

    [DataContract(Name = nameof(MessageType.CALENDAR_INSERT), Namespace = "")]
    public class CalendarInsertReply : ServerMessage
    {
        /// <summary>
        /// The name of the calendar
        /// </summary>
        [DataMember(Name = "calendar")]
        public string Calendar { get; set; }
    }

    [DataContract(Name = nameof(MessageType.CALENDAR_SET_DEFAULT), Namespace = "")]
    public class CalendarSetDefaultReply : ServerMessage
    {
        /// <summary>
        /// The name of the calendar
        /// </summary>
        [DataMember(Name = "calendar")]
        public string Calendar { get; set; }
    }

    [DataContract(Name = nameof(MessageType.CALENDAR_UPDATE), Namespace = "")]
    public class CalendarUpdateReply : ServerMessage
    {
        /// <summary>
        /// The name of the calendar
        /// </summary>
        [DataMember(Name = "calendar")]
        public string Calendar { get; set; }
    }

}
