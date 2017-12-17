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
        [DataMember(Name = "repeat_mode", IsRequired = true, Order = 1)]
        public RepeatMode? RepeatMode { get; set; }

        /// <summary>
        /// Mandatory for repeat_mode set to Date or Yearly
        /// </summary>
        [DataMember(Name = "date", IsRequired = true, Order = 2)]
        public DateTime? Date { get; set; }


        [DataMember(Name = "exclude", Order = 3)]
        public bool? Exclude { get; set; }
    }
}
