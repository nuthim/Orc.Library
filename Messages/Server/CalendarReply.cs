using System.Runtime.Serialization;
using Orc.Library.Enums;


namespace Orc.Library.Messages.Server
{
    public class CalendarCollection : OrcMessage
    {
        [DataMember(Name = "calendars")]
        public string[] Calendars { get; set; }

        [DataMember(Name = "default_calendar")]
        public string DefaultCalendar { get; set; }
    }

    public class CalendarReply : OrcMessage
    {
        [DataMember(Name = "calendar")]
        public string Calendar { get; set; }
    }
}