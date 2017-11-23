using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Orc.Library.Enums;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "calendar_entries", ItemName = "calendar_entry", Namespace = "")]
    public class CalendarEntries : List<CalendarEntry>
    {

    }

    [DataContract(Name = "calendar_entry", Namespace = "")]
    public class CalendarEntry
    {
        [DataMember(Name = "repeat_mode")]
        public RepeatMode? RepeatMode { get; set; }

        /// <summary>
        /// Mandatory for repeat_mode set to Date or Yearly
        /// </summary>
        [DataMember(Name = "date")]
        public DateTime? Date { get; set; }


        [DataMember(Name = "exclude")]
        public bool? Exclude { get; set; }
    }
}
