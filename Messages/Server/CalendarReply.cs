using System.Runtime.Serialization;


namespace Orc.Library.Messages.Server
{
    public class CalendarCollection : ServerMessage
    {
        [DataMember(Name = "calendars")]
        public string[] Calendars { get; set; }

        [DataMember(Name = "default_calendar")]
        public string DefaultCalendar { get; set; }
    }

    public class CalendarReply : ServerMessage
    {
        [DataMember(Name = "calendar")]
        public string Calendar { get; set; }
    }
}