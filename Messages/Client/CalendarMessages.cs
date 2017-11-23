using System;
using System.Runtime.Serialization;
using Orc.Library.Enums;
using Orc.Library.Dictionaries;

namespace Orc.Library.Messages.Client
{

    [DataContract(Name = "calendar_get", Namespace = "")]
    public class CalendarGetMessage : ClientMessage
    {
        [DataMember(Name = "calendar", IsRequired = true)]
        public string Calendar { get; set; }

        public CalendarGetMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.CUSTOMER_GET);
        }
    }

    [DataContract(Name = "calendar_insert", Namespace = "")]
    public class CalendarInsertMessage : ClientMessage
    {
        [DataMember(Name = "calendar", IsRequired = true)]
        public string Calendar { get; set; }

        public CalendarInsertMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.calendar_insert);
        }
    }


    [DataContract(Name = "calendar_update", Namespace = "")]
    public class CalendarUpdateMessage : ClientMessage
    {
        [DataMember(Name = "calendar", IsRequired = true, Order = 1)]
        public string Calendar { get; set; }

        [DataMember(Name = "new_calendar", IsRequired = true, Order = 2)]
        public string NewCalendar { get; set; }

        public CalendarUpdateMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.CUSTOMER_UPDATE);
        }
    }

    [DataContract(Name = "calendar_set_default", Namespace = "")]
    public class CalendarSetDefaultMessage : ClientMessage
    {
        [DataMember(Name = "calendar", IsRequired = true)]
        public string Calendar { get; set; }

        public CalendarSetDefaultMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.calendar_set_default);
        }
    }

    [DataContract(Name = "calendar_delete", Namespace = "")]
    public class CalendarDeleteMessage : ClientMessage
    {
        [DataMember(Name = "calendar", IsRequired = true)]
        public string Calendar { get; set; }

        public CalendarDeleteMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.CUSTOMER_VALUE_GET);
        }
    }


    [DataContract(Name = "calendar_entries_delete", Namespace = "")]
    public class CalendarEntriesDeleteMessage : ClientMessage
    {
        [DataMember(Name = "calendar", IsRequired = true, Order = 1)]
        public string Calendar { get; set; }

        [DataMember(Name = "calendar_entries", IsRequired = true, Order = 2)]
        public CalendarEntries Entries { get; set; }

        public CalendarEntriesDeleteMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.calendar_entries_delete);
        }
    }

    [DataContract(Name = "calendar_entries_insert", Namespace = "")]
    public class CalendarEntriesInsertMessage : ClientMessage
    {
        [DataMember(Name = "calendar", IsRequired = true, Order = 1)]
        public string Calendar { get; set; }

        [DataMember(Name = "calendar_entries", IsRequired = true, Order = 2)]
        public CalendarEntries Entries { get; set; }

        public CalendarEntriesInsertMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.calendar_entries_insert);
        }
    }

    [DataContract(Name = "calendar_download", Namespace = "")]
    public class CalendarDownloadMessage : ClientMessage
    {
        public CalendarDownloadMessage()
        {
            Info = new MessageInfo(Guid.NewGuid(), MessageType.calendar_download);
        }
    }
}
