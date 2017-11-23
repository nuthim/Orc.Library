using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Orc.Library.Dictionaries
{
    [CollectionDataContract(Name = "calendars", ItemName = "calendar", Namespace = "")]
    public class Calendars : List<string>
    {

    }
}